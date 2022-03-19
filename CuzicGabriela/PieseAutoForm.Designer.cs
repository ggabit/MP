
namespace CuzicGabriela
{
    partial class PieseAutoForm
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
            this.lblOp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbUM = new System.Windows.Forms.ComboBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPiesaAuto = new System.Windows.Forms.TextBox();
            this.txtDPiesaAuto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pieseAutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CuzicGabriela.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.pieseAutoTableAdapter = new CuzicGabriela.DataSet1TableAdapters.PieseAutoTableAdapter();
            this.btnRaportPieseAuto = new System.Windows.Forms.Button();
            this.dPiesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieseAutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(502, 158);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(60, 24);
            this.lblOp.TabIndex = 37;
            this.lblOp.Text = "label5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbUM);
            this.panel1.Controls.Add(this.txtPret);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtIdPiesaAuto);
            this.panel1.Controls.Add(this.txtDPiesaAuto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(505, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 169);
            this.panel1.TabIndex = 36;
            // 
            // cmbUM
            // 
            this.cmbUM.FormattingEnabled = true;
            this.cmbUM.Items.AddRange(new object[] {
            "",
            "l",
            "Buc",
            "Set"});
            this.cmbUM.Location = new System.Drawing.Point(114, 64);
            this.cmbUM.Name = "cmbUM";
            this.cmbUM.Size = new System.Drawing.Size(100, 21);
            this.cmbUM.TabIndex = 38;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(114, 101);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(100, 20);
            this.txtPret.TabIndex = 7;
            this.txtPret.Leave += new System.EventHandler(this.txtPret_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "UM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pret";
            // 
            // txtIdPiesaAuto
            // 
            this.txtIdPiesaAuto.Location = new System.Drawing.Point(114, 137);
            this.txtIdPiesaAuto.Name = "txtIdPiesaAuto";
            this.txtIdPiesaAuto.Size = new System.Drawing.Size(100, 20);
            this.txtIdPiesaAuto.TabIndex = 3;
            // 
            // txtDPiesaAuto
            // 
            this.txtDPiesaAuto.Location = new System.Drawing.Point(114, 28);
            this.txtDPiesaAuto.Name = "txtDPiesaAuto";
            this.txtDPiesaAuto.Size = new System.Drawing.Size(166, 20);
            this.txtDPiesaAuto.TabIndex = 2;
            this.txtDPiesaAuto.Leave += new System.EventHandler(this.txtDPiesaAuto_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Denumire";
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(231, 73);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(75, 23);
            this.btnStergere.TabIndex = 35;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(49, 73);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 34;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(521, 73);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 33;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(419, 73);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(75, 23);
            this.btnSalvare.TabIndex = 32;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(139, 73);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(75, 23);
            this.btnActualizare.TabIndex = 31;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dPiesaDataGridViewTextBoxColumn,
            this.uMDataGridViewTextBoxColumn,
            this.pretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pieseAutoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(385, 204);
            this.dataGridView1.TabIndex = 30;
            // 
            // pieseAutoBindingSource
            // 
            this.pieseAutoBindingSource.DataMember = "PieseAuto";
            this.pieseAutoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Piese Auto";
            // 
            // pieseAutoTableAdapter
            // 
            this.pieseAutoTableAdapter.ClearBeforeFill = true;
            // 
            // btnRaportPieseAuto
            // 
            this.btnRaportPieseAuto.Location = new System.Drawing.Point(200, 158);
            this.btnRaportPieseAuto.Name = "btnRaportPieseAuto";
            this.btnRaportPieseAuto.Size = new System.Drawing.Size(117, 23);
            this.btnRaportPieseAuto.TabIndex = 38;
            this.btnRaportPieseAuto.Text = "Raport Piese Auto";
            this.btnRaportPieseAuto.UseVisualStyleBackColor = true;
            this.btnRaportPieseAuto.Click += new System.EventHandler(this.btnRaportPieseAuto_Click);
            // 
            // dPiesaDataGridViewTextBoxColumn
            // 
            this.dPiesaDataGridViewTextBoxColumn.DataPropertyName = "DPiesa";
            this.dPiesaDataGridViewTextBoxColumn.HeaderText = "Denumire Piesa";
            this.dPiesaDataGridViewTextBoxColumn.Name = "dPiesaDataGridViewTextBoxColumn";
            this.dPiesaDataGridViewTextBoxColumn.Width = 150;
            // 
            // uMDataGridViewTextBoxColumn
            // 
            this.uMDataGridViewTextBoxColumn.DataPropertyName = "UM";
            this.uMDataGridViewTextBoxColumn.HeaderText = "UM";
            this.uMDataGridViewTextBoxColumn.Name = "uMDataGridViewTextBoxColumn";
            this.uMDataGridViewTextBoxColumn.Width = 80;
            // 
            // pretDataGridViewTextBoxColumn
            // 
            this.pretDataGridViewTextBoxColumn.DataPropertyName = "Pret";
            this.pretDataGridViewTextBoxColumn.HeaderText = "Pret";
            this.pretDataGridViewTextBoxColumn.Name = "pretDataGridViewTextBoxColumn";
            this.pretDataGridViewTextBoxColumn.Width = 80;
            // 
            // PieseAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 450);
            this.Controls.Add(this.btnRaportPieseAuto);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "PieseAutoForm";
            this.Text = "PieseAutoForm";
            this.Load += new System.EventHandler(this.PieseAutoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieseAutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdPiesaAuto;
        private System.Windows.Forms.TextBox txtDPiesaAuto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pieseAutoBindingSource;
        private DataSet1TableAdapters.PieseAutoTableAdapter pieseAutoTableAdapter;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUM;
        private System.Windows.Forms.Button btnRaportPieseAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPiesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pretDataGridViewTextBoxColumn;
    }
}