namespace HelpDesk
{
    partial class Form_AjoutTicket
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
            this.label_Niveau = new System.Windows.Forms.Label();
            this.listBox_Niveau = new System.Windows.Forms.ListBox();
            this.label_Demande = new System.Windows.Forms.Label();
            this.richTextBox_Demande = new System.Windows.Forms.RichTextBox();
            this.button_Annuler = new System.Windows.Forms.Button();
            this.button_Valider = new System.Windows.Forms.Button();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Description2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Niveau
            // 
            this.label_Niveau.AutoSize = true;
            this.label_Niveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Niveau.Location = new System.Drawing.Point(12, 122);
            this.label_Niveau.Name = "label_Niveau";
            this.label_Niveau.Size = new System.Drawing.Size(70, 20);
            this.label_Niveau.TabIndex = 0;
            this.label_Niveau.Text = "Niveau :";
            // 
            // listBox_Niveau
            // 
            this.listBox_Niveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Niveau.FormattingEnabled = true;
            this.listBox_Niveau.ItemHeight = 20;
            this.listBox_Niveau.Items.AddRange(new object[] {
            "Demande basique",
            "Intervention à distance",
            "Intervention matérielle",
            "Adaptation du site Web"});
            this.listBox_Niveau.Location = new System.Drawing.Point(148, 122);
            this.listBox_Niveau.Name = "listBox_Niveau";
            this.listBox_Niveau.Size = new System.Drawing.Size(383, 44);
            this.listBox_Niveau.TabIndex = 1;
            this.listBox_Niveau.SelectedIndexChanged += new System.EventHandler(this.listBox_Niveau_SelectedIndexChanged);
            // 
            // label_Demande
            // 
            this.label_Demande.AutoSize = true;
            this.label_Demande.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Demande.Location = new System.Drawing.Point(12, 212);
            this.label_Demande.Name = "label_Demande";
            this.label_Demande.Size = new System.Drawing.Size(91, 20);
            this.label_Demande.TabIndex = 2;
            this.label_Demande.Text = "Demande :";
            // 
            // richTextBox_Demande
            // 
            this.richTextBox_Demande.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Demande.Location = new System.Drawing.Point(148, 212);
            this.richTextBox_Demande.Name = "richTextBox_Demande";
            this.richTextBox_Demande.Size = new System.Drawing.Size(550, 193);
            this.richTextBox_Demande.TabIndex = 3;
            this.richTextBox_Demande.Text = "";
            // 
            // button_Annuler
            // 
            this.button_Annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Annuler.Location = new System.Drawing.Point(430, 451);
            this.button_Annuler.Name = "button_Annuler";
            this.button_Annuler.Size = new System.Drawing.Size(101, 30);
            this.button_Annuler.TabIndex = 4;
            this.button_Annuler.Text = "Annuler";
            this.button_Annuler.UseVisualStyleBackColor = true;
            this.button_Annuler.Click += new System.EventHandler(this.button_Annuler_Click);
            // 
            // button_Valider
            // 
            this.button_Valider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Valider.Location = new System.Drawing.Point(597, 451);
            this.button_Valider.Name = "button_Valider";
            this.button_Valider.Size = new System.Drawing.Size(101, 30);
            this.button_Valider.TabIndex = 5;
            this.button_Valider.Text = "Valider";
            this.button_Valider.UseVisualStyleBackColor = true;
            this.button_Valider.Click += new System.EventHandler(this.button_Valider_Click);
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.Location = new System.Drawing.Point(12, 35);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(203, 20);
            this.label_Description.TabIndex = 6;
            this.label_Description.Text = "Vous allez créer un ticket.";
            // 
            // label_Description2
            // 
            this.label_Description2.AutoSize = true;
            this.label_Description2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description2.Location = new System.Drawing.Point(13, 71);
            this.label_Description2.Name = "label_Description2";
            this.label_Description2.Size = new System.Drawing.Size(430, 20);
            this.label_Description2.TabIndex = 7;
            this.label_Description2.Text = "Veuillez remplir les champs ci- dessous comme indiqué.";
            // 
            // Form_AjoutTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 501);
            this.Controls.Add(this.label_Description2);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.button_Valider);
            this.Controls.Add(this.button_Annuler);
            this.Controls.Add(this.richTextBox_Demande);
            this.Controls.Add(this.label_Demande);
            this.Controls.Add(this.listBox_Niveau);
            this.Controls.Add(this.label_Niveau);
            this.Name = "Form_AjoutTicket";
            this.Text = "GSB - Help Desk - Ajout ticket";
            this.Load += new System.EventHandler(this.Form_AjoutTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Niveau;
        private System.Windows.Forms.ListBox listBox_Niveau;
        private System.Windows.Forms.Label label_Demande;
        private System.Windows.Forms.RichTextBox richTextBox_Demande;
        private System.Windows.Forms.Button button_Annuler;
        private System.Windows.Forms.Button button_Valider;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Description2;
    }
}