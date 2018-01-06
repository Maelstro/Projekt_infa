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

namespace Inwentarz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Dopisać sprawdzenie loginu/hasła
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-A932NOV;Initial Catalog=Albumy;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
             FROM[Albumy].[dbo].[Login] Where login = '"+ textBox1.Text +"' and password = '"+ textBox2.Text +"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                this.Hide();
                Baza okno = new Baza();
                okno.Show(); 
            }
            else
            {
                MessageBox.Show("Proszę spróbować ponownie.","Błędne hasło",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                button1_Click(sender, e);
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button2_Click(sender, e);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
