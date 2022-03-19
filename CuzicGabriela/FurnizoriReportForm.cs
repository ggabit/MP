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
    public partial class FurnizoriReportForm : Form
    {
        public FurnizoriReportForm()
        {
            InitializeComponent();
        }

        private void FurnizoriReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportDS.Furnizori' table. You can move, or remove it, as needed.
            //this.FurnizoriTableAdapter.Fill(this.ReportDS.Furnizori);

            //this.reportViewer1.RefreshReport();
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            this.FurnizoriTableAdapter.Fill(this.ReportDS.Furnizori, txtDFurnizor.Text.ToString());
            //Pregatesc parametrii raportului
            ReportParameter[] parameters = new ReportParameter[1];
            if (txtDFurnizor.Text != "")
                parameters[0] = new ReportParameter("Titlu", "Lista Furnizorilor ce contin \"" + txtDFurnizor.Text.ToString() + "\" in nume");
            else parameters[0] = new ReportParameter("Titlu", "Lista Furnizorilor " + txtDFurnizor.Text.ToString());

            //Comunicare parametrii
            this.reportViewer1.LocalReport.SetParameters(parameters);

            //Emit raport
            this.reportViewer1.RefreshReport();
        }
    }
}
