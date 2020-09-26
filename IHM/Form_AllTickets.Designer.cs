namespace HelpDesk.IHM
{
    partial class Form_AllTickets
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
            this.dataGridView_AllTickets = new System.Windows.Forms.DataGridView();
            this.button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voici la liste de tous les tickets enregistrés.";
            // 
            // dataGridView_AllTickets
            // 
            this.dataGridView_AllTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AllTickets.Location = new System.Drawing.Point(16, 64);
            this.dataGridView_AllTickets.Name = "dataGridView_AllTickets";
            this.dataGridView_AllTickets.RowHeadersWidth = 51;
            this.dataGridView_AllTickets.RowTemplate.Height = 24;
            this.dataGridView_AllTickets.Size = new System.Drawing.Size(1232, 313);
            this.dataGridView_AllTickets.TabIndex = 1;
            this.dataGridView_AllTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AllTickets_CellContentClick);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(1143, 404);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(104, 34);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "Fermer";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Form_AllTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 450);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.dataGridView_AllTickets);
            this.Controls.Add(this.label1);
            this.Name = "Form_AllTickets";
            this.Text = "GSB - HelpDesk - Liste de tous les tickets";
            this.Load += new System.EventHandler(this.Form_AllTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AllTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_AllTickets;
        private System.Windows.Forms.Button button_Close;
    }
}