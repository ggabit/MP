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
    public partial class BonConsumVizForm : Form
    {
        public BonConsumVizForm()
        {
            InitializeComponent();
        }

        private void refreshGrid()
        {
            bonuriConsumTableAdapter.Fill(dataSet1.BonuriConsum);
            bonuriConsumContinutTableAdapter.Fill(dataSet1.BonuriConsumContinut);
        }

        public void position_grid(int p)
        {
            bonuriConsumBindingSource.Position = p;
        }

        private void BonConsumVizForm_Load(object sender, EventArgs e)
        {
            refreshGrid();
            try
            {
                bonuriConsumContinutBindingSource.Filter = "IdBonConsum=" + txtIdBonConsum.Text;
            }
            catch { }
        }

        private void bonuriConsumBindingSource_PositionChanged(object sender, EventArgs e)
        {
            try
            {
                bonuriConsumContinutBindingSource.Filter = "IdBonConsum=" + txtIdBonConsum.Text;
            }
            catch { }
        }

        private void btnBonNou_Click(object sender, EventArgs e)
        {
            BonConsumActForm f = new BonConsumActForm();
            f.ShowDialog();
            refreshGrid();
        }

        private void btnStergeBon_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            int p = bonuriConsumBindingSource.Position;
            con.ConnectionString = bonuriConsumTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            // Sterg continut BonConsum
            cmd.CommandText = "Delete From BonuriConsumContinut Where IdBonConsum = " + txtIdBonConsum.Text;
            //MessageBox.Show("Stergere realizata cu succes!");
            con.Open();
            cmd.ExecuteNonQuery();
            // Sterg BonConsum
            cmd.CommandText = "Delete From BonuriConsum Where IdBonConsum = " + txtIdBonConsum.Text;
            //MessageBox.Show("Stergere realizata cu succes!");
            cmd.ExecuteNonQuery();
            con.Close();
            // Refresh grid-uri
            refreshGrid();
            position_grid(p + 1);
            try
            {
                bonuriConsumContinutBindingSource.Filter = "IdBonConsum=" + txtIdBonConsum.Text;
            }
            catch { }
        }

        private void btnModificaBon_Click(object sender, EventArgs e)
        {
            int p = bonuriConsumBindingSource.Position;
            BonConsumActForm f = new BonConsumActForm();
            f.completeazaTitlu("Modificare Bon consum");
            f.bs1 = bonuriConsumBindingSource;
            f.bs2 = bonuriConsumContinutBindingSource;
            f.ShowDialog();
            refreshGrid();
            position_grid(p);
            try
            {
                bonuriConsumContinutBindingSource.Filter = "IdBonConsum=" + txtIdBonConsum.Text;
            }
            catch { }
        }

        private void btnRaportConsumuri_Click(object sender, EventArgs e)
        {
            ConsumReportForm f = new ConsumReportForm();
            f.ShowDialog();
        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            StatisticiConsumForm f = new StatisticiConsumForm();
            f.ShowDialog();
        }
    }
}
