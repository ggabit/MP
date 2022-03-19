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
    public partial class FacturiVizForm : Form
    {
        public FacturiVizForm()
        {
            InitializeComponent();
        }

        private void refreshGrid()
        {
            facturiTableAdapter.Fill(dataSet1.Facturi);
            facturiContinutTableAdapter.Fill(dataSet1.FacturiContinut);
        }

        public void position_grid(int p)
        {
            facturiBindingSource.Position = p;
        }

        private void FacturiVizForm_Load(object sender, EventArgs e)
        {
            refreshGrid();
            try
            {
                facturiContinutBindingSource.Filter = "IdFactura=" + txtIdFactura.Text;
            }
            catch { }
        }

        private void facturiBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                facturiContinutBindingSource.Filter = "IdFactura=" + txtIdFactura.Text;
            }
            catch { }
        }

        private void btnFacturaNoua_Click(object sender, EventArgs e)
        {
            FacturiActForm f = new FacturiActForm();
            f.ShowDialog();
            refreshGrid();
        }

        private void btnStergeFactura_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            int p = facturiBindingSource.Position;
            con.ConnectionString = facturiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            // Sterg continut factura
            cmd.CommandText = "Delete From FacturiContinut Where IdFactura = " + txtIdFactura.Text;
            //MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            // Sterg factura
            cmd.CommandText = "Delete From Facturi Where IdFactura = " + txtIdFactura.Text;
            //MessageBox.Show("Stergere efectuata cu succes!");
            cmd.ExecuteNonQuery();
            con.Close();
            // Refresh grid-uri
            refreshGrid();
            position_grid(p + 1);
            try
            {
                facturiContinutBindingSource.Filter = "IdFactura=" + txtIdFactura.Text;
            }
            catch { }
        }

        private void btnModificaFactura_Click(object sender, EventArgs e)
        {
            int p = facturiBindingSource.Position;
            FacturiActForm f = new FacturiActForm(); 
            f.completeazaTitlu("MODIFICARE FACTURA"); 
            f.bs1 = facturiBindingSource; 
            f.bs2 = facturiContinutBindingSource; 
            f.ShowDialog(); 
            refreshGrid();
            position_grid(p);
            try
            {
                facturiContinutBindingSource.Filter = "IdFactura=" + txtIdFactura.Text;
            }
            catch { }
        }

        private void btnRaportAprovizionare_Click(object sender, EventArgs e)
        {
            AprovizionareReportForm f = new AprovizionareReportForm();
            f.ShowDialog();
        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            StatisticiAprovizionareForm f = new StatisticiAprovizionareForm();
            f.ShowDialog();
        }
    }
}
