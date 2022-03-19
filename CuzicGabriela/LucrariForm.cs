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
    public partial class LucrariForm : Form
    {
        public LucrariForm()
        {
            InitializeComponent();
        }

        private void LucrariForm_Load(object sender, EventArgs e)
        {
            A1();
        }

        private void A1()
        {
            //Umple cu date obiectele DataTable: Lucrari (din DataSet):
            lucrariTableAdapter.Fill(dataSet1.Lucrari);
            //Protectie grid
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            //Protectie txtIdLucrari
            txtIdLucrare.ReadOnly = true;
            A3();
        }
        private void A2()
        {
            //Configurare butoane
            configureazaButoane(false);
            //Dezlegare controale Panel
            legareControale(false);
            //Ridicare protectie controale Panel
            protectiePanel(false);
            //Modifcare lblOp
            lblOp.Text = "ADAUGARE";
            //Pozitionare cursor pe primul camp
            txtDLucrare.Focus();
            // Golire campuri
            golireCampuri();
        }

        private void A3()
        {
            //Initializare lblOp
            lblOp.Text = "";
            //Çonfigurare(butoane)
            configureazaButoane(true);
            //Protectie componente Panel
            protectiePanel(true);
            //Legare controale
            legareControale(true);
        }
        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;
                adauga_inregistrare();
                golireCampuri();
                //Pune cursor pe primul camp
                txtDLucrare.Focus();
                refresh_grid(lucrariBindingSource.Position);
            }
            else if (lblOp.Text == "ACTUALIZARE")
            {
                if (!validareCampuriObligatorii()) return;
                modifica_inregistrare();
                refresh_grid(lucrariBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void A5(TextBox txtB)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;

            if (txtB == txtDLucrare)
            {
                con.ConnectionString = lucrariTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;
                if (lblOp.Text == "ADAUGARE")
                {
                    cmd.CommandText = "Select IdLucrare From Lucrari where DLucrare='" + txtDLucrare.Text + "'";
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Lucrare deja existentă!");
                        txtDLucrare.Focus();
                    }
                    con.Close();
                }
                else if (lblOp.Text == "ACTUALIZARE")
                {
                    cmd.CommandText = "Select IdLucrare From Lucrari where DLucrare='" + txtDLucrare.Text +
                    "' and IdLucrare<> " + txtIdLucrare.Text;
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Lucrare deja existentă!");
                        txtDLucrare.Focus();
                    }
                    con.Close();
                }
            }
        }

        private void A7()
        {
            //Configurare butoane
            configureazaButoane(false);
            //Dezlegare controale Panel
            legareControale(false);
            //Ridicare protectie controale Panel
            protectiePanel(false);
            //Modifcare lblOp
            lblOp.Text = "ACTUALIZARE";
            //Pozitionare cursor pe primul camp
            txtDLucrare.Focus();
        }
        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            con.ConnectionString = lucrariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Select IdBonConsum From BonuriConsum where IdLucrare=" + txtIdLucrare.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Lucrare referită in tabela BonuriConusum! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();
            con.ConnectionString = lucrariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Delete From Lucrari Where IdLucrare = " + txtIdLucrare.Text;
            //MessageBox.Show("Inregistrare stearsa cu succes!");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refresh_grid(lucrariBindingSource.Position);
        }

        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnSalvare.Visible = !v;
            btnAdaugare.Enabled = v;
            btnActualizare.Enabled = v;
            btnStergere.Enabled = v;
        }
        private void legareControale(bool v)
        {
            if (v)
            {
                txtDLucrare.DataBindings.Add("Text", lucrariBindingSource, "DLucrare");
                txtIdLucrare.DataBindings.Add("Text", lucrariBindingSource, "IdLucrare");
            }
            else
            {
                txtDLucrare.DataBindings.Clear();
                txtIdLucrare.DataBindings.Clear();
            }
        }
        private void protectiePanel(bool v)
        {
            txtDLucrare.ReadOnly = v;
        }
        private void golireCampuri()
        {
            txtDLucrare.Text = "";
            txtIdLucrare.Text = "";
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, NrTelefon
            if (txtDLucrare.Text == "")
            {
                MessageBox.Show("Completati denumirea lucrării!");
                txtDLucrare.Focus();
                return false;
            }
            return true;
        }

        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = lucrariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "DLucrare";
            listaValori = "'" + txtDLucrare.Text + "'";
            cmd.CommandText = "Insert into Lucrari(" + listaCampuri + ") " +
            "Select " + listaValori;
            //MessageBox.Show("Inregistrare adaugata cu succes!");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void refresh_grid(int p)
        {
            lucrariTableAdapter.Fill(dataSet1.Lucrari);
            lucrariBindingSource.Position = p;
        }

        private void modifica_inregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = lucrariTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaSet = "DLucrare = '" + txtDLucrare.Text + "'";
            cmd.CommandText = "Update Lucrari Set " + listaSet + " Where IdLucrare=" +
            txtIdLucrare.Text;
            //MessageBox.Show("Actualizare efectuata cu succes!");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            A8();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }

        private void txtDLucrare_Leave(object sender, EventArgs e)
        {
            A5(txtDLucrare);
        }

        private void btnRaportLucrari_Click(object sender, EventArgs e)
        {
            LucrariReportForm f = new LucrariReportForm();
            f.ShowDialog();
        }
    }
}
