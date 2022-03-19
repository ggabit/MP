
namespace CuzicGabriela
{
    partial class FurnizoriReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportDS = new CuzicGabriela.ReportDS();
            this.FurnizoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FurnizoriTableAdapter = new CuzicGabriela.ReportDSTableAdapters.FurnizoriTableAdapter();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.txtDFurnizor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FurnizoriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.FurnizoriBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CuzicGabriela.FurnizoriReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(38, 94);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(494, 313);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportDS
            // 
            this.ReportDS.DataSetName = "ReportDS";
            this.ReportDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FurnizoriBindingSource
            // 
            this.FurnizoriBindingSource.DataMember = "Furnizori";
            this.FurnizoriBindingSource.DataSource = this.ReportDS;
            // 
            // FurnizoriTableAdapter
            // 
            this.FurnizoriTableAdapter.ClearBeforeFill = true;
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(371, 48);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(112, 23);
            this.btnAfiseaza.TabIndex = 6;
            this.btnAfiseaza.Text = "Afiseaza raport";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // txtDFurnizor
            // 
            this.txtDFurnizor.Location = new System.Drawing.Point(142, 45);
            this.txtDFurnizor.Name = "txtDFurnizor";
            this.txtDFurnizor.Size = new System.Drawing.Size(135, 20);
            this.txtDFurnizor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Denumire Furnizor";
            // 
            // FurnizoriReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.txtDFurnizor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FurnizoriReportForm";
            this.Text = "FurnizoriReportForm";
            this.Load += new System.EventHandler(this.FurnizoriReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FurnizoriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FurnizoriBindingSource;
        private ReportDS ReportDS;
        private ReportDSTableAdapters.FurnizoriTableAdapter FurnizoriTableAdapter;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.TextBox txtDFurnizor;
        private System.Windows.Forms.Label label1;
    }
}