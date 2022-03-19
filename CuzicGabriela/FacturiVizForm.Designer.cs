
namespace CuzicGabriela
{
    partial class FacturiVizForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CuzicGabriela.DataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.facturiContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.btnFacturaNoua = new System.Windows.Forms.Button();
            this.btnModificaFactura = new System.Windows.Forms.Button();
            this.btnStergeFactura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.facturiTableAdapter = new CuzicGabriela.DataSet1TableAdapters.FacturiTableAdapter();
            this.facturiContinutTableAdapter = new CuzicGabriela.DataSet1TableAdapters.FacturiContinutTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRaportAprovizionare = new System.Windows.Forms.Button();
            this.btnGrafic = new System.Windows.Forms.Button();
            this.dFurnizorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrCrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPiesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretAchizitieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiContinutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dFurnizorDataGridViewTextBoxColumn,
            this.nrFacturaDataGridViewTextBoxColumn,
            this.dataFacturaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facturiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(509, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // facturiBindingSource
            // 
            this.facturiBindingSource.DataMember = "Facturi";
            this.facturiBindingSource.DataSource = this.dataSet1;
            this.facturiBindingSource.PositionChanged += new System.EventHandler(this.facturiBindingSource_PositionChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrCrtDataGridViewTextBoxColumn,
            this.dPiesaDataGridViewTextBoxColumn,
            this.cantitateDataGridViewTextBoxColumn,
            this.pretAchizitieDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.facturiContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(28, 322);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(606, 168);
            this.dataGridView2.TabIndex = 1;
            // 
            // facturiContinutBindingSource
            // 
            this.facturiContinutBindingSource.DataMember = "FacturiContinut";
            this.facturiContinutBindingSource.DataSource = this.dataSet1;
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facturiBindingSource, "IdFactura", true));
            this.txtIdFactura.Location = new System.Drawing.Point(699, 60);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(100, 20);
            this.txtIdFactura.TabIndex = 2;
            // 
            // btnFacturaNoua
            // 
            this.btnFacturaNoua.Location = new System.Drawing.Point(699, 110);
            this.btnFacturaNoua.Name = "btnFacturaNoua";
            this.btnFacturaNoua.Size = new System.Drawing.Size(80, 34);
            this.btnFacturaNoua.TabIndex = 3;
            this.btnFacturaNoua.Text = "Factura noua";
            this.btnFacturaNoua.UseVisualStyleBackColor = true;
            this.btnFacturaNoua.Click += new System.EventHandler(this.btnFacturaNoua_Click);
            // 
            // btnModificaFactura
            // 
            this.btnModificaFactura.Location = new System.Drawing.Point(699, 151);
            this.btnModificaFactura.Name = "btnModificaFactura";
            this.btnModificaFactura.Size = new System.Drawing.Size(80, 35);
            this.btnModificaFactura.TabIndex = 4;
            this.btnModificaFactura.Text = "Modificare factura";
            this.btnModificaFactura.UseVisualStyleBackColor = true;
            this.btnModificaFactura.Click += new System.EventHandler(this.btnModificaFactura_Click);
            // 
            // btnStergeFactura
            // 
            this.btnStergeFactura.Location = new System.Drawing.Point(699, 194);
            this.btnStergeFactura.Name = "btnStergeFactura";
            this.btnStergeFactura.Size = new System.Drawing.Size(80, 37);
            this.btnStergeFactura.TabIndex = 5;
            this.btnStergeFactura.Text = "Sterge factura";
            this.btnStergeFactura.UseVisualStyleBackColor = true;
            this.btnStergeFactura.Click += new System.EventHandler(this.btnStergeFactura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(623, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Factura";
            // 
            // facturiTableAdapter
            // 
            this.facturiTableAdapter.ClearBeforeFill = true;
            // 
            // facturiContinutTableAdapter
            // 
            this.facturiContinutTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Facturi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Detalii factura";
            // 
            // btnRaportAprovizionare
            // 
            this.btnRaportAprovizionare.Location = new System.Drawing.Point(699, 237);
            this.btnRaportAprovizionare.Name = "btnRaportAprovizionare";
            this.btnRaportAprovizionare.Size = new System.Drawing.Size(80, 39);
            this.btnRaportAprovizionare.TabIndex = 9;
            this.btnRaportAprovizionare.Text = "Raport Aprovizionare";
            this.btnRaportAprovizionare.UseVisualStyleBackColor = true;
            this.btnRaportAprovizionare.Click += new System.EventHandler(this.btnRaportAprovizionare_Click);
            // 
            // btnGrafic
            // 
            this.btnGrafic.Location = new System.Drawing.Point(699, 283);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(80, 39);
            this.btnGrafic.TabIndex = 10;
            this.btnGrafic.Text = "Reprezentare grafica";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // dFurnizorDataGridViewTextBoxColumn
            // 
            this.dFurnizorDataGridViewTextBoxColumn.DataPropertyName = "DFurnizor";
            this.dFurnizorDataGridViewTextBoxColumn.HeaderText = "Denumire Furnizor";
            this.dFurnizorDataGridViewTextBoxColumn.Name = "dFurnizorDataGridViewTextBoxColumn";
            this.dFurnizorDataGridViewTextBoxColumn.ReadOnly = true;
            this.dFurnizorDataGridViewTextBoxColumn.Width = 150;
            // 
            // nrFacturaDataGridViewTextBoxColumn
            // 
            this.nrFacturaDataGridViewTextBoxColumn.DataPropertyName = "NrFactura";
            this.nrFacturaDataGridViewTextBoxColumn.HeaderText = "Nr Factura";
            this.nrFacturaDataGridViewTextBoxColumn.Name = "nrFacturaDataGridViewTextBoxColumn";
            this.nrFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFacturaDataGridViewTextBoxColumn
            // 
            this.dataFacturaDataGridViewTextBoxColumn.DataPropertyName = "DataFactura";
            this.dataFacturaDataGridViewTextBoxColumn.HeaderText = "Data Factura";
            this.dataFacturaDataGridViewTextBoxColumn.Name = "dataFacturaDataGridViewTextBoxColumn";
            this.dataFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrCrtDataGridViewTextBoxColumn
            // 
            this.nrCrtDataGridViewTextBoxColumn.DataPropertyName = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.HeaderText = "Nr";
            this.nrCrtDataGridViewTextBoxColumn.Name = "nrCrtDataGridViewTextBoxColumn";
            this.nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dPiesaDataGridViewTextBoxColumn
            // 
            this.dPiesaDataGridViewTextBoxColumn.DataPropertyName = "DPiesa";
            this.dPiesaDataGridViewTextBoxColumn.HeaderText = "Denumire Piesa";
            this.dPiesaDataGridViewTextBoxColumn.Name = "dPiesaDataGridViewTextBoxColumn";
            this.dPiesaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dPiesaDataGridViewTextBoxColumn.Width = 150;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pretAchizitieDataGridViewTextBoxColumn
            // 
            this.pretAchizitieDataGridViewTextBoxColumn.DataPropertyName = "PretAchizitie";
            this.pretAchizitieDataGridViewTextBoxColumn.HeaderText = "Pret Achizitie";
            this.pretAchizitieDataGridViewTextBoxColumn.Name = "pretAchizitieDataGridViewTextBoxColumn";
            this.pretAchizitieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FacturiVizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 524);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.btnRaportAprovizionare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStergeFactura);
            this.Controls.Add(this.btnModificaFactura);
            this.Controls.Add(this.btnFacturaNoua);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FacturiVizForm";
            this.Text = "Facturi";
            this.Load += new System.EventHandler(this.FacturiVizForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturiContinutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.Button btnFacturaNoua;
        private System.Windows.Forms.Button btnModificaFactura;
        private System.Windows.Forms.Button btnStergeFactura;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource facturiBindingSource;
        private DataSet1TableAdapters.FacturiTableAdapter facturiTableAdapter;
        private System.Windows.Forms.BindingSource facturiContinutBindingSource;
        private DataSet1TableAdapters.FacturiContinutTableAdapter facturiContinutTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRaportAprovizionare;
        private System.Windows.Forms.Button btnGrafic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dFurnizorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPiesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretAchizitieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
    }
}