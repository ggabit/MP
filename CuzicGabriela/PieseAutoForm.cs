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
    public partial class PieseAutoForm : Form
    {
        public PieseAutoForm()
        {
            InitializeComponent();
        }

        private void PieseAutoForm_Load(object sender, EventArgs e)
        {
            A1();
        }

        private void A1()
        {
            //Umple cu date obiectele DataTable: PieseAuto (din DataSet):
            pieseAutoTableAdapter.Fill(dataSet1.PieseAuto);
            //Protectie grid
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            //Protectie txtIdPiesaAuto
            txtIdPiesaAuto.ReadOnly = true;
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
            txtDPiesaAuto.Focus();
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
                txtDPiesaAuto.Focus();
                refresh_grid(pieseAutoBindingSource.Position);
            }
            else if (lblOp.Text == "ACTUALIZARE")
            {
                if (!validareCampuriObligatorii()) return;
                modifica_inregistrare();
                refresh_grid(pieseAutoBindingSource.Position);
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

            if(txtB == txtPret)
            {
                // Validare numericitate
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
            }
            else if (txtB == txtDPiesaAuto)
            {
                con.ConnectionString = pieseAutoTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;
                if (lblOp.Text == "ADAUGARE")
                {
                    cmd.CommandText = "Select IdPiesaAuto From PieseAuto where DPiesa='" + txtDPiesaAuto.Text + "'";
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Piesa auto deja existentă!");
                        txtDPiesaAuto.Focus();
                    }
                    con.Close();
                }
                else if (lblOp.Text == "ACTUALIZARE")
                {
                    cmd.CommandText = "Select IdPiesaAuto From PieseAuto where DPiesa='" + txtDPiesaAuto.Text +
                    "' and IdPiesaAuto<> " + txtIdPiesaAuto.Text;
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Piesa auto deja existentă!");
                        txtDPiesaAuto.Focus();
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
            txtDPiesaAuto.Focus();
        }
        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            con.ConnectionString = pieseAutoTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Select IdBonConsum,NrCrt From BonuriConsumContinut where IdPiesaAuto=" + txtIdPiesaAuto.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Piesa auto referită in tabela BonuriConusumContinut! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();
            con.ConnectionString = pieseAutoTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Select IdFactura,NrCrt From FacturiContinut where IdPiesaAuto=" + txtIdPiesaAuto.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Piesa auto referită in tabela FacturiContinut! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();
            con.ConnectionString = pieseAutoTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Delete From PieseAuto Where IdPiesaAuto = " + txtIdPiesaAuto.Text;
            //MessageBox.Show("Inregistrare stearsa cu succes!");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refresh_grid(pieseAutoBindingSource.Position);
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
                txtDPiesaAuto.DataBindings.Add("Text", pieseAutoBindingSource, "DPiesa");
                cmbUM.DataBindings.Add("Text", pieseAutoBindingSource, "UM");
                txtPret.DataBindings.Add("Text", pieseAutoBindingSource, "Pret");
                txtIdPiesaAuto.DataBindings.Add("Text", pieseAutoBindingSource, "IdPiesaAuto");
            }
            else
            {
                txtDPiesaAuto.DataBindings.Clear();
                cmbUM.DataBindings.Clear();
                txtPret.DataBindings.Clear();
                txtIdPiesaAuto.DataBindings.Clear();
            }
        }
        private void protectiePanel(bool v)
        {
            txtDPiesaAuto.ReadOnly = v;
            txtPret.ReadOnly = v;
            cmbUM.Enabled = !v;
        }
        private void golireCampuri()
        {
            txtDPiesaAuto.Text = "";
            cmbUM.SelectedIndex = -1;
            txtPret.Text = "";
            txtIdPiesaAuto.Text = "";
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Denumire, UM, Pret
            if (txtDPiesaAuto.Text == "")
            {
                MessageBox.Show("Completati denumirea piesei auto!");
                txtDPiesaAuto.Focus();
                return false;
            }
            if (txtPret.Text == "")
            {
                MessageBox.Show("Completati pretul piesei auto!");
                txtPret.Focus();
                return false;
            }
            if (cmbUM.Text == "")
            {
                MessageBox.Show("Completati unitatea de masura!");
                cmbUM.Focus();
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
            con.ConnectionString = pieseAutoTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "DPiesa, Pret, UM";
            listaValori = "'" + txtDPiesaAuto.Text + "'" +
            ",'" + txtPret.Text + "'" +
            ",'" + cmbUM.Text + "'";
            cmd.CommandText = "Insert into PieseAuto(" + listaCampuri + ") " +
            "Select " + listaValori;
            //MessageBox.Show("Inregistrare adaugata cu succes!");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void refresh_grid(int p)
        {
            pieseAutoTableAdapter.Fill(dataSet1.PieseAuto);
            pieseAutoBindingSource.Position = p;
        }

        private void modifica_inregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = pieseAutoTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaSet = "DPiesa = '" + txtDPiesaAuto.Text + "'," +
            "Pret = '" + txtPret.Text + "'," +
            "UM = '" + cmbUM.Text + "'";
            cmd.CommandText = "Update PieseAuto Set " + listaSet + " Where IdPiesaAuto=" +
            txtIdPiesaAuto.Text;
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

        private void txtPret_Leave(object sender, EventArgs e)
        {
            A5(txtPret);
        }

        private void txtDPiesaAuto_Leave(object sender, EventArgs e)
        {
            A5(txtDPiesaAuto);
        }

        private void btnRaportPieseAuto_Click(object sender, EventArgs e)
        {
            PieseAutoReportForm f = new PieseAutoReportForm();
            f.ShowDialog();
        }
    }
}
