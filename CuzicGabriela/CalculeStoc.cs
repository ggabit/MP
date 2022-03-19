using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CuzicGabriela
{
    class CalculeStoc
    {
        private static OleDbConnection con = new OleDbConnection();
        private static OleDbCommand cmd = new OleDbCommand();

        public static void calculStoc(string cs)
        {
            con.ConnectionString = cs;
            cmd.Connection = con;
            con.Open();
            //Sterg continut tabelei CalculStoc
            cmd.CommandText = "Delete * from CalculStoc";
            cmd.ExecuteNonQuery();

            stocInitial(); intrari(); iesiri();stocFinal();
            con.Close();
        }

        private static void stocInitial()
        {
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdPiesaAuto, Cantitate) " +
                              "Select 1,Data, IdPiesaAuto, Cantitate " +
                              "From StocInitial";

            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private static void intrari()
        {
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdPiesaAuto, Cantitate) " +
                              "Select 2,Facturi.DataFactura as Data, FacturiContinut.IdPiesaAuto, FacturiContinut.Cantitate " +
                              "From FacturiContinut LEFT OUTER JOIN Facturi ON FacturiContinut.IdFactura=Facturi.IdFactura";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private static void iesiri()
        {
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdPiesaAuto, Cantitate) " +
                   "Select 3,BonuriConsum.DataBonConsum as Data, BonuriConsumContinut.IdPiesaAuto, -BonuriConsumContinut.Cantitate " +
                   "From BonuriConsumContinut LEFT OUTER JOIN BonuriConsum ON BonuriConsumContinut.IdBonConsum=BonuriConsum.IdBonConsum";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private static void stocFinal()
        {

            // Calculez totaluri pe Cantitate si grupez pe IdPiesaAuto 

            cmd.CommandText = "INSERT INTO CalculStoc ( IdOperatie, IdPiesaAuto, Cantitate, Data ) " +
                              "SELECT  4,CalculStoc.IdPiesaAuto, Sum(CalculStoc.Cantitate) AS Cantitate, now() " +
                              "FROM CalculStoc GROUP BY CalculStoc.IdPiesaAuto";
            cmd.ExecuteNonQuery();
        }
    }
}
