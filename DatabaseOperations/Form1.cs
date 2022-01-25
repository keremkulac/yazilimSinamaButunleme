using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseOperations
{
    public partial class Form1 : Form
    {
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        public Form1()
        {
            InitializeComponent();
        }
        public static string connectionString = "Data Source=DESKTOP-FTLF7MA;Initial Catalog = Messages; Integrated Security = True";
        SqlConnection connect = new SqlConnection(connectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(connect.State == ConnectionState.Closed)
                    connect.Open();
                string addMessage = "insert into Messages(MessageSender,Message,Date) values(@MessageSender,@Message,@Date)";

                SqlCommand command = new SqlCommand(addMessage,connect);
                command.Parameters.AddWithValue("@MessageSender","deneme");
                command.Parameters.AddWithValue("@Message", "deneme12312");
                command.Parameters.AddWithValue("@Date", date);
                command.ExecuteNonQuery();  
                connect.Close();  
                MessageBox.Show("Başarili");
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }
    }
}
