
namespace CuzicGabriela
{
    partial class StatisticiAprovizionareForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dPiesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achizitiiPieseAutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statDS = new CuzicGabriela.StatDS();
            this.txtTotalAchizitii = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.achizitiiPieseAutoTableAdapter = new CuzicGabriela.StatDSTableAdapters.AchizitiiPieseAutoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.achizitiiPieseAutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dPiesaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.procentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.achizitiiPieseAutoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(38, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(418, 220);
            this.dataGridView1.TabIndex = 7;
            // 
            // dPiesaDataGridViewTextBoxColumn
            // 
            this.dPiesaDataGridViewTextBoxColumn.DataPropertyName = "DPiesa";
            this.dPiesaDataGridViewTextBoxColumn.HeaderText = "Denumire Piesa";
            this.dPiesaDataGridViewTextBoxColumn.Name = "dPiesaDataGridViewTextBoxColumn";
            this.dPiesaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dPiesaDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procentDataGridViewTextBoxColumn
            // 
            this.procentDataGridViewTextBoxColumn.DataPropertyName = "Procent";
            this.procentDataGridViewTextBoxColumn.HeaderText = "Procent";
            this.procentDataGridViewTextBoxColumn.Name = "procentDataGridViewTextBoxColumn";
            this.procentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // achizitiiPieseAutoBindingSource
            // 
            this.achizitiiPieseAutoBindingSource.DataMember = "AchizitiiPieseAuto";
            this.achizitiiPieseAutoBindingSource.DataSource = this.statDS;
            // 
            // statDS
            // 
            this.statDS.DataSetName = "StatDS";
            this.statDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtTotalAchizitii
            // 
            this.txtTotalAchizitii.Location = new System.Drawing.Point(190, 98);
            this.txtTotalAchizitii.Name = "txtTotalAchizitii";
            this.txtTotalAchizitii.Size = new System.Drawing.Size(100, 20);
            this.txtTotalAchizitii.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total achizitii";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Achizitii";
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.achizitiiPieseAutoBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(38, 396);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Achizitii";
            series1.XValueMember = "DPiesa";
            series1.YValueMembers = "Total";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(767, 200);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // achizitiiPieseAutoTableAdapter
            // 
            this.achizitiiPieseAutoTableAdapter.ClearBeforeFill = true;
            // 
            // StatisticiAprovizionareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 635);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotalAchizitii);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StatisticiAprovizionareForm";
            this.Text = "StatisticiAprovizionareForm";
            this.Load += new System.EventHandler(this.StatisticiAprovizionareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.achizitiiPieseAutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtTotalAchizitii;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private StatDS statDS;
        private System.Windows.Forms.BindingSource achizitiiPieseAutoBindingSource;
        private StatDSTableAdapters.AchizitiiPieseAutoTableAdapter achizitiiPieseAutoTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPiesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procentDataGridViewTextBoxColumn;
    }
}