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
    public partial class Baza : Form
    {
        static DataClasses1DataContext db = new DataClasses1DataContext(@"Data Source=DESKTOP-A932NOV;Initial Catalog=Albumy;Integrated Security=True");

        public Baza()
        {
            InitializeComponent();
        }
        private void Baza_Load(object sender, EventArgs e)
        {
        
            var query = from c in db.Albumy select c;
            dgv1.DataSource = query;
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
            Form2 okno = new Form2();
            okno.Show();
            var query = from c in db.Albumy select c;
            dgv1.DataSource = query;
            this.ControlBox = false;
        }

        private void dgv1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(wyk.Text))
            {
                var query = from c in db.Albumy
                where c.Wykonawca == wyk.Text && c.Stan == stan.Text
                select c;
                dgv1.DataSource = query;
                this.ControlBox = false;
            }
            if (!String.IsNullOrWhiteSpace(tyt.Text))
            {
                var query = from c in db.Albumy
                            where c.Tytuł == tyt.Text && c.Stan == stan.Text
                            select c;
                dgv1.DataSource = query;
                this.ControlBox = false;
            }
            if (!String.IsNullOrWhiteSpace(rok.Text))
            {
                var query = from c in db.Albumy
                            where c.Rok_wydania == int.Parse(rok.Text) && c.Stan == stan.Text
                            select c;
                dgv1.DataSource = query;
                this.ControlBox = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var query = from c in db.Albumy select c;
            dgv1.DataSource = query;
            this.ControlBox = false;
        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy na pewno chcesz usunąć rekordy?", "Usuwanie", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-A932NOV;Initial Catalog=Albumy;Integrated Security=True");
                conn.Open();
                System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                cmd.Connection = conn;

                foreach (DataGridViewRow item in dgv1.SelectedRows)
                {
                    cmd.CommandText = "DELETE FROM dbo.Albumy WHERE Tytuł = '" + (item.Cells[2].Value) + "'";
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usunięto.");
                }
                conn.Close();
                var query = from c in db.Albumy select c;
                dgv1.DataSource = query;
                this.ControlBox = false;

            }
        }
    }
}
