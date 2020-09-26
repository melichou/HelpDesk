using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk.IHM
{
    public partial class Form_Technicien : Form
    {
        User utilisateur;
        public Form_Technicien(string email, string password)
        {
            InitializeComponent();
            utilisateur = new User(email, password);
        }

        private void Form_Technicien_Load(object sender, EventArgs e)
        {

        }

        private void ticketToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Êtes vous sûr de vouloir quitter ?");
            Environment.Exit(0);
        }

        private void consulterToutLesTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AllTickets form_AllTickets = new Form_AllTickets();
            form_AllTickets.Show();
        }

        private void consulterLesTicketsOuvertsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TicketsOpen form_TicketsOpen = new Form_TicketsOpen(utilisateur.GetUserEmail(), utilisateur.GetUserPassword());
            form_TicketsOpen.Show();
        }
    }
}
