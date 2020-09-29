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
    public partial class Form_DetailTicketVisit : Form
    {
        User utilisateur;
        string conString = "Data Source=LAPTOP-QA1JQG2U\\MSQL2019;Initial Catalog=dbHelpDesk;Integrated Security=True";
        int numTicket;
        Ticket ceTicket;
        public Form_DetailTicketVisit(int nbTicket, string email, string password)
        {
            InitializeComponent();
            utilisateur = new User(email, password);
            numTicket = nbTicket;
            ceTicket = new Ticket(numTicket);
        }

        private void Form_DetailTicketVisit_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            string query = "SELECT * FROM tbTicket WHERE UidUserRequest = '" + utilisateur.GetUserId() + "' AND Num = " + numTicket;
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader reader = comm.ExecuteReader();

            //Ajout des colonnes dans le DataGrid
            dataGridView_DetailTicket.ColumnCount = 9;
            dataGridView_DetailTicket.Columns[0].Name = "N°";
            dataGridView_DetailTicket.Columns[1].Name = "Niveau";
            dataGridView_DetailTicket.Columns[2].Name = "Etat";
            dataGridView_DetailTicket.Columns[3].Name = "Demandé le";
            dataGridView_DetailTicket.Columns[4].Name = "Demandé par";
            dataGridView_DetailTicket.Columns[5].Name = "Demande";
            dataGridView_DetailTicket.Columns[6].Name = "Durée";
            dataGridView_DetailTicket.Columns[7].Name = "Cloturé le";
            dataGridView_DetailTicket.Columns[8].Name = "Réponse";

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //on remplit une ligne du DataGridView par ligne dans la table
                    dataGridView_DetailTicket.Rows.Add(reader[1].ToString(), reader[3].ToString(), reader[2].ToString(), reader[4].ToString(), utilisateur.GetUserNames(), reader[5].ToString(), ceTicket.GetDuree(), reader[8].ToString(), reader[9].ToString());
                }
                //On ferme le reader et la connection SQL
                reader.Close();
                conn.Close();
                //On redimensionne les colonnes et lignes du DataGridView pour les adapter au contenu
                dataGridView_DetailTicket.AutoResizeColumns();
                dataGridView_DetailTicket.AutoResizeRows();
                //On empêche la saisie de données dans les cellules du DGV
                dataGridView_DetailTicket.ReadOnly = true;
            }

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
