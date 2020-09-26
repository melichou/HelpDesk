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
    public partial class Form_Visiteur : Form
    {
        User utilisateur;
        public Form_Visiteur(string email, string password)
        {
            InitializeComponent();
            utilisateur = new User(email, password);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Êtes vous sûr de vouloir quitter ?"); 
            Environment.Exit(0);
        }

        private void Form_Principale_Load(object sender, EventArgs e)
        {
            
        }

        private void nouveauTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AjoutTicket form_AjoutTicket = new Form_AjoutTicket(utilisateur.GetUserEmail(),utilisateur.GetUserPassword());
            form_AjoutTicket.Show();
        }

        private void listeDesTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ListeTicketVisit form_ListeTicketV = new Form_ListeTicketVisit(utilisateur.GetUserEmail(), utilisateur.GetUserPassword());
            form_ListeTicketV.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
