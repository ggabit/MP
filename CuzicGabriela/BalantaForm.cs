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
    public partial class BalantaForm : Form
    {
        private static OleDbConnection con = new OleDbConnection();
        private static OleDbCommand cmd = new OleDbCommand();
        public BindingSource bs1;
        public BalantaForm()
        {
            InitializeComponent();
        }

        private void BalantaForm_Load(object sender, EventArgs e)
        {
            con.ConnectionString = balantaTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            con.Open();

            //Sterg continut tabela BalantaStoc
            cmd.CommandText = "Delete * from BalantaStoc";
            cmd.ExecuteNonQuery();
            con.Close();
            //Calcul stoc
            CalculeStoc.calculStoc(balantaTableAdapter.Connection.ConnectionString);
            calculStocTableAdapter.Fill(balDS.CalculStoc);

            //Insert idPiesa si StocFinal
            con.Open();
            cmd.CommandText = "INSERT INTO BalantaStoc ( IdPiesaAuto, StocFinal )" +
                            " SELECT IdPiesaAuto, Cantitate FROM CalculStoc Where IdOperatie=4";
            cmd.ExecuteNonQuery();
            con.Close();
            balantaTableAdapter.Fill(balDS.Balanta);

            //Update StocInitial
            con.Open();
            cmd.CommandText = "UPDATE BalantaStoc LEFT JOIN StocInitial ON BalantaStoc.IdPiesaAuto = StocInitial.IdPiesaAuto " +
                              "SET BalantaStoc.StocInitial = StocInitial.Cantitate";
            cmd.ExecuteNonQuery();
            con.Close();
            balantaTableAdapter.Fill(balDS.Balanta);


            BalDSTableAdapters.AchizitiiTableAdapter taA = new BalDSTableAdapters.AchizitiiTableAdapter();
            taA.Fill(balDS.Achizitii);

            DataRelation balAchizitii = balDS.Relations.Add(balDS.Balanta.Columns["IdPiesaAuto"], balDS.Achizitii.Columns["IdPiesaAuto"]);

            foreach (DataRow rb in balDS.Balanta)
            {
                foreach (DataRow ri in rb.GetChildRows(balAchizitii))
                {
                    rb["Achizitii"] = ri["Total"];
                }
            }
            BalDSTableAdapters.ConsumuriTableAdapter taC = new BalDSTableAdapters.ConsumuriTableAdapter();
            taC.Fill(balDS.Consumuri);

            DataRelation balConsumuri = balDS.Relations.Add(balDS.Balanta.Columns["IdPiesaAuto"], balDS.Consumuri.Columns["IdPiesaAuto"]);

            foreach (DataRow rb in balDS.Balanta)
            {
                foreach (DataRow ri in rb.GetChildRows(balConsumuri))
                {
                    rb["Consumuri"] = ri["Total"];
                }
            }
            bs1 = balantaBindingSource;
            DataRowView current = (DataRowView)bs1.Current;
            try
            {
                calculStocBindingSource.Filter = "IdPiesaAuto=" + current["IdPiesaAuto"].ToString();
            }
            catch { }

        }

        private void balantaBindingSource_PositionChanged(object sender, EventArgs e)
        {
            bs1 = balantaBindingSource;
            DataRowView current = (DataRowView)bs1.Current;
            try
            {
                calculStocBindingSource.Filter = "IdPiesaAuto=" + current["IdPiesaAuto"].ToString();
            }
            catch { }
        }

        private void btnGrafic_Click(object sender, EventArgs e)
        {
            ReprezentareGraficaStocForm f = new ReprezentareGraficaStocForm();
            f.ShowDialog();
        }
    }
}
