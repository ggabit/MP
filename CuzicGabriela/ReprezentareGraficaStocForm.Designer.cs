
namespace CuzicGabriela
{
    partial class ReprezentareGraficaStocForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CuzicGabriela.DataSet1();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.stocTableAdapter = new CuzicGabriela.DataSet1TableAdapters.StocTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dPiesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            this.uMDataGridViewTextBoxColumn,
            this.stocFinalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stocBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(52, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(399, 134);
            this.dataGridView1.TabIndex = 0;
            // 
            // stocBindingSource
            // 
            this.stocBindingSource.DataMember = "Stoc";
            this.stocBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart1
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.stocBindingSource;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(52, 229);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Stoc";
            series2.XValueMember = "DPiesa";
            series2.YValueMembers = "StocFinal";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(989, 257);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // stocTableAdapter
            // 
            this.stocTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reprezentare grafica a resurselor";
            // 
            // dPiesaDataGridViewTextBoxColumn
            // 
            this.dPiesaDataGridViewTextBoxColumn.DataPropertyName = "DPiesa";
            this.dPiesaDataGridViewTextBoxColumn.HeaderText = "Denumire Piesa";
            this.dPiesaDataGridViewTextBoxColumn.Name = "dPiesaDataGridViewTextBoxColumn";
            this.dPiesaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dPiesaDataGridViewTextBoxColumn.Width = 160;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.ReadOnly = true;
            this.uMDataGridViewTextBoxColumn.Width = 80;
            // 
            // stocFinalDataGridViewTextBoxColumn
            // 
            this.stocFinalDataGridViewTextBoxColumn.DataPropertyName = "StocFinal";
            this.stocFinalDataGridViewTextBoxColumn.HeaderText = "Stoc";
            this.stocFinalDataGridViewTextBoxColumn.Name = "stocFinalDataGridViewTextBoxColumn";
            this.stocFinalDataGridViewTextBoxColumn.ReadOnly = true;
            this.stocFinalDataGridViewTextBoxColumn.Width = 80;
            // 
            // ReprezentareGraficaStocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReprezentareGraficaStocForm";
            this.Text = "ReprezentareGraficaStocForm";
            this.Load += new System.EventHandler(this.ReprezentareGraficaStocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource stocBindingSource;
        private DataSet1TableAdapters.StocTableAdapter stocTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPiesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocFinalDataGridViewTextBoxColumn;
    }
}