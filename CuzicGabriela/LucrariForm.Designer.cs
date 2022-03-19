
namespace CuzicGabriela
{
    partial class LucrariForm
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
            this.txtIdLucrare = new System.Windows.Forms.TextBox();
            this.txtDLucrare = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dLucrareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lucrariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CuzicGabriela.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.lucrariTableAdapter = new CuzicGabriela.DataSet1TableAdapters.LucrariTableAdapter();
            this.btnRaportLucrari = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucrariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(460, 157);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(60, 24);
            this.lblOp.TabIndex = 28;
            this.lblOp.Text = "label5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIdLucrare);
            this.panel1.Controls.Add(this.txtDLucrare);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(419, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 169);
            this.panel1.TabIndex = 27;
            // 
            // txtIdLucrare
            // 
            this.txtIdLucrare.Location = new System.Drawing.Point(114, 74);
            this.txtIdLucrare.Name = "txtIdLucrare";
            this.txtIdLucrare.Size = new System.Drawing.Size(100, 20);
            this.txtIdLucrare.TabIndex = 3;
            // 
            // txtDLucrare
            // 
            this.txtDLucrare.Location = new System.Drawing.Point(114, 28);
            this.txtDLucrare.Name = "txtDLucrare";
            this.txtDLucrare.Size = new System.Drawing.Size(174, 20);
            this.txtDLucrare.TabIndex = 2;
            this.txtDLucrare.Leave += new System.EventHandler(this.txtDLucrare_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 77);
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
            this.btnStergere.TabIndex = 26;
            this.btnStergere.Text = "Stergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(49, 73);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 25;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(521, 73);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(75, 23);
            this.btnRenuntare.TabIndex = 24;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(419, 73);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(75, 23);
            this.btnSalvare.TabIndex = 23;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(139, 73);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(75, 23);
            this.btnActualizare.TabIndex = 22;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dLucrareDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lucrariBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 208);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(304, 169);
            this.dataGridView1.TabIndex = 21;
            // 
            // dLucrareDataGridViewTextBoxColumn
            // 
            this.dLucrareDataGridViewTextBoxColumn.DataPropertyName = "DLucrare";
            this.dLucrareDataGridViewTextBoxColumn.HeaderText = "Denumire Lucrare";
            this.dLucrareDataGridViewTextBoxColumn.Name = "dLucrareDataGridViewTextBoxColumn";
            this.dLucrareDataGridViewTextBoxColumn.Width = 200;
            // 
            // lucrariBindingSource
            // 
            this.lucrariBindingSource.DataMember = "Lucrari";
            this.lucrariBindingSource.DataSource = this.dataSet1;
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
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lucrari";
            // 
            // lucrariTableAdapter
            // 
            this.lucrariTableAdapter.ClearBeforeFill = true;
            // 
            // btnRaportLucrari
            // 
            this.btnRaportLucrari.Location = new System.Drawing.Point(159, 158);
            this.btnRaportLucrari.Name = "btnRaportLucrari";
            this.btnRaportLucrari.Size = new System.Drawing.Size(102, 23);
            this.btnRaportLucrari.TabIndex = 29;
            this.btnRaportLucrari.Text = "Raport Lucrari";
            this.btnRaportLucrari.UseVisualStyleBackColor = true;
            this.btnRaportLucrari.Click += new System.EventHandler(this.btnRaportLucrari_Click);
            // 
            // LucrariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRaportLucrari);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "LucrariForm";
            this.Text = "LucrariForm";
            this.Load += new System.EventHandler(this.LucrariForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lucrariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdLucrare;
        private System.Windows.Forms.TextBox txtDLucrare;
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
        private System.Windows.Forms.BindingSource lucrariBindingSource;
        private DataSet1TableAdapters.LucrariTableAdapter lucrariTableAdapter;
        private System.Windows.Forms.Button btnRaportLucrari;
        private System.Windows.Forms.DataGridViewTextBoxColumn dLucrareDataGridViewTextBoxColumn;
    }
}