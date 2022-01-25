using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yazilimSinamaButunleme
{
    public class DatabaseOperation
    {
        public static string connectionString = "Data Source=DESKTOP-FTLF7MA;Initial Catalog = Messages; Integrated Security = True";
        SqlConnection connect = new SqlConnection(connectionString);
 
        public void addMessage(string sender,string message) {
            DateTime datetime = DateTime.Now;
            try
            {
                if (connect.State == System.Data.ConnectionState.Closed)
                    connect.Open();
                SqlCommand command = new SqlCommand("insert into Messages(MessageSender,Message,Date) values(@MessageSender,@Message,@Date)", connect);
                command.Parameters.AddWithValue("@MessageSender", sender);
                command.Parameters.AddWithValue("@Message", message);
                command.Parameters.AddWithValue("@Date", datetime.ToString());
                command.ExecuteNonQuery();
                connect.Close();
     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable List(string sql)
        {
            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connect);
            adapter.Fill(tbl);  
            return tbl;
        }
        public DataTable refresh()
        {     
            return List("Select * from Messages Order By Date ASC");
        }

    }
}
