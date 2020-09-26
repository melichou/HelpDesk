namespace HelpDesk
{
    partial class Form_Authentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Bienvenue = new System.Windows.Forms.Label();
            this.label_UserName = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Valid = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.checkBoxAfficherMdp = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_Bienvenue
            // 
            this.label_Bienvenue.AutoSize = true;
            this.label_Bienvenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bienvenue.Location = new System.Drawing.Point(23, 22);
            this.label_Bienvenue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Bienvenue.Name = "label_Bienvenue";
            this.label_Bienvenue.Size = new System.Drawing.Size(489, 25);
            this.label_Bienvenue.TabIndex = 0;
            this.label_Bienvenue.Text = "Bienvenue, veuillez vous identifier pour continuer.";
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.Location = new System.Drawing.Point(25, 129);
            this.label_UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(147, 25);
            this.label_UserName.TabIndex = 1;
            this.label_UserName.Text = "Adresse email :";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(212, 132);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(188, 22);
            this.textBox_Email.TabIndex = 2;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(25, 199);
            this.label_Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(143, 25);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Mot de Passe :";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(212, 202);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(188, 22);
            this.textBox_Password.TabIndex = 4;
            this.textBox_Password.UseSystemPasswordChar = true;
            // 
            // button_Valid
            // 
            this.button_Valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Valid.Location = new System.Drawing.Point(448, 273);
            this.button_Valid.Margin = new System.Windows.Forms.Padding(4);
            this.button_Valid.Name = "button_Valid";
            this.button_Valid.Size = new System.Drawing.Size(115, 37);
            this.button_Valid.TabIndex = 5;
            this.button_Valid.Text = "Valider";
            this.button_Valid.UseVisualStyleBackColor = true;
            this.button_Valid.Click += new System.EventHandler(this.button_Valid_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.Location = new System.Drawing.Point(305, 273);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(115, 37);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Annuler";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // checkBoxAfficherMdp
            // 
            this.checkBoxAfficherMdp.AutoSize = true;
            this.checkBoxAfficherMdp.Location = new System.Drawing.Point(416, 203);
            this.checkBoxAfficherMdp.Name = "checkBoxAfficherMdp";
            this.checkBoxAfficherMdp.Size = new System.Drawing.Size(186, 21);
            this.checkBoxAfficherMdp.TabIndex = 7;
            this.checkBoxAfficherMdp.Text = "Afficher le mot de passe ";
            this.checkBoxAfficherMdp.UseVisualStyleBackColor = true;
            this.checkBoxAfficherMdp.CheckedChanged += new System.EventHandler(this.checkBoxAfficherMdp_CheckedChanged);
            // 
            // Form_Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 325);
            this.Controls.Add(this.checkBoxAfficherMdp);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Valid);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.label_Bienvenue);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Authentification";
            this.Text = "GSB - HelpDesk - Authentification";
            this.Load += new System.EventHandler(this.AuthentificationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Bienvenue;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Valid;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.CheckBox checkBoxAfficherMdp;
        internal System.Windows.Forms.TextBox textBox_Email;
    }
}

