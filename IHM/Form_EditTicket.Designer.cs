namespace HelpDesk.IHM
{
    partial class Form_EditTicket
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
            this.label_Description = new System.Windows.Forms.Label();
            this.label_num = new System.Windows.Forms.Label();
            this.textBox_Num = new System.Windows.Forms.TextBox();
            this.label_niveau = new System.Windows.Forms.Label();
            this.textBox_Niveau = new System.Windows.Forms.TextBox();
            this.label_demande = new System.Windows.Forms.Label();
            this.richTextBox_Demande = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DtDemande = new System.Windows.Forms.TextBox();
            this.label_DateInter = new System.Windows.Forms.Label();
            this.dTP_DateInter = new System.Windows.Forms.DateTimePicker();
            this.label_Reponse = new System.Windows.Forms.Label();
            this.richTextBox_Response = new System.Windows.Forms.RichTextBox();
            this.label_Duree = new System.Windows.Forms.Label();
            this.textBox_Duree = new System.Windows.Forms.TextBox();
            this.listBox_TypeDuree = new System.Windows.Forms.ListBox();
            this.label_DureeEn = new System.Windows.Forms.Label();
            this.label_Etat = new System.Windows.Forms.Label();
            this.listBox_Etat = new System.Windows.Forms.ListBox();
            this.button_Annuler = new System.Windows.Forms.Button();
            this.button_Enregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.Location = new System.Drawing.Point(13, 24);
            this.label_Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(766, 20);
            this.label_Description.TabIndex = 0;
            this.label_Description.Text = "Vous allez éditer ce ticket. Veuillez remplir tout les champs possédant le signe " +
    "* qui sont obligatoires.";
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Location = new System.Drawing.Point(21, 106);
            this.label_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(78, 20);
            this.label_num.TabIndex = 1;
            this.label_num.Text = "Numéro :";
            // 
            // textBox_Num
            // 
            this.textBox_Num.Location = new System.Drawing.Point(170, 103);
            this.textBox_Num.Name = "textBox_Num";
            this.textBox_Num.ReadOnly = true;
            this.textBox_Num.Size = new System.Drawing.Size(83, 27);
            this.textBox_Num.TabIndex = 2;
            // 
            // label_niveau
            // 
            this.label_niveau.AutoSize = true;
            this.label_niveau.Location = new System.Drawing.Point(21, 183);
            this.label_niveau.Name = "label_niveau";
            this.label_niveau.Size = new System.Drawing.Size(70, 20);
            this.label_niveau.TabIndex = 3;
            this.label_niveau.Text = "Niveau :";
            // 
            // textBox_Niveau
            // 
            this.textBox_Niveau.Location = new System.Drawing.Point(170, 180);
            this.textBox_Niveau.Name = "textBox_Niveau";
            this.textBox_Niveau.ReadOnly = true;
            this.textBox_Niveau.Size = new System.Drawing.Size(203, 27);
            this.textBox_Niveau.TabIndex = 4;
            // 
            // label_demande
            // 
            this.label_demande.AutoSize = true;
            this.label_demande.Location = new System.Drawing.Point(21, 258);
            this.label_demande.Name = "label_demande";
            this.label_demande.Size = new System.Drawing.Size(91, 20);
            this.label_demande.TabIndex = 5;
            this.label_demande.Text = "Demande :";
            // 
            // richTextBox_Demande
            // 
            this.richTextBox_Demande.Location = new System.Drawing.Point(170, 255);
            this.richTextBox_Demande.Name = "richTextBox_Demande";
            this.richTextBox_Demande.ReadOnly = true;
            this.richTextBox_Demande.Size = new System.Drawing.Size(345, 179);
            this.richTextBox_Demande.TabIndex = 6;
            this.richTextBox_Demande.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Demandé le :";
            // 
            // textBox_DtDemande
            // 
            this.textBox_DtDemande.Location = new System.Drawing.Point(170, 479);
            this.textBox_DtDemande.Name = "textBox_DtDemande";
            this.textBox_DtDemande.ReadOnly = true;
            this.textBox_DtDemande.Size = new System.Drawing.Size(160, 27);
            this.textBox_DtDemande.TabIndex = 8;
            // 
            // label_DateInter
            // 
            this.label_DateInter.AutoSize = true;
            this.label_DateInter.Location = new System.Drawing.Point(564, 106);
            this.label_DateInter.Name = "label_DateInter";
            this.label_DateInter.Size = new System.Drawing.Size(188, 20);
            this.label_DateInter.TabIndex = 9;
            this.label_DateInter.Text = "Date de l\'intervention * :";
            // 
            // dTP_DateInter
            // 
            this.dTP_DateInter.CustomFormat = "";
            this.dTP_DateInter.Location = new System.Drawing.Point(818, 103);
            this.dTP_DateInter.MinDate = new System.DateTime(2017, 3, 1, 0, 0, 0, 0);
            this.dTP_DateInter.Name = "dTP_DateInter";
            this.dTP_DateInter.Size = new System.Drawing.Size(280, 27);
            this.dTP_DateInter.TabIndex = 10;
            this.dTP_DateInter.Value = new System.DateTime(2020, 9, 29, 13, 28, 11, 0);
            this.dTP_DateInter.ValueChanged += new System.EventHandler(this.dTP_DateInter_ValueChanged);
            // 
            // label_Reponse
            // 
            this.label_Reponse.AutoSize = true;
            this.label_Reponse.Location = new System.Drawing.Point(656, 183);
            this.label_Reponse.Name = "label_Reponse";
            this.label_Reponse.Size = new System.Drawing.Size(96, 20);
            this.label_Reponse.TabIndex = 11;
            this.label_Reponse.Text = "Réponse * :";
            // 
            // richTextBox_Response
            // 
            this.richTextBox_Response.Location = new System.Drawing.Point(818, 180);
            this.richTextBox_Response.Name = "richTextBox_Response";
            this.richTextBox_Response.Size = new System.Drawing.Size(345, 179);
            this.richTextBox_Response.TabIndex = 12;
            this.richTextBox_Response.Text = "";
            // 
            // label_Duree
            // 
            this.label_Duree.AutoSize = true;
            this.label_Duree.Location = new System.Drawing.Point(676, 414);
            this.label_Duree.Name = "label_Duree";
            this.label_Duree.Size = new System.Drawing.Size(76, 20);
            this.label_Duree.TabIndex = 13;
            this.label_Duree.Text = "Durée * :";
            // 
            // textBox_Duree
            // 
            this.textBox_Duree.Location = new System.Drawing.Point(818, 411);
            this.textBox_Duree.Name = "textBox_Duree";
            this.textBox_Duree.Size = new System.Drawing.Size(123, 27);
            this.textBox_Duree.TabIndex = 14;
            // 
            // listBox_TypeDuree
            // 
            this.listBox_TypeDuree.FormattingEnabled = true;
            this.listBox_TypeDuree.ItemHeight = 20;
            this.listBox_TypeDuree.Items.AddRange(new object[] {
            "Heures",
            "Jours",
            "Mois"});
            this.listBox_TypeDuree.Location = new System.Drawing.Point(1043, 411);
            this.listBox_TypeDuree.Name = "listBox_TypeDuree";
            this.listBox_TypeDuree.Size = new System.Drawing.Size(120, 24);
            this.listBox_TypeDuree.TabIndex = 15;
            // 
            // label_DureeEn
            // 
            this.label_DureeEn.AutoSize = true;
            this.label_DureeEn.Location = new System.Drawing.Point(964, 414);
            this.label_DureeEn.Name = "label_DureeEn";
            this.label_DureeEn.Size = new System.Drawing.Size(50, 20);
            this.label_DureeEn.TabIndex = 16;
            this.label_DureeEn.Text = "En * :";
            // 
            // label_Etat
            // 
            this.label_Etat.AutoSize = true;
            this.label_Etat.Location = new System.Drawing.Point(687, 482);
            this.label_Etat.Name = "label_Etat";
            this.label_Etat.Size = new System.Drawing.Size(65, 20);
            this.label_Etat.TabIndex = 17;
            this.label_Etat.Text = "Etat * : ";
            // 
            // listBox_Etat
            // 
            this.listBox_Etat.FormattingEnabled = true;
            this.listBox_Etat.ItemHeight = 20;
            this.listBox_Etat.Items.AddRange(new object[] {
            "Ouvert",
            "En cours",
            "Fermé"});
            this.listBox_Etat.Location = new System.Drawing.Point(818, 482);
            this.listBox_Etat.Name = "listBox_Etat";
            this.listBox_Etat.Size = new System.Drawing.Size(345, 24);
            this.listBox_Etat.TabIndex = 18;
            // 
            // button_Annuler
            // 
            this.button_Annuler.Location = new System.Drawing.Point(910, 578);
            this.button_Annuler.Name = "button_Annuler";
            this.button_Annuler.Size = new System.Drawing.Size(104, 36);
            this.button_Annuler.TabIndex = 19;
            this.button_Annuler.Text = "Annuler";
            this.button_Annuler.UseVisualStyleBackColor = true;
            this.button_Annuler.Click += new System.EventHandler(this.button_Annuler_Click);
            // 
            // button_Enregistrer
            // 
            this.button_Enregistrer.Location = new System.Drawing.Point(1059, 578);
            this.button_Enregistrer.Name = "button_Enregistrer";
            this.button_Enregistrer.Size = new System.Drawing.Size(104, 36);
            this.button_Enregistrer.TabIndex = 20;
            this.button_Enregistrer.Text = "Enregistrer";
            this.button_Enregistrer.UseVisualStyleBackColor = true;
            this.button_Enregistrer.Click += new System.EventHandler(this.button_Enregistrer_Click);
            // 
            // Form_EditTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 642);
            this.Controls.Add(this.button_Enregistrer);
            this.Controls.Add(this.button_Annuler);
            this.Controls.Add(this.listBox_Etat);
            this.Controls.Add(this.label_Etat);
            this.Controls.Add(this.label_DureeEn);
            this.Controls.Add(this.listBox_TypeDuree);
            this.Controls.Add(this.textBox_Duree);
            this.Controls.Add(this.label_Duree);
            this.Controls.Add(this.richTextBox_Response);
            this.Controls.Add(this.label_Reponse);
            this.Controls.Add(this.dTP_DateInter);
            this.Controls.Add(this.label_DateInter);
            this.Controls.Add(this.textBox_DtDemande);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox_Demande);
            this.Controls.Add(this.label_demande);
            this.Controls.Add(this.textBox_Niveau);
            this.Controls.Add(this.label_niveau);
            this.Controls.Add(this.textBox_Num);
            this.Controls.Add(this.label_num);
            this.Controls.Add(this.label_Description);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_EditTicket";
            this.Text = "GSB - HelpDesk - Edition de ticket";
            this.Load += new System.EventHandler(this.Form_EditTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.TextBox textBox_Num;
        private System.Windows.Forms.Label label_niveau;
        private System.Windows.Forms.TextBox textBox_Niveau;
        private System.Windows.Forms.Label label_demande;
        private System.Windows.Forms.RichTextBox richTextBox_Demande;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_DtDemande;
        private System.Windows.Forms.Label label_DateInter;
        private System.Windows.Forms.DateTimePicker dTP_DateInter;
        private System.Windows.Forms.Label label_Reponse;
        private System.Windows.Forms.RichTextBox richTextBox_Response;
        private System.Windows.Forms.Label label_Duree;
        private System.Windows.Forms.TextBox textBox_Duree;
        private System.Windows.Forms.ListBox listBox_TypeDuree;
        private System.Windows.Forms.Label label_DureeEn;
        private System.Windows.Forms.Label label_Etat;
        private System.Windows.Forms.ListBox listBox_Etat;
        private System.Windows.Forms.Button button_Annuler;
        private System.Windows.Forms.Button button_Enregistrer;
    }
}