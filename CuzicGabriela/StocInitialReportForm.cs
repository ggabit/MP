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
    public partial class StocInitialReportForm : Form
    {
        public StocInitialReportForm()
        {
            InitializeComponent();
        }

        private void StocInitialReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportDS.StocInitial' table. You can move, or remove it, as needed.
            //this.StocInitialTableAdapter.Fill(this.ReportDS.StocInitial);

            //this.reportViewer1.RefreshReport();
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            DateTime d2 = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
            this.StocInitialTableAdapter.Fill(this.ReportDS.StocInitial, d1, d2, txtDPiesa.Text);

            //Pregatesc parametrii raportului
            ReportParameter[] parameters = new ReportParameter[1];
            if (txtDPiesa.Text != "")
                parameters[0] = new ReportParameter("Titlu", "Lista inregistrarilor ce contin \"" + txtDPiesa.Text.ToString() + "\" in denumire, din perioada " + d1.ToShortDateString() + "-" + d2.ToShortDateString());
            else parameters[0] = new ReportParameter("Titlu", "Lista inregistrarilor din perioada " + d1.ToShortDateString() + "-" + d2.ToShortDateString());

            //Comunicare parametrii
            this.reportViewer1.LocalReport.SetParameters(parameters);

            //Emit raport
            this.reportViewer1.RefreshReport();
        }
    }
}
