//using DatabaseOperation;
using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilimSinamaButunleme
{
    public partial class TcpServer : Form
    {
        SimpleTcpServer server;
        SHA256 sha256 = new SHA256();
        SPN spn = new SPN();
        AES aes = new AES();
        DES des = new DES();
        DatabaseOperation operations = new DatabaseOperation();
        public TcpServer()
        {
            InitializeComponent();
            // Formun başlama pozisyonları verilir
            this.StartPosition = FormStartPosition.Manual;  
            this.Location = new Point(100, 250);
            clear();
        }     
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Server ı başlatır ekrana Starting yazar
            // başlatma butonu etkisiz gönderme butonu aktif eder
            server.Start();
            txtInfo.Text += $"Starting...{Environment.NewLine}";
            btnStart.Enabled = false;
            btnSend.Enabled = true;     
        }
        public void fillDgvAndRefresh()
        {
            // veritabanından gelen verileri datagridview a doldurur
            dgvFindMessage.DataSource = operations.refresh();
        }  
        private void TcpServer_Load(object sender, EventArgs e)
        {
            // Form açılırken datagridview doldurulur gönderme botonu etkisiz hale getirilir
            // verilen ip ve port numarasına göre server bağlantısı yapılır 
            fillDgvAndRefresh();
            btnSend.Enabled = false;
            server = new SimpleTcpServer(txtIP.Text, Convert.ToInt32(txtPort.Text));
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataReceived;         
        }    
        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            // veri gönderlirken ekrana ıp ve port numarası yazılır
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort}:{Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }
        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                // Hangi ip ve port numarasının çıktığını yazar
                txtInfo.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                // Client ip listesinden ip ve port numarasını siler
                lstClientIP.Items.Remove(e.IpPort);
            });      
        }
        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                // Hangi ip ve port numarasının bağlandığını yazar
                txtInfo.Text += $"{e.IpPort} connected.{Environment.NewLine}";
                // Client io listesine ip ve port numarasını ekler
                lstClientIP.Items.Add(e.IpPort);
            });  
        }      
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                // client bağlı ise ve mesaj boş veya null değil ise mesajı gönderir ekrana yazar
                if (!string.IsNullOrEmpty(txtMessage.Text) && lstClientIP.SelectedItem != null)
                {
                    server.Send(lstClientIP.SelectedItem.ToString(), txtMessage.Text);   
                    txtInfo.Text += $"Server: {txtMessage.Text}{Environment.NewLine}";
                    // Gönderilen mesaj veritabanına eklenir
                    operations.addMessage("Server", txtMessage.Text);
                    txtMessage.Text = string.Empty;
                }
                // Mesaj boş veya null ise  mesaj girin uyarısı verir ip seçili değil ise ip seçilmesi söylenir
                else
                {
                    MessageBox.Show("Enter a message or choose an ip ");
                }
            }
            // Veritabanı kaydından sonra dataridview yenilenir
            fillDgvAndRefresh();
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string key = "12345678";
           // Şifrelenecek mesaj boş veya null ise ekrana mesaj girilmesi uyarısı çıkar
            if(String.IsNullOrWhiteSpace(txtEncryptMessage.Text) || String.IsNullOrEmpty(txtEncryptMessage.Text))
            {
                MessageBox.Show("Please enter a message.");
            }
            else
            {
                // Herhangi bir şifreleme algoritması seçiliyse seçilen algoritmaya göre mesaj şifrelenir şifrelenmiş mesaj kısmına yazılır
                if ((rbSHA256.Checked ) || (rbSPN.Checked ) || (rbAES.Checked) || (rbDES.Checked))
                {
                    if (rbSHA256.Checked)
                    {
                        txtEncryptedMessage.Text = sha256.encryptionSHA256(txtEncryptMessage.Text);
                    }
                    else if (rbAES.Checked)
                    {
                        txtEncryptedMessage.Text = aes.encryptAES(txtEncryptMessage.Text);
                    }
                    else if (rbDES.Checked)
                    {
                        txtEncryptedMessage.Text = des.EncryptionDES(txtEncryptMessage.Text,key);
                    }     
                }
                // Herhangi bir şifreleme algoritması seçilmezse ekrana bir şifreleme algoritması seçin mesajı çıkar
                else { 
                    MessageBox.Show("Please select an encryption type");
                }
            }
            // Temizleme yapılır
            clear();
        }
        public void clear()
        {
            // mesaj kısmını siler ve şifreleme algoritmalarının işaretini kaldırır
            txtEncryptMessage.Text = "";
            rbSHA256.Checked = false;
            rbSPN.Checked = false;
            rbAES.Checked = false;
            rbDES.Checked = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEncryptedMessage.Text = "";
            clear();
        }
        private void txtFindMessage_TextChanged(object sender, EventArgs e)
        {
            // textboxa her girilen girdide mesaj veya tarihe göre filtreleme yapıp datagridview a doldurulup yenilenir
            dgvFindMessage.DataSource = operations.List("Select * from Messages where Message like '%" + txtFindMessage.Text + "%' or Date like '%"+ txtFindMessage.Text +"%'");    
        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string key = "12345678";
            // Şifresi çözülecek mesaj boş veya null ise ekrana mesaj girilmesi uyarısı çıkar
            if (String.IsNullOrWhiteSpace(txtEncryptMessage.Text) || String.IsNullOrEmpty(txtEncryptMessage.Text))
            {
                MessageBox.Show("Please enter a message.");
            }
            else
            { // Herhangi bir şifre çözme algoritması seçiliyse seçilen algoritmaya göre mesaj çözülür çözülmüş mesaj kısmına yazılır
                if ((rbSHA256.Checked) || (rbSPN.Checked) || (rbAES.Checked) || (rbDES.Checked))
                {
                    if (rbAES.Checked)
                    {
                        txtEncryptedMessage.Text = aes.decryptAES(txtEncryptMessage.Text);
                    }
                    else if (rbDES.Checked)
                    {
                        txtEncryptedMessage.Text = des.DecryptionDES(txtEncryptMessage.Text, key);
                    }
                }
                // Herhangi bir şifreleme algoritması seçilmezse ekrana bir şifreleme algoritması seçin mesajı çıkar
                else
                {
                    MessageBox.Show("Please select an encryption type");
                }
            }
            // Temizleme yapılır
            clear();
        }
    }
  }

