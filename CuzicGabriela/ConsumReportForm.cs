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
    public partial class ConsumReportForm : Form
    {
        public ConsumReportForm()
        {
            InitializeComponent();
        }

        private void ConsumReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportDS.Consum' table. You can move, or remove it, as needed.
            //this.ConsumTableAdapter.Fill(this.ReportDS.Consum);
            //this.reportViewer1.RefreshReport();

        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            DateTime d2 = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
            this.ConsumTableAdapter.Fill(this.ReportDS.Consum, d1, d2);
            //Pregatesc parametrii raportului
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("Title", "Lista consumurilor din perioada " + d1.ToShortDateString() +
                                                                     " - " + d2.ToShortDateString());

            //Comunicare parametrii
            this.reportViewer1.LocalReport.SetParameters(parameters);

            //Emit raport
            this.reportViewer1.RefreshReport();
            this.reportViewer1.DataBindings.Clear();
        }
    }
}
