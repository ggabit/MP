
namespace CuzicGabriela
{
    partial class ClientiReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ClientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportDS = new CuzicGabriela.ReportDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientiTableAdapter = new CuzicGabriela.ReportDSTableAdapters.ClientiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDClient = new System.Windows.Forms.TextBox();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDS)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientiBindingSource
            // 
            this.ClientiBindingSource.DataMember = "Clienti";
            this.ClientiBindingSource.DataSource = this.ReportDS;
            // 
            // ReportDS
            // 
            this.ReportDS.DataSetName = "ReportDS";
            this.ReportDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClientiBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CuzicGabriela.ClientiReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(39, 106);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(488, 290);
            this.reportViewer1.TabIndex = 0;
            // 
            // ClientiTableAdapter
            // 
            this.ClientiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume Client";
            // 
            // txtDClient
            // 
            this.txtDClient.Location = new System.Drawing.Point(147, 50);
            this.txtDClient.Name = "txtDClient";
            this.txtDClient.Size = new System.Drawing.Size(135, 20);
            this.txtDClient.TabIndex = 2;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(390, 50);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(112, 23);
            this.btnAfiseaza.TabIndex = 3;
            this.btnAfiseaza.Text = "Afiseaza raport";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // ClientiReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 450);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.txtDClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ClientiReportForm";
            this.Text = "ClientiReportForm";
            this.Load += new System.EventHandler(this.ClientiReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClientiBindingSource;
        private ReportDS ReportDS;
        private ReportDSTableAdapters.ClientiTableAdapter ClientiTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDClient;
        private System.Windows.Forms.Button btnAfiseaza;
    }
}