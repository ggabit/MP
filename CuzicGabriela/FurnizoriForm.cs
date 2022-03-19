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
    public partial class FurnizoriForm : Form
    {
        public FurnizoriForm()
        {
            InitializeComponent();
        }

        private void FurnizoriForm_Load(object sender, EventArgs e)
        {
            A1();
        }

        private void A1()
        {
            //Umple cu date obiectele DataTable: Furnizori (din DataSet):
            furnizoriTableAdapter.Fill(dataSet1.Furnizori);
            //Protectie grid
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            //Protectie txtIdFurnizor
            txtIdFurnizor.ReadOnly = true;
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
            txtDFurnizor.Focus();
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
                txtDFurnizor.Focus();
                refresh_grid(furnizoriBindingSource.Position);
            }
            else if (lblOp.Text == "ACTUALIZARE")
            {
                if (!validareCampuriObligatorii()) return;
                modifica_inregistrare();
                refresh_grid(furnizoriBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;

            if (txtB == txtNrTelefon)
            {
                // Validare numericitate
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
                con.ConnectionString = furnizoriTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;
                if (lblOp.Text == "ADAUGARE")
                {
                    cmd.CommandText = "Select DFurnizor From Furnizori where NrTelefon='" + txtNrTelefon.Text + "'";
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Număr de telefon deja existent");
                        txtNrTelefon.Focus();
                    }
                    con.Close();
                }
                else if (lblOp.Text == "ACTUALIZARE")
                {
                    cmd.CommandText = "Select DFurnizor From Furnizori where NrTelefon='" + txtNrTelefon.Text +
                    "' and IdFurnizor <> " + txtIdFurnizor.Text;
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Număr de telefon deja existent");
                        txtNrTelefon.Focus();
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
            txtDFurnizor.Focus();
        }
        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            con.ConnectionString = furnizoriTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Select IdFactura From Facturi where IdFurnizor=" + txtIdFurnizor.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Furnizor referit in tabela Facturi! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();
            con.ConnectionString = furnizoriTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Delete From Furnizori Where IdFurnizor = " + txtIdFurnizor.Text;
            //MessageBox.Show("Inregistrare stearsa cu succes!");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refresh_grid(furnizoriBindingSource.Position);
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
                txtDFurnizor.DataBindings.Add("Text", furnizoriBindingSource, "DFurnizor");
                txtNrTelefon.DataBindings.Add("Text", furnizoriBindingSource, "NrTelefon");
                txtIdFurnizor.DataBindings.Add("Text", furnizoriBindingSource, "IdFurnizor");
            }
            else
            {
                txtDFurnizor.DataBindings.Clear();
                txtNrTelefon.DataBindings.Clear();
                txtIdFurnizor.DataBindings.Clear();
            }
        }
        private void protectiePanel(bool v)
        {
            txtDFurnizor.ReadOnly = v;
            txtNrTelefon.ReadOnly = v;
        }
        private void golireCampuri()
        {
            txtDFurnizor.Text = "";
            txtNrTelefon.Text = "";
            txtIdFurnizor.Text = "";
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, NrTelefon
            if (txtDFurnizor.Text == "")
            {
                MessageBox.Show("Completati Numele furnizorului !");
                txtDFurnizor.Focus();
                return false;
            }
            if (txtNrTelefon.Text == "")
            {
                MessageBox.Show("Completati numărul de telefon !");
                txtNrTelefon.Focus();
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
            con.ConnectionString = furnizoriTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "DFurnizor, NrTelefon";
            listaValori = "'" + txtDFurnizor.Text + "'" +
            ",'" + txtNrTelefon.Text + "'";
            cmd.CommandText = "Insert into Furnizori(" + listaCampuri + ") " +
            "Select " + listaValori;
            //MessageBox.Show("Adaugare efectuata cu succes!");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void refresh_grid(int p)
        {
            furnizoriTableAdapter.Fill(dataSet1.Furnizori);
            furnizoriBindingSource.Position = p;
        }

        private void modifica_inregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = furnizoriTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaSet = "DFurnizor = '" + txtDFurnizor.Text + "'," +
            "NrTelefon = '" + txtNrTelefon.Text + "'";
            cmd.CommandText = "Update Furnizori Set " + listaSet + " Where IdFurnizor=" +
            txtIdFurnizor.Text;
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

        private void txtNrTelefon_Leave(object sender, EventArgs e)
        {
            A5(txtNrTelefon);
        }

        private void btnRaportFurnizori_Click(object sender, EventArgs e)
        {
            FurnizoriReportForm f = new FurnizoriReportForm();
            f.ShowDialog();
        }
    }
}
