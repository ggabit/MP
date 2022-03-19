
namespace CuzicGabriela
{
    partial class LucrariReportForm
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
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.txtDLucrare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReportDS = new CuzicGabriela.ReportDS();
            this.LucrariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LucrariTableAdapter = new CuzicGabriela.ReportDSTableAdapters.LucrariTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LucrariBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(388, 45);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(112, 23);
            this.btnAfiseaza.TabIndex = 10;
            this.btnAfiseaza.Text = "Afiseaza raport";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // txtDLucrare
            // 
            this.txtDLucrare.Location = new System.Drawing.Point(159, 42);
            this.txtDLucrare.Name = "txtDLucrare";
            this.txtDLucrare.Size = new System.Drawing.Size(135, 20);
            this.txtDLucrare.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Denumire Lucrare";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.LucrariBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CuzicGabriela.LucrariReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(55, 91);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(494, 313);
            this.reportViewer1.TabIndex = 7;
            // 
            // ReportDS
            // 
            this.ReportDS.DataSetName = "ReportDS";
            this.ReportDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LucrariBindingSource
            // 
            this.LucrariBindingSource.DataMember = "Lucrari";
            this.LucrariBindingSource.DataSource = this.ReportDS;
            // 
            // LucrariTableAdapter
            // 
            this.LucrariTableAdapter.ClearBeforeFill = true;
            // 
            // LucrariReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 450);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.txtDLucrare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "LucrariReportForm";
            this.Text = "LucrariReportForm";
            this.Load += new System.EventHandler(this.LucrariReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LucrariBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.TextBox txtDLucrare;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LucrariBindingSource;
        private ReportDS ReportDS;
        private ReportDSTableAdapters.LucrariTableAdapter LucrariTableAdapter;
    }
}