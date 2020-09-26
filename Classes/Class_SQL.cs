using System;
using System.Data.SqlClient;
using System.Windows.Forms;

public class SQL
{
	//Déclaration des variables
	SqlConnection con;
	SqlDataReader reader;
	SqlCommand cmd;
	
	string conString = "Data Source=LAPTOP-QA1JQG2U\\MSQL2019;Initial Catalog=dbHelpDesk;Integrated Security=True";
	bool b_read;

	public SQL()
	{
		con = new SqlConnection(conString);
		con.Open();
	}
	public string ExecuteDB(string q)
	{
		cmd = new SqlCommand(q, con);
		reader = cmd.ExecuteReader();
		b_read = reader.Read();
		if (b_read == true)
        {
			string returnReader;
			returnReader = reader.GetValue(0).ToString();
			reader.Close();
			return returnReader;
		}
		else
        {
			return "Il y a eu une erreur, aucune donnée n'a pu être lue";
        }
	}
	public void ExecuteInsert(string q)
    {
		cmd = new SqlCommand(q, con);
		int command = cmd.ExecuteNonQuery();
		if (command == 0)
        {
			MessageBox.Show("Erreur à l'execution de la requête.");
        }
	}
	public void Deconnection()
    {
		con.Close();
    }
}
