using System;
using System.Data.SqlClient;

public class SQL
{
	//Déclaration des variables
	SqlConnection con;
	public SqlDtaReader reader;
	SqlCommand cmd;
	public string q;
	string conString = "Data Source=LAPTOP-QA1JQG2U\\MSQL2019;Initial Catalog=dbExpenseReport;Integrated Security=True";
	bool b_read;

	public SQL()
	{
		con = new SqlConnection(conString);
		con.Open();
	}
	public void ExecuteDB()
	{
		cmd = new SqlCommand(q, con);
		reader = cmd.ExecuteReader();
		b_read = reader.Read();
	}
	public void Deconnection()
    {
		reader.Close();
		con.Close();
    }
}
