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
    public partial class LucrariReportForm : Form
    {
        public LucrariReportForm()
        {
            InitializeComponent();
        }

        private void LucrariReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportDS.Lucrari' table. You can move, or remove it, as needed.
            //this.LucrariTableAdapter.Fill(this.ReportDS.Lucrari);

        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            this.LucrariTableAdapter.Fill(this.ReportDS.Lucrari, txtDLucrare.Text.ToString());
            //Pregatesc parametrii raportului
            ReportParameter[] parameters = new ReportParameter[1];
            if (txtDLucrare.Text != "")
                parameters[0] = new ReportParameter("Titlu", "Lista Lucrarilor ce contin \"" + txtDLucrare.Text.ToString() + "\" in denumire");
            else parameters[0] = new ReportParameter("Titlu", "Lista Lucrarilor " + txtDLucrare.Text.ToString());

            //Comunicare parametrii
            this.reportViewer1.LocalReport.SetParameters(parameters);

            //Emit raport
            this.reportViewer1.RefreshReport();
        }
    }
}
