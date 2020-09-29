using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk.IHM
{
    public partial class Form_ListeTicketVisit : Form
    {
        User utilisateur;
        string conString = "Data Source=LAPTOP-QA1JQG2U\\MSQL2019;Initial Catalog=dbHelpDesk;Integrated Security=True";
        public Form_ListeTicketVisit(string email, string password)
        {
            InitializeComponent();
            utilisateur = new User(email, password);
        }

        private void Form_ListeTicketVisit_Load(object sender, EventArgs e)
        {
            //Ajout des colonnes dans le DataGrid
            dataGridView_Visiteurs.ColumnCount = 7;
            dataGridView_Visiteurs.Columns[0].Name = "N°";
            dataGridView_Visiteurs.Columns[1].Name = "Niveau";
            dataGridView_Visiteurs.Columns[2].Name = "Etat";
            dataGridView_Visiteurs.Columns[3].Name = "Demandé Le";
            dataGridView_Visiteurs.Columns[4].Name = "Demandé Par";
            dataGridView_Visiteurs.Columns[5].Name = "Durée";
            dataGridView_Visiteurs.Columns[6].Name = "Clôturé Le";
            dataGridView_Visiteurs.Rows.Clear(); //Vide les lignes présentes par sécurité

            dataGridView_Visiteurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Initialisation de la connection SQL (je n'ai pas utilisé la classe pour avoir une meilleure main sur le reader)
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            string query = "SELECT Num, Object, State, DtRequest, DtIntervention, Duree FROM tbTicket WHERE UidUserRequest = '" + utilisateur.GetUserId() + "'";
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //on remplit une ligne du DataGridView par ligne dans la table
                    dataGridView_Visiteurs.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), utilisateur.GetUserNames(), reader[5].ToString(), reader[4].ToString());
                }
                //On ferme le reader et la connection SQL
                reader.Close();
                conn.Close();
                //On empêche la saisie dans les cellules du DGV
                dataGridView_Visiteurs.ReadOnly = true;
                //On redimensionne les colonnes et lignes du DataGridView pour les adapter au contenu
                dataGridView_Visiteurs.AutoResizeColumns(); 
                dataGridView_Visiteurs.AutoResizeRows();
            }
        }

        private void dataGridView_Visiteurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numSelect = Convert.ToInt32(dataGridView_Visiteurs.CurrentRow.Cells[0].Value);
            Form_DetailTicketVisit form_DetailTicketVisit = new Form_DetailTicketVisit(numSelect, utilisateur.GetUserEmail(), utilisateur.GetUserPassword());
            form_DetailTicketVisit.Show();

        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
