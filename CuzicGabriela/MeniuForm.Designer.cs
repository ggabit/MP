
namespace CuzicGabriela
{
    partial class MeniuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lucrariToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.evenimenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.achizitionareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arhivaStocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipuriResursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculResursaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtUtilizator = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblUtilizator = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agentiToolStripMenuItem,
            this.evenimenteToolStripMenuItem,
            this.arhivaStocToolStripMenuItem,
            this.tipuriResursaToolStripMenuItem,
            this.CalculResursaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agentiToolStripMenuItem
            // 
            this.agentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.furnizoriToolStripMenuItem,
            this.clientiToolStripMenuItem,
            this.lucrariToolStripMenuItem1});
            this.agentiToolStripMenuItem.Name = "agentiToolStripMenuItem";
            this.agentiToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.agentiToolStripMenuItem.Text = "Agenti";
            // 
            // furnizoriToolStripMenuItem
            // 
            this.furnizoriToolStripMenuItem.Name = "furnizoriToolStripMenuItem";
            this.furnizoriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.furnizoriToolStripMenuItem.Text = "Furnizori";
            this.furnizoriToolStripMenuItem.Click += new System.EventHandler(this.furnizoriToolStripMenuItem_Click);
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientiToolStripMenuItem.Text = "Clienti";
            this.clientiToolStripMenuItem.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click);
            // 
            // lucrariToolStripMenuItem1
            // 
            this.lucrariToolStripMenuItem1.Name = "lucrariToolStripMenuItem1";
            this.lucrariToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.lucrariToolStripMenuItem1.Text = "Lucrari";
            this.lucrariToolStripMenuItem1.Click += new System.EventHandler(this.lucrariToolStripMenuItem1_Click);
            // 
            // evenimenteToolStripMenuItem
            // 
            this.evenimenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.achizitionareToolStripMenuItem,
            this.consumToolStripMenuItem});
            this.evenimenteToolStripMenuItem.Name = "evenimenteToolStripMenuItem";
            this.evenimenteToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.evenimenteToolStripMenuItem.Text = "Evenimente";
            // 
            // achizitionareToolStripMenuItem
            // 
            this.achizitionareToolStripMenuItem.Name = "achizitionareToolStripMenuItem";
            this.achizitionareToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.achizitionareToolStripMenuItem.Text = "Aprovizionare";
            this.achizitionareToolStripMenuItem.Click += new System.EventHandler(this.aprovizionareToolStripMenuItem_Click);
            // 
            // consumToolStripMenuItem
            // 
            this.consumToolStripMenuItem.Name = "consumToolStripMenuItem";
            this.consumToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.consumToolStripMenuItem.Text = "Consum";
            this.consumToolStripMenuItem.Click += new System.EventHandler(this.consumToolStripMenuItem_Click);
            // 
            // arhivaStocToolStripMenuItem
            // 
            this.arhivaStocToolStripMenuItem.Name = "arhivaStocToolStripMenuItem";
            this.arhivaStocToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.arhivaStocToolStripMenuItem.Text = "Arhiva Stoc";
            this.arhivaStocToolStripMenuItem.Click += new System.EventHandler(this.arhivaStocToolStripMenuItem_Click);
            // 
            // tipuriResursaToolStripMenuItem
            // 
            this.tipuriResursaToolStripMenuItem.Name = "tipuriResursaToolStripMenuItem";
            this.tipuriResursaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.tipuriResursaToolStripMenuItem.Text = "Piese auto";
            this.tipuriResursaToolStripMenuItem.Click += new System.EventHandler(this.tipuriResursaToolStripMenuItem_Click);
            // 
            // CalculResursaToolStripMenuItem
            // 
            this.CalculResursaToolStripMenuItem.Name = "CalculResursaToolStripMenuItem";
            this.CalculResursaToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.CalculResursaToolStripMenuItem.Text = "Evaluare Resursa";
            this.CalculResursaToolStripMenuItem.Click += new System.EventHandler(this.CalculResursaToolStripMenuItem_Click);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(129, 90);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(132, 13);
            this.lblAutor.TabIndex = 9;
            this.lblAutor.Text = "Autor: Cuzic Gabriela info3";
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlu.Location = new System.Drawing.Point(96, 57);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(408, 17);
            this.lblTitlu.TabIndex = 8;
            this.lblTitlu.Text = "Aplicatie pentru evidenta pieselor dintr-un service auto";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(196, 188);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtUtilizator
            // 
            this.txtUtilizator.Location = new System.Drawing.Point(196, 114);
            this.txtUtilizator.Name = "txtUtilizator";
            this.txtUtilizator.Size = new System.Drawing.Size(100, 20);
            this.txtUtilizator.TabIndex = 13;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(196, 152);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(100, 20);
            this.txtParola.TabIndex = 12;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(132, 152);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(37, 13);
            this.lblParola.TabIndex = 11;
            this.lblParola.Text = "Parola";
            // 
            // lblUtilizator
            // 
            this.lblUtilizator.AutoSize = true;
            this.lblUtilizator.Location = new System.Drawing.Point(129, 114);
            this.lblUtilizator.Name = "lblUtilizator";
            this.lblUtilizator.Size = new System.Drawing.Size(47, 13);
            this.lblUtilizator.TabIndex = 10;
            this.lblUtilizator.Text = "Utilizator";
            // 
            // MeniuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 255);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtUtilizator);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblUtilizator);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MeniuForm";
            this.Text = "MeniuForm";
            this.Load += new System.EventHandler(this.MeniuForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evenimenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem achizitionareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipuriResursaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arhivaStocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalculResursaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lucrariToolStripMenuItem1;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtUtilizator;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblUtilizator;
    }
}