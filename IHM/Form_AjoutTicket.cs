using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk
{
    public partial class Form_AjoutTicket : Form
    {
        User utilisateur;
        public Form_AjoutTicket(string email, string password)
        {
            InitializeComponent();
            utilisateur = new User(email, password);
        }

        private void Form_AjoutTicket_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous quittez sans enregistrer votre ticket.");
            this.Close();
        }

        private void button_Valider_Click(object sender, EventArgs e)
        {
            string objet = listBox_Niveau.SelectedItem.ToString();
            string demande = richTextBox_Demande.Text;
            Ticket nouveauTicket = new Ticket(objet, demande);
            SQL ajoutTicket = new SQL();
            string query = "INSERT INTO [dbo].[tbTicket] ([Uid],[State],[Object],[DtRequest],[Request],[UidUserRequest]) VALUES " + "( NEWID(),"  
                + "1, '" + objet + "','" + nouveauTicket.dtRequest + "','" + demande + "','" + utilisateur.GetUserId() + "')" ;
            ajoutTicket.ExecuteInsert(query);
            MessageBox.Show("Votre ticket a bien été enregistré. Il sera traité dans les meilleurs délais.");
            this.Close();
        }

        private void listBox_Niveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = listBox_Niveau.SelectedIndex;
            listBox_Niveau.GetSelected(indice);
        }
    }
}
