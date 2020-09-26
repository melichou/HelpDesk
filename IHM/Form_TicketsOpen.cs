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
    public partial class Form_TicketsOpen : Form 
    {
        User utilisateur;
        string conString = "Data Source=LAPTOP-QA1JQG2U\\MSQL2019;Initial Catalog=dbHelpDesk;Integrated Security=True";

        public Form_TicketsOpen(string email, string password)
        {
            InitializeComponent();
            utilisateur = new User(email, password);
        }

        private void Form_TicketsOpen_Load(object sender, EventArgs e)
        {
            //Ajout des colonnes dans le DataGrid
            dataGridView_TicketsOpen.ColumnCount = 5;
            dataGridView_TicketsOpen.Columns[0].Name = "N°";
            dataGridView_TicketsOpen.Columns[1].Name = "Niveau";
            dataGridView_TicketsOpen.Columns[2].Name = "Etat";
            dataGridView_TicketsOpen.Columns[3].Name = "Demandé Le";
            dataGridView_TicketsOpen.Columns[4].Name = "Demandé Par";
            dataGridView_TicketsOpen.Rows.Clear(); //Vide les lignes présentes par sécurité

            dataGridView_TicketsOpen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Initialisation de la connection SQL (je n'ai pas utilisé la classe pour avoir une meilleure main sur le reader)
            SqlConnection conn = new SqlConnection(conString);
            conn.Open();
            string query = "SELECT Num, Object, State, DtRequest, DtIntervention, UidUserRequest FROM tbTicket WHERE DtIntervention IS NULL";
            SqlCommand comm = new SqlCommand(query, conn);
            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //on remplit une ligne du DataGridView par ligne dans la table
                    User utilisateur = new User(reader[5].ToString());
                    dataGridView_TicketsOpen.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), utilisateur.GetUserNames(), " ", reader[4].ToString());
                }
                //On ferme le reader et la connection SQL
                reader.Close();
                conn.Close();
                //On empêche la saisie dans les cellules du DGV
                dataGridView_TicketsOpen.ReadOnly = true;
                //On redimensionne les colonnes et lignes du DataGridView pour les adapter au contenu
                dataGridView_TicketsOpen.AutoResizeColumns();
                dataGridView_TicketsOpen.AutoResizeRows();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_TicketsOpen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_TicketsOpen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            int numSelect = Convert.ToInt32(dataGridView_TicketsOpen.CurrentRow.Cells[0].Value);
            Form_EditTicket form_EditTicket = new Form_EditTicket(numSelect,utilisateur.GetUserEmail(),utilisateur.GetUserPassword());
            form_EditTicket.Show();
        }
    }
}
