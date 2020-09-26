namespace HelpDesk.IHM
{
    partial class Form_TicketsOpen
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
            this.dataGridView_TicketsOpen = new System.Windows.Forms.DataGridView();
            this.button_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TicketsOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voici la liste des tickets ouverts. Cliquez sur un ticket pour l\'éditer.";
            // 
            // dataGridView_TicketsOpen
            // 
            this.dataGridView_TicketsOpen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TicketsOpen.Location = new System.Drawing.Point(13, 49);
            this.dataGridView_TicketsOpen.Name = "dataGridView_TicketsOpen";
            this.dataGridView_TicketsOpen.RowHeadersWidth = 51;
            this.dataGridView_TicketsOpen.RowTemplate.Height = 24;
            this.dataGridView_TicketsOpen.Size = new System.Drawing.Size(570, 242);
            this.dataGridView_TicketsOpen.TabIndex = 1;
            this.dataGridView_TicketsOpen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_TicketsOpen_CellContentClick);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(515, 331);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(101, 37);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "Fermer";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_TicketsOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 380);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.dataGridView_TicketsOpen);
            this.Controls.Add(this.label1);
            this.Name = "Form_TicketsOpen";
            this.Text = "GSB - HelpDesk - Liste des tickets ouverts";
            this.Load += new System.EventHandler(this.Form_TicketsOpen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TicketsOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_TicketsOpen;
        private System.Windows.Forms.Button button_Close;
    }
}