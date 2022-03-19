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
    public partial class StatisticiAprovizionareForm : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private decimal totalAchizitii;
        public StatisticiAprovizionareForm()
        {
            InitializeComponent();
        }

        private void StatisticiAprovizionareForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statDS.AchizitiiPieseAuto' table. You can move, or remove it, as needed.
            this.achizitiiPieseAutoTableAdapter.Fill(this.statDS.AchizitiiPieseAuto);
            //Pregatire con si cmd
            con = achizitiiPieseAutoTableAdapter.Connection;
            cmd.Connection = con;
            //Total achizitii
            cmd.CommandText = "select sum(Cantitate) as Total from FacturiContinut";

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            totalAchizitii = rdr.GetDecimal(0);
            con.Close();
            rdr.Close();

            txtTotalAchizitii.Text = "" + totalAchizitii;

            foreach (DataRow r in statDS.AchizitiiPieseAuto)
            {
                decimal x;
                x = (decimal)r["Total"] / totalAchizitii;
                x = Math.Round(x, 4) * 100;
                x = Math.Round(x, 2);
                r["Procent"] = x;
            }
        }
    }
}
