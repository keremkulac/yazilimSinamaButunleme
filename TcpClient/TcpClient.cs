using SimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazilimSinamaButunleme;
namespace yazilimSinamaButunleme
{
    public partial class TcpClient : Form
    {
        SimpleTcpClient client;
        DatabaseOperation databaseOperation = new DatabaseOperation();
        SHA256 sha256 = new SHA256();
        SPN spn = new SPN();
        AES aes = new AES();
        DES des = new DES();

        public TcpClient()
        {
            InitializeComponent();
            // Formun başlama pozisyonları verilir
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(800, 250);
            clear();
        }
        
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Client bağlanır gönderme butonu aktif Bağlan butonu etkisiz hale gelir
                client.Connect();
                btnSend.Enabled = true;
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            // client bağlı ise ve mesaj boş veya null değil ise mesajı gönderir ekrana yazar 
            if (client.IsConnected)
            {
                if (!string.IsNullOrEmpty(txtMessage.Text))
                {
                    client.Send(txtMessage.Text);
                    txtInfo.Text += $"Me:{txtMessage.Text}{Environment.NewLine}";
                    // Gönderilen mesaj veritabanına eklenir
                    databaseOperation.addMessage("Client",txtMessage.Text);
                    txtMessage.Text = string.Empty;
                }
                // Mesaj boş veya null ise mesaj girin uyarısı verir
                else
                {
                    MessageBox.Show("Enter a message ");
                }

            }
            // Veritabanı kaydından sonra dataridview yenilenir
            fillDgvAndRefresh();
        }  
        public void fillDgvAndRefresh()
        {
            // veritabanından gelen verileri datagridview a doldurur
            dgvFindMessage.DataSource = databaseOperation.refresh();
        }
       
        private void TCPclient_Load(object sender, EventArgs e)
        { 
            // Form açılırken datagridview doldurulur gönderme butonu etkisiz hale getirilir
            fillDgvAndRefresh();
            // verilen ip ve port numarasına göre server bağlantısı yapılır 
            client = new(txtIP.Text,Convert.ToInt32(txtPort.Text));
            client.Events.Connected += Events_Connected;
            client.Events.Disconnected += Events_Disconnected;
            client.Events.DataReceived += Events_DataReceived;
            btnSend.Enabled = false;   
        }

        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                // veri gönderlirken ekrana ıp ve port numarası yazılır
                txtInfo.Text += $"Client: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });

        }
        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                // Hangi ip ve port numarasının çıktığını yazar
                txtInfo.Text += $"Client disconnected.{Environment.NewLine}";
            });
        }

        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                // Hangi ip ve port numarasının bağlandığını yazar
                txtInfo.Text += $"Server connected.{Environment.NewLine}";
            });

        }

        private void txtFindMessage_TextChanged(object sender, EventArgs e)
        {
            // textboxa her girilen girdide mesaj veya tarihe göre filtreleme yapıp datagridview a doldurulup yenilenir
            dgvFindMessage.DataSource = databaseOperation.List("Select * from Messages where Message like '%" + txtFindMessage.Text + "%' or Date like '%" + txtFindMessage.Text + "%'");
        }

        private void btnEncrypt_Click(object sender, EventArgs e)

        {
            string key = "12345678";
            // Şifrelenecek mesaj boş veya null ise ekrana mesaj girilmesi uyarısı çıkar
            if (String.IsNullOrWhiteSpace(txtEncryptMessage.Text) || String.IsNullOrEmpty(txtEncryptMessage.Text))
            {
                MessageBox.Show("Please enter a message.");
            }
            else
            {
                // Herhangi bir şifreleme algoritması seçiliyse seçilen algoritmaya göre mesaj şifrelenir şifrelenmiş mesaj kısmına yazılır
                if ((rbSHA256.Checked) || (rbSPN.Checked) || (rbAES.Checked) || (rbDES.Checked))
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
                        txtEncryptedMessage.Text = des.EncryptionDES(txtEncryptMessage.Text, key);
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

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string key = "12345678";
            // Şifresi çözülecek mesaj boş veya null ise ekrana mesaj girilmesi uyarısı çıkar
            if (String.IsNullOrWhiteSpace(txtEncryptMessage.Text) || String.IsNullOrEmpty(txtEncryptMessage.Text))
            {
                MessageBox.Show("Please enter a message.");
            }
            else
            {// Herhangi bir şifre çözme algoritması seçiliyse seçilen algoritmaya göre mesaj çözülür çözülmüş mesaj kısmına yazılır
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
