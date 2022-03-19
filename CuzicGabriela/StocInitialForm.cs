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
    public partial class StocInitialForm : Form
    {
        public StocInitialForm()
        {
            InitializeComponent();
        }

        private void StocInitialForm_Load(object sender, EventArgs e)
        {
            A1();
        }

        private void A1()
        {
            //Umple cu date obiectele DataTable: StocInitial si PieseAuto (din DataSet):
            pieseAutoTableAdapter.Fill(dataSet1.PieseAuto);
            stocInitialTableAdapter.Fill(dataSet1.StocInitial);
            //Protectie grid
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            //Protectie txtPret
            txtPret.ReadOnly = true;
            txtUM.ReadOnly = true;
            txtId.ReadOnly = true;
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
            dateTimePicker1.Focus();
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
                dateTimePicker1.Focus();
                refresh_grid(stocInitialBindingSource.Position);
                A2();
            }
            else if (lblOp.Text == "ACTUALIZARE")
            {
                if (!validareCampuriObligatorii()) return;
                modifica_inregistrare();
                refresh_grid(stocInitialBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }

        private void A5(ComboBox cmbB)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            if (lblOp.Text == "") return;
            if (cmbB.Text == "") return;
            if (btnRenuntare.Focused) return;

            if (cmbB == cmbPiesaAuto)
            {
                DateTime d = dateTimePicker1.Value;
                con.ConnectionString = stocInitialTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;
                if (lblOp.Text == "ADAUGARE")
                {
                    //cmd.CommandText = "Select IdStocInitial From StocInitial where IdPiesaAuto=" + cmbPiesaAuto.SelectedValue + " and Data= #" + d.Month + "/" + d.Day + "/" + d.Year + "#";
                    cmd.CommandText = "Select IdStocInitial From StocInitial where IdPiesaAuto=" + cmbPiesaAuto.SelectedValue;
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Situatie existantă deja pentru piesa auto selectată!");
                        cmbPiesaAuto.Focus();
                    }
                    con.Close();
                }
                else if (lblOp.Text == "ACTUALIZARE")
                {
                    //cmd.CommandText = "Select IdStocInitial From StocInitial where IdPiesaAuto=" + cmbPiesaAuto.SelectedValue + " and Data= #" + d.Month + "/" + d.Day + "/" + d.Year + "# and IdStocInitial<>"+txtId.Text;
                    cmd.CommandText = "Select IdStocInitial From StocInitial where IdPiesaAuto=" + cmbPiesaAuto.SelectedValue + " and IdStocInitial<>" + txtId.Text;
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Situatie existantă deja pentru piesa auto selectată!");
                        cmbPiesaAuto.Focus();
                    }
                    con.Close();
                }
            }
        }

        private void A5(TextBox txtB)
        {
            decimal p;
            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;

            if (txtB == txtCantitate)
            {
                // Validare numericitate
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
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
            dateTimePicker1.Focus();
        }
        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = pieseAutoTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Delete From StocInitial Where IdStocInitial = " + txtId.Text;
            //MessageBox.Show("Inregistrare stearsa cu succes!");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refresh_grid(stocInitialBindingSource.Position);
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
                dateTimePicker1.DataBindings.Add("Text", stocInitialBindingSource, "Data");
                cmbPiesaAuto.DataBindings.Add("Text", stocInitialBindingSource, "DPiesa");
                //txtPret.DataBindings.Add("Text", pieseAutoBindingSource, "Pret");
                txtId.DataBindings.Add("Text", stocInitialBindingSource, "IdStocInitial");
                txtCantitate.DataBindings.Add("Text", stocInitialBindingSource, "Cantitate1");
            }
            else
            {
                dateTimePicker1.DataBindings.Clear();
                cmbPiesaAuto.DataBindings.Clear();
                //txtPret.DataBindings.Clear();
                txtId.DataBindings.Clear();
                txtCantitate.DataBindings.Clear();
            }
        }
        private void protectiePanel(bool v)
        {
            dateTimePicker1.Enabled = !v;
            txtCantitate.ReadOnly = v;
            cmbPiesaAuto.Enabled = !v;
        }
        private void golireCampuri()
        {
            dateTimePicker1.Text = "";
            cmbPiesaAuto.SelectedIndex = -1;
            cmbPiesaAuto.Text = "";
            txtPret.Text = "";
            txtUM.Text = "";
            txtId.Text = "";
            txtCantitate.Text = "";
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Cantitate, PiesaAuto
            if (cmbPiesaAuto.Text == "")
            {
                MessageBox.Show("Alegeti piesa auto!");
                cmbPiesaAuto.Focus();
                return false;
            }
            if (txtCantitate.Text == "")
            {
                MessageBox.Show("Completati cantitatea!");
                txtCantitate.Focus();
                return false;
            }
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("Alegeti data!");
                dateTimePicker1.Focus();
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
            con.ConnectionString = stocInitialTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            DateTime d = dateTimePicker1.Value;
            listaCampuri = "Data, IdPiesaAuto, Cantitate, Pret ";
            listaValori = "#" + Convert.ToString(d.Month) + "/"
            + Convert.ToString(d.Day) + "/"
            + Convert.ToString(d.Year) + "#"
            + "," + cmbPiesaAuto.SelectedValue +
            ",'" + txtCantitate.Text + "'" 
            +",'"+ txtPret.Text+"'";
            cmd.CommandText = "Insert into StocInitial(" + listaCampuri + ") " +
            "Select " + listaValori;
            //MessageBox.Show("Inregistrare adaugata cu succes!");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            golireCampuri();
            legareControale(false);
        }
        private void refresh_grid(int p)
        {
            pieseAutoTableAdapter.Fill(dataSet1.PieseAuto);
            stocInitialTableAdapter.Fill(dataSet1.StocInitial);
            stocInitialBindingSource.Position = p;
        }

        private void modifica_inregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            DateTime d = dateTimePicker1.Value;
            con.ConnectionString = stocInitialTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaSet = "Data = #" + d.Month + "/" + d.Day + "/" + d.Year + "#," +
            "IdPiesaAuto = " + cmbPiesaAuto.SelectedValue + "," +
            "Cantitate = '" + txtCantitate.Text + "'," + 
            "Pret = '" + txtPret.Text + "'";
            cmd.CommandText = "Update StocInitial Set " + listaSet + " Where IdStocInitial=" +
            txtId.Text;
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

        private void txtCantitate_Leave(object sender, EventArgs e)
        {
            A5(txtCantitate);
        }

        private void cmbPiesaAuto_Leave(object sender, EventArgs e)
        {
            A5(cmbPiesaAuto);
        }

        private void btnRaportStocInitial_Click(object sender, EventArgs e)
        {
            StocInitialReportForm f = new StocInitialReportForm();
            f.ShowDialog();
        }
    }
}
