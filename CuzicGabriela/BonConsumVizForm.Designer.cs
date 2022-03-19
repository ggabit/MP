
namespace CuzicGabriela
{
    partial class BonConsumVizForm
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
            this.bonuriConsumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CuzicGabriela.DataSet1();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bonuriConsumContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtIdBonConsum = new System.Windows.Forms.TextBox();
            this.btnBonNou = new System.Windows.Forms.Button();
            this.btnModificaBon = new System.Windows.Forms.Button();
            this.btnStergeBon = new System.Windows.Forms.Button();
            this.bonuriConsumContinutTableAdapter = new CuzicGabriela.DataSet1TableAdapters.BonuriConsumContinutTableAdapter();
            this.bonuriConsumTableAdapter = new CuzicGabriela.DataSet1TableAdapters.BonuriConsumTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRaportConsumuri = new System.Windows.Forms.Button();
            this.btnGrafic = new System.Windows.Forms.Button();
            this.nrCrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPiesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantitateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretVanzareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrBonConsumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataBonConsumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dLucrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonuriConsumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonuriConsumContinutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrBonConsumDataGridViewTextBoxColumn,
            this.dataBonConsumDataGridViewTextBoxColumn,
            this.dClientDataGridViewTextBoxColumn,
            this.dLucrareDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bonuriConsumBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(635, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // bonuriConsumBindingSource
            // 
            this.bonuriConsumBindingSource.DataMember = "BonuriConsum";
            this.bonuriConsumBindingSource.DataSource = this.dataSet1;
            this.bonuriConsumBindingSource.PositionChanged += new System.EventHandler(this.bonuriConsumBindingSource_PositionChanged);
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
            this.pretVanzareDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.bonuriConsumContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(48, 298);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(690, 144);
            this.dataGridView2.TabIndex = 1;
            // 
            // bonuriConsumContinutBindingSource
            // 
            this.bonuriConsumContinutBindingSource.DataMember = "BonuriConsumContinut";
            this.bonuriConsumContinutBindingSource.DataSource = this.dataSet1;
            // 
            // txtIdBonConsum
            // 
            this.txtIdBonConsum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bonuriConsumBindingSource, "IdBonConsum", true));
            this.txtIdBonConsum.Location = new System.Drawing.Point(799, 72);
            this.txtIdBonConsum.Name = "txtIdBonConsum";
            this.txtIdBonConsum.Size = new System.Drawing.Size(100, 20);
            this.txtIdBonConsum.TabIndex = 2;
            // 
            // btnBonNou
            // 
            this.btnBonNou.Location = new System.Drawing.Point(824, 111);
            this.btnBonNou.Name = "btnBonNou";
            this.btnBonNou.Size = new System.Drawing.Size(80, 32);
            this.btnBonNou.TabIndex = 3;
            this.btnBonNou.Text = "Bon nou";
            this.btnBonNou.UseVisualStyleBackColor = true;
            this.btnBonNou.Click += new System.EventHandler(this.btnBonNou_Click);
            // 
            // btnModificaBon
            // 
            this.btnModificaBon.Location = new System.Drawing.Point(824, 149);
            this.btnModificaBon.Name = "btnModificaBon";
            this.btnModificaBon.Size = new System.Drawing.Size(80, 36);
            this.btnModificaBon.TabIndex = 4;
            this.btnModificaBon.Text = "Modificare bon";
            this.btnModificaBon.UseVisualStyleBackColor = true;
            this.btnModificaBon.Click += new System.EventHandler(this.btnModificaBon_Click);
            // 
            // btnStergeBon
            // 
            this.btnStergeBon.Location = new System.Drawing.Point(824, 191);
            this.btnStergeBon.Name = "btnStergeBon";
            this.btnStergeBon.Size = new System.Drawing.Size(80, 35);
            this.btnStergeBon.TabIndex = 5;
            this.btnStergeBon.Text = "Sterge Bonul";
            this.btnStergeBon.UseVisualStyleBackColor = true;
            this.btnStergeBon.Click += new System.EventHandler(this.btnStergeBon_Click);
            // 
            // bonuriConsumContinutTableAdapter
            // 
            this.bonuriConsumContinutTableAdapter.ClearBeforeFill = true;
            // 
            // bonuriConsumTableAdapter
            // 
            this.bonuriConsumTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bonuri consum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Detalii bonuri consum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(731, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID Bon";
            // 
            // btnRaportConsumuri
            // 
            this.btnRaportConsumuri.Location = new System.Drawing.Point(824, 232);
            this.btnRaportConsumuri.Name = "btnRaportConsumuri";
            this.btnRaportConsumuri.Size = new System.Drawing.Size(80, 37);
            this.btnRaportConsumuri.TabIndex = 9;
            this.btnRaportConsumuri.Text = "Raport Consumuri";
            this.btnRaportConsumuri.UseVisualStyleBackColor = true;
            this.btnRaportConsumuri.Click += new System.EventHandler(this.btnRaportConsumuri_Click);
            // 
            // btnGrafic
            // 
            this.btnGrafic.Location = new System.Drawing.Point(824, 277);
            this.btnGrafic.Name = "btnGrafic";
            this.btnGrafic.Size = new System.Drawing.Size(80, 36);
            this.btnGrafic.TabIndex = 10;
            this.btnGrafic.Text = "Reprezentare grafica";
            this.btnGrafic.UseVisualStyleBackColor = true;
            this.btnGrafic.Click += new System.EventHandler(this.btnGrafic_Click);
            // 
            // nrCrtDataGridViewTextBoxColumn
            // 
            this.nrCrtDataGridViewTextBoxColumn.DataPropertyName = "NrCrt";
            this.nrCrtDataGridViewTextBoxColumn.HeaderText = "Nr";
            this.nrCrtDataGridViewTextBoxColumn.Name = "nrCrtDataGridViewTextBoxColumn";
            this.nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrCrtDataGridViewTextBoxColumn.Width = 80;
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
            // pretVanzareDataGridViewTextBoxColumn
            // 
            this.pretVanzareDataGridViewTextBoxColumn.DataPropertyName = "PretVanzare";
            this.pretVanzareDataGridViewTextBoxColumn.HeaderText = "Pret Vanzare";
            this.pretVanzareDataGridViewTextBoxColumn.Name = "pretVanzareDataGridViewTextBoxColumn";
            this.pretVanzareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrBonConsumDataGridViewTextBoxColumn
            // 
            this.nrBonConsumDataGridViewTextBoxColumn.DataPropertyName = "NrBonConsum";
            this.nrBonConsumDataGridViewTextBoxColumn.HeaderText = "Nr Bon";
            this.nrBonConsumDataGridViewTextBoxColumn.Name = "nrBonConsumDataGridViewTextBoxColumn";
            this.nrBonConsumDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrBonConsumDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataBonConsumDataGridViewTextBoxColumn
            // 
            this.dataBonConsumDataGridViewTextBoxColumn.DataPropertyName = "DataBonConsum";
            this.dataBonConsumDataGridViewTextBoxColumn.HeaderText = "Data Bon";
            this.dataBonConsumDataGridViewTextBoxColumn.Name = "dataBonConsumDataGridViewTextBoxColumn";
            this.dataBonConsumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dClientDataGridViewTextBoxColumn
            // 
            this.dClientDataGridViewTextBoxColumn.DataPropertyName = "DClient";
            this.dClientDataGridViewTextBoxColumn.HeaderText = "Nume Client";
            this.dClientDataGridViewTextBoxColumn.Name = "dClientDataGridViewTextBoxColumn";
            this.dClientDataGridViewTextBoxColumn.ReadOnly = true;
            this.dClientDataGridViewTextBoxColumn.Width = 120;
            // 
            // dLucrareDataGridViewTextBoxColumn
            // 
            this.dLucrareDataGridViewTextBoxColumn.DataPropertyName = "DLucrare";
            this.dLucrareDataGridViewTextBoxColumn.HeaderText = "Denumire Lucrare";
            this.dLucrareDataGridViewTextBoxColumn.Name = "dLucrareDataGridViewTextBoxColumn";
            this.dLucrareDataGridViewTextBoxColumn.ReadOnly = true;
            this.dLucrareDataGridViewTextBoxColumn.Width = 160;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BonConsumVizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 481);
            this.Controls.Add(this.btnGrafic);
            this.Controls.Add(this.btnRaportConsumuri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStergeBon);
            this.Controls.Add(this.btnModificaBon);
            this.Controls.Add(this.btnBonNou);
            this.Controls.Add(this.txtIdBonConsum);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BonConsumVizForm";
            this.Text = "BonConsumVizForm";
            this.Load += new System.EventHandler(this.BonConsumVizForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonuriConsumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonuriConsumContinutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtIdBonConsum;
        private System.Windows.Forms.Button btnBonNou;
        private System.Windows.Forms.Button btnModificaBon;
        private System.Windows.Forms.Button btnStergeBon;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource bonuriConsumContinutBindingSource;
        private DataSet1TableAdapters.BonuriConsumContinutTableAdapter bonuriConsumContinutTableAdapter;
        private System.Windows.Forms.BindingSource bonuriConsumBindingSource;
        private DataSet1TableAdapters.BonuriConsumTableAdapter bonuriConsumTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRaportConsumuri;
        private System.Windows.Forms.Button btnGrafic;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrBonConsumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataBonConsumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLucrareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrCrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPiesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretVanzareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
    }
}