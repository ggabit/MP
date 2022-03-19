using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuzicGabriela
{
    public partial class StatisticiConsumForm : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private decimal totalConsumuri;

        public StatisticiConsumForm()
        {
            InitializeComponent();
        }

        private void StatisticiConsumForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statDS.ConsumPieseAuto' table. You can move, or remove it, as needed.
            this.consumPieseAutoTableAdapter.Fill(this.statDS.ConsumPieseAuto);
            //Pregatire con si cmd
            con = consumPieseAutoTableAdapter.Connection;
            cmd.Connection = con;
            //Total consumuri
            cmd.CommandText = "select sum(Cantitate) as Total from BonuriConsumContinut";

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            totalConsumuri = rdr.GetDecimal(0);
            con.Close();
            rdr.Close();

            txtTotalConsumuri.Text = "" + totalConsumuri;

            foreach (DataRow r in statDS.ConsumPieseAuto)
            {
                decimal x;
                x = (decimal)r["Total"] / totalConsumuri;
                x = Math.Round(x, 4) * 100;
                x = Math.Round(x, 2);
                r["Procent"] = x;

            }
        }
    }
}
