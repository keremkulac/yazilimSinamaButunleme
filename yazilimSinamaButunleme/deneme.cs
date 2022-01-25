using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilimSinamaButunleme
{
    public partial class deneme : Form
    {
        public deneme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // SHA256 sha256 = new SHA256();
        //    textBox2.Text=sha256.encryptionSHA256(textBox1.Text);
         //   textBox3.Text = sha256.decryptionSHA256(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
        //    AES aes = new AES();
          //  textBox2.Text = aes.EncryptData(textBox1.Text,"deneme");
            //textBox3.Text = aes.DecryptData(textBox2.Text,"deneme");
        }

        private void button3_Click(object sender, EventArgs e)
        {
        //    DES des = new DES();
         //   textBox2.Text = des.EncryptionDES(textBox1.Text, "password");
         //   textBox3.Text = des.EncryptionDES(textBox2.Text, "password");
        }
    }
}
