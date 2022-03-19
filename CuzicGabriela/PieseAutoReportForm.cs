using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuzicGabriela
{
    public partial class PieseAutoReportForm : Form
    {
        public PieseAutoReportForm()
        {
            InitializeComponent();
        }

        private void PieseAutoReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportDS.PieseAuto' table. You can move, or remove it, as needed.
            //this.PieseAutoTableAdapter.Fill(this.ReportDS.PieseAuto);

        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            // Validare numericitate
            decimal p1,p2;
            try { 
                p1 = Convert.ToDecimal(txtPretMinim.Text);
                p2 = Convert.ToDecimal(txtPretMaxim.Text);
                this.PieseAutoTableAdapter.Fill(this.ReportDS.PieseAuto, txtDPiesa.Text, p1, p2);

                //Pregatesc parametrii raportului
                ReportParameter[] parameters = new ReportParameter[1];
                if (txtDPiesa.Text != "")
                    parameters[0] = new ReportParameter("Titlu", "Lista Pieselor auto ce contin \"" + txtDPiesa.Text.ToString() + "\" in denumire, la pretul de " + txtPretMinim.Text + "-" + txtPretMaxim.Text+" lei");
                else parameters[0] = new ReportParameter("Titlu", "Lista Pieselor auto la pretul de " + txtPretMinim.Text + "-" + txtPretMaxim.Text+ " lei");

                //Comunicare parametrii
                this.reportViewer1.LocalReport.SetParameters(parameters);

                //Emit raport
                this.reportViewer1.RefreshReport();
            }
            catch { MessageBox.Show("Completati pretul minim si maxim in format numeric!"); txtPretMinim.Focus(); }

        }
    }
}
