
namespace CuzicGabriela
{
    partial class StatisticiConsumForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalConsumuri = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.consumPieseAutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statDS = new CuzicGabriela.StatDS();
            this.consumPieseAutoTableAdapter = new CuzicGabriela.StatDSTableAdapters.ConsumPieseAutoTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dPiesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumPieseAutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consumuri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total consumuri";
            // 
            // txtTotalConsumuri
            // 
            this.txtTotalConsumuri.Location = new System.Drawing.Point(180, 91);
            this.txtTotalConsumuri.Name = "txtTotalConsumuri";
            this.txtTotalConsumuri.Size = new System.Drawing.Size(100, 20);
            this.txtTotalConsumuri.TabIndex = 2;
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
            this.dataGridView1.DataSource = this.consumPieseAutoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(74, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(410, 236);
            this.dataGridView1.TabIndex = 3;
            // 
            // consumPieseAutoBindingSource
            // 
            this.consumPieseAutoBindingSource.DataMember = "ConsumPieseAuto";
            this.consumPieseAutoBindingSource.DataSource = this.statDS;
            // 
            // statDS
            // 
            this.statDS.DataSetName = "StatDS";
            this.statDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consumPieseAutoTableAdapter
            // 
            this.consumPieseAutoTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.consumPieseAutoBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(74, 401);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Consumuri";
            series1.XValueMember = "DPiesa";
            series1.YValueMembers = "Total";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(912, 248);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // dPiesaDataGridViewTextBoxColumn
            // 
            this.dPiesaDataGridViewTextBoxColumn.DataPropertyName = "DPiesa";
            this.dPiesaDataGridViewTextBoxColumn.HeaderText = "Denumire Piesa";
            this.dPiesaDataGridViewTextBoxColumn.Name = "dPiesaDataGridViewTextBoxColumn";
            this.dPiesaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dPiesaDataGridViewTextBoxColumn.Width = 160;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 80;
            // 
            // procentDataGridViewTextBoxColumn
            // 
            this.procentDataGridViewTextBoxColumn.DataPropertyName = "Procent";
            this.procentDataGridViewTextBoxColumn.HeaderText = "Procent";
            this.procentDataGridViewTextBoxColumn.Name = "procentDataGridViewTextBoxColumn";
            this.procentDataGridViewTextBoxColumn.ReadOnly = true;
            this.procentDataGridViewTextBoxColumn.Width = 80;
            // 
            // StatisticiConsumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 689);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotalConsumuri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StatisticiConsumForm";
            this.Text = "StatisticiConsumForm";
            this.Load += new System.EventHandler(this.StatisticiConsumForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumPieseAutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalConsumuri;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StatDS statDS;
        private System.Windows.Forms.BindingSource consumPieseAutoBindingSource;
        private StatDSTableAdapters.ConsumPieseAutoTableAdapter consumPieseAutoTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPiesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procentDataGridViewTextBoxColumn;
    }
}