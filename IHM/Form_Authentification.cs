using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace HelpDesk
{
    public partial class Form_Authentification : Form
    {
        public Form_Authentification()
        {
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void button_Valid_Click(object sender, EventArgs e)
        {
            //Initialisation et ouverture de la connection SQL
            SQL conn = new SQL();
            //Récupération de l'email saisi par l'utilisateur
            string email = textBox_Email.Text.ToString();            
            string verif = "select Uid from dbo.tbUser where email = '" + email + "'";
            string resultReq = conn.ExecuteDB(verif);
            if (resultReq != null)
            {                
                //Recherche du mot de passe correspondant dans la base de données 
                string q = "select password from dbo.tbUser where email = '" + email + "'";                
                //Récupération du mot de passe saisi par l'utilisateur et récupération du mot de passe de la BD
                string password = conn.ExecuteDB(q);
                
                //Vérification de la correspondance des mots de passes saisi et de la base de données
                if (password == textBox_Password.Text.ToString())
                {
                    //Vérification du statut de l'utilisateur si mot de passe correct
                    string qStatut = "select UidGroup from dbo.tbUser where email = '" + email + "'";
                    string statut = conn.ExecuteDB(qStatut);

                    if (statut == "ecf5ce8b-ab9b-47bc-9e3f-20dabe24f831")
                    {
                        //Le statut de l'utilisateur est Visiteur
                        
                        IHM.Form_Visiteur FormVisiteur = new IHM.Form_Visiteur(email,password);
                        FormVisiteur.Show();
                        string qName = "SELECT NameLast FROM tbUser WHERE email = '" + email + "' ";
                        string qFirstName = "SELECT NameFirst FROM tbUser WHERE email = '" + email + "' ";
                        SQL namecmd = new SQL();
                        string name = namecmd.ExecuteDB(qName);
                        string nameFirst = namecmd.ExecuteDB(qFirstName);
                        MessageBox.Show("Bienvenue " + nameFirst + " " + name + ".");
                    }

                    else
                    {
                        //Le statut de l'utilisateur est Technicien
                        
                        IHM.Form_Technicien FormTechnicien = new IHM.Form_Technicien(email, password);
                        FormTechnicien.Show();
                        string qName = "SELECT NameLast FROM tbUser WHERE email = '" + email + "' ";
                        string qFirstName = "SELECT NameFirst FROM tbUser WHERE email = '" + email + "' ";
                        SQL namecmd = new SQL();
                        string name = namecmd.ExecuteDB(qName);
                        string nameFirst = namecmd.ExecuteDB(qFirstName);
                        MessageBox.Show("Bienvenue " + nameFirst + " " + name + ".");

                    }
                }
                else
                {
                    //Le mot de passe saisi ne correspond pas à celui de la base de données
                    MessageBox.Show("Votre mot de passe est incorrect, veuillez vérifier votre saisie.");
                }

            }
            else
            {
                //L'adresse email saisie n'est pas dans la base de données
                MessageBox.Show("Votre adresse email n'est pas reliée à un compte, veuillez vérifier votre saisie.");
            }
            
        }

        private void AuthentificationForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxAfficherMdp_CheckedChanged(object sender, EventArgs e)
        {
            //Pour afficher ou masquer les caractères du mot de passe
            if (checkBoxAfficherMdp.Checked)
            {
                textBox_Password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Password.UseSystemPasswordChar = true;
            }
        }
    }
}
