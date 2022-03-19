using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CuzicGabriela
{
    public partial class ClientiForm : Form
    {
        public ClientiForm()
        {
            InitializeComponent();
        }

        private void ClientiForm_Load(object sender, EventArgs e)
        {
            A1();
        }

        private void A1()
        {
            //Umple cu date obiectele DataTable: Clienti (din DataSet):
            clientiTableAdapter.Fill(dataSet1.Clienti);
            //Protectie grid
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            //Protectie txtIdClient
            txtIdClient.ReadOnly = true;
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
            txtDClient.Focus();
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
                txtDClient.Focus();
                refresh_grid(clientiBindingSource.Position);
            }
            else if (lblOp.Text == "ACTUALIZARE")
            {
                if (!validareCampuriObligatorii()) return;
                modifica_inregistrare();
                refresh_grid(clientiBindingSource.Position);
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
                con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;
                if (lblOp.Text == "ADAUGARE")
                {
                    cmd.CommandText = "Select DClient From Clienti where NrTelefon='" + txtNrTelefon.Text + "'";
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
                    cmd.CommandText = "Select DClient From Clienti where NrTelefon='" + txtNrTelefon.Text +
                    "' and IdClient <> " + txtIdClient.Text;
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
            txtDClient.Focus();
        }
        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Select IdBonConsum From BonuriConsum where IdClient=" + txtIdClient.Text;
            con.Open();
            r = cmd.ExecuteReader();
            if (r.Read())
            {
                MessageBox.Show("Client referit in tabela BonuriConsum! Nu se poate sterge!");
                con.Close();
                return;
            }
            con.Close();
            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "Delete From Clienti Where IdClient = " + txtIdClient.Text;
            //MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            refresh_grid(clientiBindingSource.Position);
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
                txtDClient.DataBindings.Add("Text", clientiBindingSource, "DClient");
                txtNrTelefon.DataBindings.Add("Text", clientiBindingSource, "NrTelefon");
                txtIdClient.DataBindings.Add("Text", clientiBindingSource, "IdClient");
            }
            else
            {
                txtDClient.DataBindings.Clear();
                txtNrTelefon.DataBindings.Clear();
                txtIdClient.DataBindings.Clear();
            }
        }
        private void protectiePanel(bool v)
        {
            txtDClient.ReadOnly = v;
            txtNrTelefon.ReadOnly = v;
        }
        private void golireCampuri()
        {
            txtDClient.Text = "";
            txtNrTelefon.Text = "";
            txtIdClient.Text = "";
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, NrTelefon
            if (txtDClient.Text == "")
            {
                MessageBox.Show("Completati Numele clientului !");
                txtDClient.Focus();
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
            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaCampuri = "DClient, NrTelefon";
            listaValori = "'" + txtDClient.Text + "'" +
            ",'" + txtNrTelefon.Text + "'";
            cmd.CommandText = "Insert into Clienti(" + listaCampuri + ") " +
            "Select " + listaValori;
            //MessageBox.Show("Client adaugat cu succes!");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void refresh_grid(int p)
        {
            clientiTableAdapter.Fill(dataSet1.Clienti);
            clientiBindingSource.Position = p;
        }

        private void modifica_inregistrare()
        {
            string listaSet;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            listaSet = "DClient = '" + txtDClient.Text + "'," +
            "NrTelefon = '" + txtNrTelefon.Text +  "'";
            cmd.CommandText = "Update Clienti Set " + listaSet + " Where IdClient=" +
            txtIdClient.Text;
            // MessageBox.Show("Actualizare realizata cu succes!");
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
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

        private void txtNrTelefon_Leave(object sender, EventArgs e)
        {
            A5(txtNrTelefon);
        }

        private void btnRaportClienti_Click(object sender, EventArgs e)
        {
            ClientiReportForm f = new ClientiReportForm();
            f.ShowDialog();
        }
    }
}
