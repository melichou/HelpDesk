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
    public partial class Form_AllTickets : Form
    {
        string conString = "Data Source=LAPTOP-QA1JQG2U\\MSQL2019;Initial Catalog=dbHelpDesk;Integrated Security=True";
        public Form_AllTickets()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_AllTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_AllTickets_Load(object sender, EventArgs e)
        {
            //Ajout des colonnes dans le DataGrid
            dataGridView_AllTickets.ColumnCount = 7;
            dataGridView_AllTickets.Columns[0].Name = "N°";
            dataGridView_AllTickets.Columns[1].Name = "Niveau";
            dataGridView_AllTickets.Columns[2].Name = "Etat";
            dataGridView_AllTickets.Columns[3].Name = "Demandé Le";
            dataGridView_AllTickets.Columns[4].Name = "Demandé Par";
            dataGridView_AllTickets.Columns[5].Name = "Durée";
            dataGridView_AllTickets.Columns[6].Name = "Clôturé Le";
            dataGridView_AllTickets.Rows.Clear(); //Vide les lignes présentes par sécurité

            dataGridView_AllTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Initialisation de la connection SQL (je n'ai pas utilisé la classe pour avoir une meilleure main sur le reader)
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            string query = "SELECT Num, Object, State, DtRequest, DtIntervention, UidUserRequest, Duree FROM tbTicket ";
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    User utilisateur = new User(reader[5].ToString());
                    Ticket ceTicket = new Ticket(Convert.ToInt32(reader[0]));
                    //on remplit une ligne du DataGridView par ligne dans la table
                    dataGridView_AllTickets.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), utilisateur.GetUserNames(), reader[6].ToString(), reader[4].ToString());
                }
                //On ferme le reader et la connection SQL
                reader.Close();
                conn.Close();
                //On empêche la saisie dans les cellules du DGV
                dataGridView_AllTickets.ReadOnly = true;
                //On redimensionne les colonnes et lignes du DataGridView pour les adapter au contenu
                dataGridView_AllTickets.AutoResizeColumns();
                dataGridView_AllTickets.AutoResizeRows();
            }
        }
    }
}
