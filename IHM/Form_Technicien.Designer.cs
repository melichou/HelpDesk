namespace HelpDesk.IHM
{
    partial class Form_Technicien
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
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterToutLesTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLesTicketsOuvertsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.ticketToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // ticketToolStripMenuItem
            // 
            this.ticketToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterToutLesTicketsToolStripMenuItem,
            this.consulterLesTicketsOuvertsToolStripMenuItem});
            this.ticketToolStripMenuItem.Name = "ticketToolStripMenuItem";
            this.ticketToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.ticketToolStripMenuItem.Text = "Tickets";
            this.ticketToolStripMenuItem.Click += new System.EventHandler(this.ticketToolStripMenuItem_Click);
            // 
            // consulterToutLesTicketsToolStripMenuItem
            // 
            this.consulterToutLesTicketsToolStripMenuItem.Name = "consulterToutLesTicketsToolStripMenuItem";
            this.consulterToutLesTicketsToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.consulterToutLesTicketsToolStripMenuItem.Text = "Consulter tout les tickets";
            this.consulterToutLesTicketsToolStripMenuItem.Click += new System.EventHandler(this.consulterToutLesTicketsToolStripMenuItem_Click);
            // 
            // consulterLesTicketsOuvertsToolStripMenuItem
            // 
            this.consulterLesTicketsOuvertsToolStripMenuItem.Name = "consulterLesTicketsOuvertsToolStripMenuItem";
            this.consulterLesTicketsOuvertsToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.consulterLesTicketsOuvertsToolStripMenuItem.Text = "Consulter les tickets ouverts";
            this.consulterLesTicketsOuvertsToolStripMenuItem.Click += new System.EventHandler(this.consulterLesTicketsOuvertsToolStripMenuItem_Click);
            // 
            // Form_Technicien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 507);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Technicien";
            this.Text = "GSB - HelpDesk";
            this.Load += new System.EventHandler(this.Form_Technicien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterToutLesTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLesTicketsOuvertsToolStripMenuItem;
    }
}