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
    public partial class ClientiReportForm : Form
    {
        public ClientiReportForm()
        {
            InitializeComponent();
        }

        private void ClientiReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ReportDS.Clienti' table. You can move, or remove it, as needed.
            //this.ClientiTableAdapter.Fill(this.ReportDS.Clienti);

            //this.reportViewer1.RefreshReport();
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            this.ClientiTableAdapter.Fill(this.ReportDS.Clienti, txtDClient.Text.ToString());
            //Pregatesc parametrii raportului
            ReportParameter[] parameters = new ReportParameter[1];
            if(txtDClient.Text!="")
                parameters[0] = new ReportParameter("Titlu", "Lista Clientilor ce contin \"" + txtDClient.Text.ToString() +"\" in nume");
            else parameters[0] = new ReportParameter("Titlu", "Lista Clientilor " + txtDClient.Text.ToString());

            //Comunicare parametrii
            this.reportViewer1.LocalReport.SetParameters(parameters);

            //Emit raport
            this.reportViewer1.RefreshReport();
        }
    }
}
