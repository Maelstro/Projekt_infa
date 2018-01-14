using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Linq;

namespace Inwentarz
{
    public partial class Form2 : Form
    {
        static DataClasses1DataContext db = new DataClasses1DataContext(@"Data Source=DESKTOP-A932NOV;Initial Catalog=Albumy;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-A932NOV;Initial Catalog=Albumy;Integrated Security=True");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM dbo.Albumy", conn);
            Int32 count = (Int32)comm.ExecuteScalar();
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            
            cmd.CommandText = "INSERT INTO dbo.Albumy VALUES ('"+(count+1)+"','" + textBox1.Text + "' , '" + textBox2.Text + "' , '" + int.Parse(textBox3.Text) + "' , '"+Decimal.Parse(textBox4.Text)+"' , '" +
                int.Parse(textBox5.Text) + "' , '" + textBox6.Text + "')";
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.ExecuteNonQuery();
            conn.Close();
            this.Close();
            
        }
            
    }
}
