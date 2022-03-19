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
    public partial class FacturiActForm : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idF;
        public BindingSource bs1;
        public BindingSource bs2;
        public FacturiActForm()
        {
            InitializeComponent();
        }

        private void FacturiActForm_Load(object sender, EventArgs e)
        {
            A1();
        }

        private void A1()
        {
            //Incarcare DataTable PieseAuto
            pieseAutoTableAdapter.Fill(dataSet1.PieseAuto);
            //Incarcare DataTable Furnizori
            furnizoriTableAdapter.Fill(dataSet1.Furnizori);
            // Protectie la modificare
            txtNrFactura.ReadOnly = true;
            txtTotal.ReadOnly = true;
            nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
            uMDataGridViewTextBoxColumn.ReadOnly = true;
            //pretAchizitieDataGridViewTextBoxColumn.ReadOnly = true;
            //idPiesaAutoDataGridViewTextBoxColumn.ReadOnly = true;

            // Initializare cmbFurnizor
            if (lblOp.Text == "MODIFICARE FACTURA") completeazaFactura(); 
            else if (lblOp.Text == "FACTURA NOUA") cmbFurnizor.SelectedIndex = -1;
        }

        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE FACTURA")
            {
                modificaInregistrare(); 
                stergeContinut(); 
                adaugaInregistrariFacturiContinut(); 
                this.Close();
            }
            else if (lblOp.Text == "FACTURA NOUA") 
            { generez_nrF(); 
                adaugaInregistrareFacturi(); 
                cautaInregistrare();
                adaugaInregistrariFacturiContinut();
                golireCampuri(); 
            }
        }

        private void A3()
        {
            // Generare NrCrt
            DataRowView current = (DataRowView)facturaContinutManevraBindingSource.Current;
            try { current["NrCrt"] = facturaContinutManevraBindingSource.Position + 1; }
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
                    //dataGridView1.CurrentRow.Cells[3].Value = current["Pret"];
                    //dataGridView1.CurrentRow.Cells[6].Value = current["IdPiesaAuto"];
                    calcTotal();
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 3)
                {
                    facturaContinutManevraBindingSource.EndEdit();
                    calcTotal();
                }
                if (dataGridView1.CurrentCell.ColumnIndex == 2)
                {
                    facturaContinutManevraBindingSource.EndEdit();
                    calcTotal();
                }
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

        private void completeazaFactura()
        {
            DataRowView current = (DataRowView)bs1.Current;
            idF = (int)current["IdFactura"]; 
            txtNrFactura.Text = Convert.ToString(current["NrFactura"]);
            cmbFurnizor.Text = current["DFurnizor"].ToString();
            txtTotal.Text = current["Total"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(current["DataFactura"]);
            bs2.MoveFirst();
            dataSet1.FacturaContinutManevra.Clear();
            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;
                DataSet1.FacturaContinutManevraRow r = dataSet1.FacturaContinutManevra.NewFacturaContinutManevraRow(); 
                r.NrCrt = Convert.ToInt16(current["NrCrt"]); 
                r.DPiesa = Convert.ToString(current["DPiesa"]); 
                r.UM = Convert.ToString(current["UM"]); 
                r.PretAchizitie = Convert.ToDecimal(current["PretAchizitie"]); 
                r.Cantitate = Convert.ToDecimal(current["Cantitate"]); 
                r.IdPiesaAuto = Convert.ToInt32(current["IdPiesaAuto"]); 
                r.Valoare = Convert.ToDecimal(current["Valoare"]);
                dataSet1.FacturaContinutManevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }

        private void calcTotal()
        { // Calcul total valori
            decimal t = 0;
            foreach (DataRow r in dataSet1.FacturaContinutManevra)
            {
                if (r["Valoare"] != DBNull.Value)
                    t += (decimal)r["Valoare"];
            }
            txtTotal.Text = Convert.ToString(t);
        }

        private void generez_nrF()
        {
            con.ConnectionString = pieseAutoTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Max(Facturi.NrFactura) AS NrMax FROM Facturi";
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            txtNrFactura.Text = Convert.ToString(rdr.GetInt32(0) + 1);
            rdr.Close();
            con.Close();
        }

        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campul Furnizor
            if (cmbFurnizor.Text == "")
            {
                MessageBox.Show("Completati Furnizor !");
                cmbFurnizor.Focus();
                return false;
            }
            // Validare completare continut
            if (facturaContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut factura !");
                dataGridView1.Focus();
                return false;
            }
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "")
            {
                MessageBox.Show("Completati pretul de achizitie !");
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

        private void adaugaInregistrareFacturi()
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;
            listaCampuri = "NrFactura, DataFactura, IdFurnizor";
            listaValori = txtNrFactura.Text +
            ",#" + Convert.ToString(d.Month) + "/"
            + Convert.ToString(d.Day) + "/"
            + Convert.ToString(d.Year) + "#,"
            + cmbFurnizor.SelectedValue;
            cmd.CommandText = "Insert into Facturi(" + listaCampuri + ") " +
            "Select " + listaValori;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void cautaInregistrare()
        {
            cmd.CommandText = "SELECT idFactura From Facturi Where NrFactura = " +
            txtNrFactura.Text;
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            idF = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }

        private void adaugaInregistrariFacturiContinut()
        {
            string listaCampuri = "IdFactura, NrCrt, IdPiesaAuto, Cantitate, PretAchizitie";
            string listaValori;
            con.Open();
            foreach (DataRow r in dataSet1.FacturaContinutManevra)
            {
                //con.ConnectionString = pieseAutoTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;
                cmd.CommandText = "SELECT IdPiesaAuto FROM PieseAuto WHERE DPiesa=\"" + r["DPiesa"] + "\"";
                //con.Open();
                rdr = cmd.ExecuteReader();
                rdr.Read();
                String IdPiesaAuto = Convert.ToString(rdr.GetInt32(0));
                rdr.Close();
                //con.Close();

                listaValori = idF + "," + r["NrCrt"] + "," + IdPiesaAuto + "," +
                r["Cantitate"] + "," + r["PretAchizitie"];
                cmd.CommandText = "Insert into FacturiContinut(" + listaCampuri + ") " +
                "Select " + listaValori;
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        private void golireCampuri()
        {
            txtNrFactura.Text = "";
            cmbFurnizor.SelectedIndex = -1;
            txtTotal.Text = "";
            dataSet1.FacturaContinutManevra.Clear();
        }

        private void stergeContinut()
        {
            cmd.CommandText = "Delete from FacturiContinut Where IdFactura = " + idF;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void modificaInregistrare()
        {
            DateTime d = dateTimePicker1.Value;
            con.ConnectionString = pieseAutoTableAdapter.Connection.ConnectionString; cmd.Connection = con;
            string clauzaWhere = " Where IdFactura = " + idF;
            string clauzaSet = "Set DataFactura = #" + d.Month + "/" + d.Day + "/" + d.Year + "#," + "IdFurnizor = " + cmbFurnizor.SelectedValue;
            cmd.CommandText = "Update Facturi " + clauzaSet + clauzaWhere;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void facturaContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            A2();
        }
    }
}
