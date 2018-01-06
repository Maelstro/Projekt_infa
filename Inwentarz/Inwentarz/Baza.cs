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

namespace Inwentarz
{
    public partial class Baza : Form
    {
        DataClasses1DataContext dc = new DataClasses1DataContext();
        
        public Baza()
        {
            InitializeComponent();
        }
        private void Baza_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-A932NOV;Initial Catalog=Albumy;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM Albumy", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv1.DataSource = dt;
            this.ControlBox = false;
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz się wylogować?", "Wyjście", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Login okno = new Login();
                okno.Show();
            }
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz zakończyć program?", "Wyjście", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pomocToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Pomoc okno = new Pomoc();
            okno.Show();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
