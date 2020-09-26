namespace HelpDesk.IHM
{
    partial class Form_DetailTicketVisit
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_DetailTicket = new System.Windows.Forms.DataGridView();
            this.button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetailTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voici le détail du ticket que vous avez sélectionné.";
            // 
            // dataGridView_DetailTicket
            // 
            this.dataGridView_DetailTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DetailTicket.Location = new System.Drawing.Point(8, 53);
            this.dataGridView_DetailTicket.Name = "dataGridView_DetailTicket";
            this.dataGridView_DetailTicket.RowHeadersWidth = 51;
            this.dataGridView_DetailTicket.RowTemplate.Height = 24;
            this.dataGridView_DetailTicket.Size = new System.Drawing.Size(1252, 223);
            this.dataGridView_DetailTicket.TabIndex = 1;
            // 
            // button_Close
            // 
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(1153, 301);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(107, 37);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "Fermer";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Form_DetailTicketVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 359);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.dataGridView_DetailTicket);
            this.Controls.Add(this.label1);
            this.Name = "Form_DetailTicketVisit";
            this.Text = "GSB - HelpDesk - Détail d\'un ticket";
            this.Load += new System.EventHandler(this.Form_DetailTicketVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DetailTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_DetailTicket;
        private System.Windows.Forms.Button button_Close;
    }
}