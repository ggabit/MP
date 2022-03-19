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
    public partial class BonConsumActForm : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idB;
        public BindingSource bs1;
        public BindingSource bs2;
        public BonConsumActForm()
        {
            InitializeComponent();
        }

        private void BonConsumActForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.PieseAuto' table. You can move, or remove it, as needed.
            this.pieseAutoTableAdapter.Fill(this.dataSet1.PieseAuto);
            A1();
        }

        private void A1()
        {
            //Incarcare DataTable PieseAuto
            pieseAutoTableAdapter.Fill(dataSet1.PieseAuto);
            //Incarcare DataTable Furnizori
            clientiTableAdapter.Fill(dataSet1.Clienti);
            lucrariTableAdapter.Fill(dataSet1.Lucrari);
            // Protectie la modificare
            txtNrBonConsum.ReadOnly = true;
            txtTotal.ReadOnly = true;
            nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
            uMDataGridViewTextBoxColumn.ReadOnly = true;
            pretVanzareDataGridViewTextBoxColumn.ReadOnly = true;
            //idPiesaAutoDataGridViewTextBoxColumn.ReadOnly = true;

            // Initializare cmbClient si cmbLucrare
            if (lblOp.Text == "Modificare Bon consum") completeazaBonConsum();
            else if (lblOp.Text == "Bon consum nou")
            {
                cmbClient.SelectedIndex = -1;
                cmbLucrare.SelectedIndex = -1;
            }
        }

        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (!verificaStoc()) return;
            if (lblOp.Text == "Modificare Bon consum")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariBonuriConsumContinut();
                this.Close();
            }
            else if (lblOp.Text == "Bon consum nou")
            {
                generez_nrB();
                adaugaInregistrareBonuriConsum();
                cautaInregistrare();
                adaugaInregistrariBonuriConsumContinut();
                golireCampuri();
            }
        }

        private void A3()
        {
            // Generare NrCrt
            DataRowView current = (DataRowView)bonConsumContinutManevraBindingSource.Current;
            try { current["NrCrt"] = bonConsumContinutManevraBindingSource.Position + 1; }
            catch { }
        }

        private void A4()
        {
            try
            {
                if (dataGridView1.CurrentCell.ColumnIndex == 1)
                {
                    DataRowView current = (DataRowView)pieseAutoBindingSource.Current;
                    dataGridView1.CurrentRow.Cells[4].Value = current["UM"];
                    dataGridView1.CurrentRow.Cells[3].Value = current["Pret"];
                    dataGridView1.CurrentRow.Cells[6].Value = current["IdPiesaAuto"];
                    calcTotal();
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 3)
                {
                    bonConsumContinutManevraBindingSource.EndEdit();
                    calcTotal();
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 4)
                {
                    bonConsumContinutManevraBindingSource.EndEdit();
                    calcTotal();
                    
                }
                bonConsumContinutManevraBindingSource.EndEdit();
                calcTotal();
            }
            catch { }
        }

        private void A5(DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }

        private void completeazaBonConsum()
        {
            DataRowView current = (DataRowView)bs1.Current;
            idB = (int)current["IdBonConsum"];
            txtNrBonConsum.Text = Convert.ToString(current["NrBonConsum"]);
            cmbClient.Text = current["DClient"].ToString();
            cmbLucrare.Text = current["DLucrare"].ToString();
            txtTotal.Text = current["Total"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(current["DataBonConsum"]);
            bs2.MoveFirst();
            dataSet1.BonConsumContinutManevra.Clear();
            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;
                DataSet1.BonConsumContinutManevraRow r = dataSet1.BonConsumContinutManevra.NewBonConsumContinutManevraRow();
                r.NrCrt = Convert.ToInt16(current["NrCrt"]);
                r.DPiesa = Convert.ToString(current["DPiesa"]);
                r.UM = Convert.ToString(current["UM"]);
                r.PretVanzare = Convert.ToDecimal(current["PretVanzare"]);
                r.Cantitate = Convert.ToDecimal(current["Cantitate"]);
                r.IdPiesaAuto = Convert.ToInt32(current["IdPiesaAuto"]);
                r.Valoare = Convert.ToDecimal(current["Valoare"]);
                dataSet1.BonConsumContinutManevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }

        private void calcTotal()
        { // Calcul total valori
            decimal t = 0;
            foreach (DataRow r in dataSet1.BonConsumContinutManevra)
            {
                if (r["Valoare"] != DBNull.Value)
                    t += (decimal)r["Valoare"];
            }
            txtTotal.Text = Convert.ToString(t);
        }

        private Boolean verificaStoc()
        {
            foreach (DataRow r in dataSet1.BonConsumContinutManevra)
            {
                con.ConnectionString = pieseAutoTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;
                cmd.CommandText = "SELECT StocFinal FROM BalantaStoc bs LEFT OUTER JOIN PieseAuto pa ON bs.IdPiesaAuto=pa.IdPiesaAuto WHERE pa.DPiesa=\"" + r["DPiesa"]+"\"";
                con.Open();
                rdr = cmd.ExecuteReader();
                rdr.Read();
                int stoc = rdr.GetInt32(0);
                //MessageBox.Show("Cantitate in stoc: "+stoc);
                rdr.Close();
                con.Close();
                if (r["Cantitate"] != DBNull.Value)
                {
                    if (Convert.ToInt32(r["Cantitate"]) > stoc)
                    {
                        MessageBox.Show("Cantitate insuficienta in stoc pentru " + r["DPiesa"]+ ". Cantitate in stoc: " + stoc);
                        dataGridView1.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private void generez_nrB()
        {
            con.ConnectionString = pieseAutoTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Max(BonuriConsum.NrBonConsum) AS NrMax FROM BonuriConsum";
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            txtNrBonConsum.Text = Convert.ToString(rdr.GetInt32(0) + 1);
            rdr.Close();
            con.Close();
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campul Client
            if (cmbClient.Text == "")
            {
                MessageBox.Show("Completati Client !");
                cmbClient.Focus();
                return false;
            }
            //Validare de completare obligatorie campul Lucrare
            if (cmbLucrare.Text == "")
            {
                MessageBox.Show("Completati Lucrarea !");
                cmbLucrare.Focus();
                return false;
            }
            // Validare completare continut
            if (bonConsumContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut bon consum !");
                dataGridView1.Focus();
                return false;
            }
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString() == "")
            {
                MessageBox.Show("Completati cantitatea !");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }

        private void adaugaInregistrareBonuriConsum()
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;
            listaCampuri = "NrBonConsum, DataBonConsum, IdClient, IdLucrare";
            listaValori = txtNrBonConsum.Text +
            ",#" + Convert.ToString(d.Month) + "/"
            + Convert.ToString(d.Day) + "/"
            + Convert.ToString(d.Year) + "#,"
            + cmbClient.SelectedValue + "," + cmbLucrare.SelectedValue;
            cmd.CommandText = "Insert into BonuriConsum(" + listaCampuri + ") " +
            "Select " + listaValori;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void cautaInregistrare()
        {
            cmd.CommandText = "SELECT idBonConsum From BonuriConsum Where NrBonConsum = " +
            txtNrBonConsum.Text;
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            idB = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }

        private void adaugaInregistrariBonuriConsumContinut()
        {
            string listaCampuri = "IdBonConsum, NrCrt, IdPiesaAuto, Cantitate, PretVanzare";
            string listaValori;
            con.Open();
            foreach (DataRow r in dataSet1.BonConsumContinutManevra)
            {
                //con.ConnectionString = pieseAutoTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;
                cmd.CommandText = "SELECT IdPiesaAuto FROM PieseAuto WHERE DPiesa=\"" + r["DPiesa"] +"\"";
                //con.Open();
                rdr = cmd.ExecuteReader();
                rdr.Read();
                String IdPiesaAuto =Convert.ToString(rdr.GetInt32(0));
                rdr.Close();
                //con.Close();

                listaValori = idB + "," + r["NrCrt"] + "," + IdPiesaAuto + "," +
                r["Cantitate"] + "," + r["PretVanzare"];
                cmd.CommandText = "Insert into BonuriConsumContinut(" + listaCampuri + ") " +
                "Select " + listaValori;
                //MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        private void golireCampuri()
        {
            txtNrBonConsum.Text = "";
            cmbClient.SelectedIndex = -1;
            cmbLucrare.SelectedIndex = -1;
            txtTotal.Text = "";
            dataSet1.BonConsumContinutManevra.Clear();
        }

        private void stergeContinut()
        {
            cmd.CommandText = "Delete from BonuriConsumContinut Where IdBonConsum = " + idB;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void modificaInregistrare()
        {
            DateTime d1 = dateTimePicker1.Value;
            con.ConnectionString = pieseAutoTableAdapter.Connection.ConnectionString; cmd.Connection = con;
            string clauzaWhere = " Where IdBonConsum = " + idB;
            string clauzaSet = "Set DataBonConsum = #" + d1.Month + "/" + d1.Day + "/" + d1.Year + "#," + "IdClient = " + cmbClient.SelectedValue + "," + "IdLucrare = " + cmbLucrare.SelectedValue;
            cmd.CommandText = "Update BonuriConsum " + clauzaSet + clauzaWhere;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void bonConsumContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
            calcTotal();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }
    }
}
