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

namespace HelpDesk.IHM
{
    public partial class Form_EditTicket : Form
    {
        User utilisateur;
        string conString = "Data Source=LAPTOP-QA1JQG2U\\MSQL2019;Initial Catalog=dbHelpDesk;Integrated Security=True";
        int nbTicket;
        Ticket ceTicket;
        public Form_EditTicket(int numTicket, string email, string password)
        {
            InitializeComponent();
            utilisateur = new User(email, password);
            nbTicket = numTicket;
        }

        private void Form_EditTicket_Load(object sender, EventArgs e)
        {
            ceTicket = new Ticket(nbTicket);
            textBox_Num.Text = nbTicket.ToString();
            textBox_DtDemande.Text = ceTicket.GetDtRequest().ToString();
            textBox_Niveau.Text = ceTicket.GetObject();
            richTextBox_Demande.Text = ceTicket.GetRequest();

        }
        private void dTP_DateInter_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aucune donnée ne sera enregistré");
            this.Close();
        }

        private void button_Enregistrer_Click(object sender, EventArgs e)
        {
            if (dTP_DateInter.Value != null && richTextBox_Response.Text != null && textBox_Duree.Text != null)
            {
                string duree = textBox_Duree.Text + " " + listBox_TypeDuree.SelectedItem;
                DateTime dateInter = dTP_DateInter.Value;
                SQL ticketState = new SQL();
                string query = "SELECT Idfc from tbTicketState WHERE Name = '" + listBox_Etat.SelectedItem + "'";
                ceTicket.ModifierTicket(richTextBox_Response.Text, dateInter, Convert.ToInt32(ticketState.ExecuteDB(query)), duree, utilisateur.GetUserEmail(), utilisateur.GetUserPassword());


                //On enregistre dans la base de données les données manquantes récupérées par le technicien
                SqlConnection remplirTicket = new SqlConnection(conString);
                remplirTicket.Open();
                string queryRemplir = "UPDATE tbTicket SET UidUserResponse = '" + ceTicket.uidUserResponse + "', DtIntervention = '" + ceTicket.dtIntervention.Date + "', Response = '" + ceTicket.response + "', State = " + ceTicket.stateT + ", Duree = '" + ceTicket.dureeD + "' WHERE num = " + ceTicket.GetNum();
                SqlCommand remplirceTicket = new SqlCommand(queryRemplir, remplirTicket);
                int reussi = remplirceTicket.ExecuteNonQuery();                
                if (reussi != 0)
                {
                    MessageBox.Show("Le ticket a été mis à jour avec succès.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Un problème est survenu. Veuillez réessayer en vérifiant vos informations");
                }
                
            }
            else
            {
                MessageBox.Show("Remplissez tout les champs possédant un signe * qui sont opbligatoires s'il vous plait.");
            }
        }

        
    }
}
