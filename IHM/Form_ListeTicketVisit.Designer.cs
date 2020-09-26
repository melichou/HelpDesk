namespace HelpDesk.IHM
{
    partial class Form_ListeTicketVisit
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
            this.dataGridView_Visiteurs = new System.Windows.Forms.DataGridView();
            this.label_ListeTicket = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Visiteurs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Visiteurs
            // 
            this.dataGridView_Visiteurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Visiteurs.Location = new System.Drawing.Point(12, 97);
            this.dataGridView_Visiteurs.Name = "dataGridView_Visiteurs";
            this.dataGridView_Visiteurs.RowHeadersWidth = 51;
            this.dataGridView_Visiteurs.RowTemplate.Height = 24;
            this.dataGridView_Visiteurs.Size = new System.Drawing.Size(841, 261);
            this.dataGridView_Visiteurs.TabIndex = 0;
            this.dataGridView_Visiteurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Visiteurs_CellContentClick);
            // 
            // label_ListeTicket
            // 
            this.label_ListeTicket.AutoSize = true;
            this.label_ListeTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ListeTicket.Location = new System.Drawing.Point(13, 40);
            this.label_ListeTicket.Name = "label_ListeTicket";
            this.label_ListeTicket.Size = new System.Drawing.Size(212, 20);
            this.label_ListeTicket.TabIndex = 1;
            this.label_ListeTicket.Text = "Voici la liste de vos tickets.";
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(723, 410);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(104, 36);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "Fermer";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Form_ListeTicketVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 458);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.label_ListeTicket);
            this.Controls.Add(this.dataGridView_Visiteurs);
            this.Name = "Form_ListeTicketVisit";
            this.Text = "GSB - HelpDesk - Liste des tickets";
            this.Load += new System.EventHandler(this.Form_ListeTicketVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Visiteurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Visiteurs;
        private System.Windows.Forms.Label label_ListeTicket;
        private System.Windows.Forms.Button button_Close;
    }
}