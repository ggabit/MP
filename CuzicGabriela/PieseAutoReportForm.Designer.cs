
namespace CuzicGabriela
{
    partial class PieseAutoReportForm
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
            this.txtDPiesa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPretMinim = new System.Windows.Forms.TextBox();
            this.txtPretMaxim = new System.Windows.Forms.TextBox();
            this.ReportDS = new CuzicGabriela.ReportDS();
            this.PieseAutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PieseAutoTableAdapter = new CuzicGabriela.ReportDSTableAdapters.PieseAutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieseAutoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(648, 46);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(112, 23);
            this.btnAfiseaza.TabIndex = 10;
            this.btnAfiseaza.Text = "Afiseaza raport";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // txtDPiesa
            // 
            this.txtDPiesa.Location = new System.Drawing.Point(160, 46);
            this.txtDPiesa.Name = "txtDPiesa";
            this.txtDPiesa.Size = new System.Drawing.Size(109, 20);
            this.txtDPiesa.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Denumire Piesa auto";
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PieseAutoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CuzicGabriela.PieseAutoReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(43, 92);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(744, 367);
            this.reportViewer1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pret minim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pret maxim";
            // 
            // txtPretMinim
            // 
            this.txtPretMinim.Location = new System.Drawing.Point(373, 46);
            this.txtPretMinim.Name = "txtPretMinim";
            this.txtPretMinim.Size = new System.Drawing.Size(56, 20);
            this.txtPretMinim.TabIndex = 13;
            // 
            // txtPretMaxim
            // 
            this.txtPretMaxim.Location = new System.Drawing.Point(537, 45);
            this.txtPretMaxim.Name = "txtPretMaxim";
            this.txtPretMaxim.Size = new System.Drawing.Size(50, 20);
            this.txtPretMaxim.TabIndex = 14;
            // 
            // ReportDS
            // 
            this.ReportDS.DataSetName = "ReportDS";
            this.ReportDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PieseAutoBindingSource
            // 
            this.PieseAutoBindingSource.DataMember = "PieseAuto";
            this.PieseAutoBindingSource.DataSource = this.ReportDS;
            // 
            // PieseAutoTableAdapter
            // 
            this.PieseAutoTableAdapter.ClearBeforeFill = true;
            // 
            // PieseAutoReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 500);
            this.Controls.Add(this.txtPretMaxim);
            this.Controls.Add(this.txtPretMinim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.txtDPiesa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PieseAutoReportForm";
            this.Text = "PieseAutoReportForm";
            this.Load += new System.EventHandler(this.PieseAutoReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieseAutoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.TextBox txtDPiesa;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPretMinim;
        private System.Windows.Forms.TextBox txtPretMaxim;
        private System.Windows.Forms.BindingSource PieseAutoBindingSource;
        private ReportDS ReportDS;
        private ReportDSTableAdapters.PieseAutoTableAdapter PieseAutoTableAdapter;
    }
}