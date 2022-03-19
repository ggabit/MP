using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace CuzicGabriela
{
    public partial class AprovizionareReportForm : Form
    {
        public AprovizionareReportForm()
        {
            InitializeComponent();
        }

        private void AprovizionareReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportDS.Aprovizionare' table. You can move, or remove it, as needed.
            //this.AprovizionareTableAdapter.Fill(this.ReportDS.Aprovizionare);

            //this.reportViewer1.RefreshReport();
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            DateTime d2 = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
            this.AprovizionareTableAdapter.Fill(this.ReportDS.Aprovizionare, d1, d2);
            //Pregatesc parametrii raportului
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("Titlu", "Lista achizitiilor din perioada " + d1.ToShortDateString() +
                                                                     " - " + d2.ToShortDateString());

            //Comunicare parametrii
            this.reportViewer1.LocalReport.SetParameters(parameters);

            //Emit raport
            this.reportViewer1.RefreshReport();
        }
    }
}
