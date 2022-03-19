
namespace CuzicGabriela
{
    partial class BalantaForm
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
            this.calculStocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balDS = new CuzicGabriela.BalDS();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.balantaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.balantaTableAdapter = new CuzicGabriela.BalDSTableAdapters.BalantaTableAdapter();
            this.calculStocTableAdapter = new CuzicGabriela.BalDSTableAdapters.CalculStocTableAdapter();
            this.btnGrafic = new System.Windows.Forms.Button();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPiesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOperatie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPiesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocInitialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achizitiiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumuriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stocFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDataGridViewTextBoxColumn,
            this.DPiesa,
            this.DOperatie,
            this.cantitateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.calculStocBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(495, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // calculStocBindingSource
            // 
            this.calculStocBindingSource.DataMember = "CalculStoc";
            this.calculStocBindingSource.DataSource = this.balDS;
            // 
            // balDS
            // 
            this.balDS.DataSetName = "BalDS";
            this.balDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dPiesaDataGridViewTextBoxColumn,
            this.stocInitialDataGridViewTextBoxColumn,
            this.achizitiiDataGridViewTextBoxColumn,
            this.consumuriDataGridViewTextBoxColumn,
            this.stocFinalDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.balantaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(637, 154);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(689, 263);
            this.dataGridView2.TabIndex = 1;
            // 
            // balantaBindingSource
            // 
            this.balantaBindingSource.DataMember = "Balanta";
            this.balantaBindingSource.DataSource = this.balDS;
            this.balantaBindingSource.PositionChanged += new System.EventHandler(this.balantaBindingSource_PositionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Calcul Stoc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(683, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Balanta Stoc";
            // 
            // balantaTableAdapter
            // 
            this.balantaTableAdapter.ClearBeforeFill = true;
            // 
            // calculStocTableAdapter
            // 
            this.calculStocTableAdapter.ClearBeforeFill = true;
            // 
            // btnGrafic
            // 
            this.btnGrafic.Location = new System.Drawing.Point(867, 97);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(80, 36);
            this.btnGrafic.TabIndex = 4;
            this.btnGrafic.Text = "Reprezentare grafica";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DPiesa
            // 
            this.DPiesa.DataPropertyName = "DPiesa";
            this.DPiesa.HeaderText = "Denumire Piesa";
            this.DPiesa.Name = "DPiesa";
            this.DPiesa.ReadOnly = true;
            this.DPiesa.Width = 150;
            // 
            // DOperatie
            // 
            this.DOperatie.DataPropertyName = "DOperatie";
            this.DOperatie.HeaderText = "Operatie";
            this.DOperatie.Name = "DOperatie";
            this.DOperatie.ReadOnly = true;
            // 
            // cantitateDataGridViewTextBoxColumn
            // 
            this.cantitateDataGridViewTextBoxColumn.DataPropertyName = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.HeaderText = "Cantitate";
            this.cantitateDataGridViewTextBoxColumn.Name = "cantitateDataGridViewTextBoxColumn";
            this.cantitateDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantitateDataGridViewTextBoxColumn.Width = 80;
            // 
            // dPiesaDataGridViewTextBoxColumn
            // 
            this.dPiesaDataGridViewTextBoxColumn.DataPropertyName = "DPiesa";
            this.dPiesaDataGridViewTextBoxColumn.HeaderText = "Denumire Piesa";
            this.dPiesaDataGridViewTextBoxColumn.Name = "dPiesaDataGridViewTextBoxColumn";
            this.dPiesaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dPiesaDataGridViewTextBoxColumn.Width = 140;
            // 
            // stocInitialDataGridViewTextBoxColumn
            // 
            this.stocInitialDataGridViewTextBoxColumn.DataPropertyName = "StocInitial";
            this.stocInitialDataGridViewTextBoxColumn.HeaderText = "StocInitial";
            this.stocInitialDataGridViewTextBoxColumn.Name = "stocInitialDataGridViewTextBoxColumn";
            this.stocInitialDataGridViewTextBoxColumn.ReadOnly = true;
            this.stocInitialDataGridViewTextBoxColumn.Width = 80;
            // 
            // achizitiiDataGridViewTextBoxColumn
            // 
            this.achizitiiDataGridViewTextBoxColumn.DataPropertyName = "Achizitii";
            this.achizitiiDataGridViewTextBoxColumn.HeaderText = "Achizitii";
            this.achizitiiDataGridViewTextBoxColumn.Name = "achizitiiDataGridViewTextBoxColumn";
            this.achizitiiDataGridViewTextBoxColumn.ReadOnly = true;
            this.achizitiiDataGridViewTextBoxColumn.Width = 80;
            // 
            // consumuriDataGridViewTextBoxColumn
            // 
            this.consumuriDataGridViewTextBoxColumn.DataPropertyName = "Consumuri";
            this.consumuriDataGridViewTextBoxColumn.HeaderText = "Consumuri";
            this.consumuriDataGridViewTextBoxColumn.Name = "consumuriDataGridViewTextBoxColumn";
            this.consumuriDataGridViewTextBoxColumn.ReadOnly = true;
            this.consumuriDataGridViewTextBoxColumn.Width = 80;
            // 
            // stocFinalDataGridViewTextBoxColumn
            // 
            this.stocFinalDataGridViewTextBoxColumn.DataPropertyName = "StocFinal";
            this.stocFinalDataGridViewTextBoxColumn.HeaderText = "StocFinal";
            this.stocFinalDataGridViewTextBoxColumn.Name = "stocFinalDataGridViewTextBoxColumn";
            this.stocFinalDataGridViewTextBoxColumn.ReadOnly = true;
            this.stocFinalDataGridViewTextBoxColumn.Width = 80;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.ReadOnly = true;
            this.pretDataGridViewTextBoxColumn.Width = 80;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.ReadOnly = true;
            this.uMDataGridViewTextBoxColumn.Width = 80;
            // 
            // BalantaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 450);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BalantaForm";
            this.Text = "BalantaForm";
            this.Load += new System.EventHandler(this.BalantaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calculStocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balantaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BalDS balDS;
        private System.Windows.Forms.BindingSource balantaBindingSource;
        private BalDSTableAdapters.BalantaTableAdapter balantaTableAdapter;
        private System.Windows.Forms.BindingSource calculStocBindingSource;
        private BalDSTableAdapters.CalculStocTableAdapter calculStocTableAdapter;
        private System.Windows.Forms.Button btnGrafic;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPiesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOperatie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPiesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocInitialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn achizitiiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consumuriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stocFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
    }
}