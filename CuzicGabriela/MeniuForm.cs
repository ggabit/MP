using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CuzicGabriela
{
    public partial class MeniuForm : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        public MeniuForm()
        {
            InitializeComponent();
        }

        private void A1(Boolean v)
        {
            menuStrip1.Visible = !v;
            lblTitlu.Visible = !v;
            lblAutor.Visible = !v;
            lblParola.Visible = v;
            txtParola.Visible = v;
            lblUtilizator.Visible = v;
            txtUtilizator.Visible = v;
            if (v)
            {
                btnStart.Text = "Log In";
                txtUtilizator.Text = "";
                txtParola.Text = "";
            }
            else btnStart.Text = "Log Out";
        }

        private Boolean Logare_OK()
        {
            if (txtUtilizator.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txtUtilizator.Focus();
                return false;
            }
            if (txtParola.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txtParola.Focus();
                return false;
            }
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
            "Data Source=D:\\Medii de proiectare\\Proiect sem2\\BD-ServiceAuto.mdb";
            cmd.Connection = con;
            cmd.CommandText = "Select username,parola from Conturi " +
            "where username='" + txtUtilizator.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (txtParola.Text != rdr.GetString(1))
                {
                    MessageBox.Show("Parola eronata");
                    txtParola.Focus();
                    con.Close();
                    return false;
                }
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Utilizator eronat");
                txtUtilizator.Focus();
                con.Close();
                return false;
            }
        }

        private void aprovizionareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacturiVizForm f = new FacturiVizForm();
            f.ShowDialog();
        }

        private void consumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BonConsumVizForm f = new BonConsumVizForm();
            f.ShowDialog();
        }

        private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientiForm f = new ClientiForm();
            f.ShowDialog();
        }

        private void furnizoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FurnizoriForm f = new FurnizoriForm();
            f.ShowDialog();
        }

        private void lucrariToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LucrariForm f = new LucrariForm();
            f.ShowDialog();
        }

        private void tipuriResursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PieseAutoForm f = new PieseAutoForm();
            f.ShowDialog();
        }

        private void arhivaStocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StocInitialForm f = new StocInitialForm();
            f.ShowDialog();
        }

        private void MeniuForm_Load(object sender, EventArgs e)
        {
            A1(true);
        }

        private void CalculResursaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalantaForm f = new BalantaForm();
            f.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Log In")
            {
                if (Logare_OK()) A1(false);
            }
            else A1(true);
        }
    }
}
