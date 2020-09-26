using HelpDesk;
using HelpDesk.IHM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

public class Ticket
{
    //Déclaration des variables 
    public string uid;
    public int num;
    public int stateT;
    public string obj;
    public DateTime dtRequest = new DateTime();
    string request;
    public string uidUserRequest;
    public string uidUserResponse;
    public DateTime dtIntervention = new DateTime();
    public string response;
    string conString = "Data Source=LAPTOP-QA1JQG2U\\MSQL2019;Initial Catalog=dbHelpDesk;Integrated Security=True";
    public string duree;


    public Ticket(string objet,string req)
    {
        dtRequest = DateTime.Now;
        obj = objet;
        request = req;              
    }

    public Ticket(int numTicket)
    {
        //On remplit le ticket avec les informations de la Base de Données grâce à son numéro lorsqu'il existe déja
        SqlConnection conn = new SqlConnection(conString);
        conn.Open();
        string query = "SELECT Uid, Object, DtRequest, Request, UidUserRequest FROM tbTicket WHERE Num = " + numTicket;
        SqlCommand remplirTicket = new SqlCommand(query, conn);
        SqlDataReader reader = remplirTicket.ExecuteReader();
        reader.Read();
        if (reader.HasRows == true)
        {
            this.uid = reader[0].ToString();
            this.num = numTicket;
            this.obj = reader[1].ToString();
            this.dtRequest = Convert.ToDateTime(reader[2]);
            this.request = reader[3].ToString();
            this.uidUserRequest = reader[4].ToString();            
        }
        else
        {
            MessageBox.Show("Le ticket que vous essayez de modifier n'existe pas. Veuillez vérifier le numéro dudit ticket");
        }
        
    }

    public void ModifierTicket(string rep, DateTime dateInter, int state, string email, string password)
    {
        dtIntervention = dateInter.Date;
        response = rep;
        stateT = state;
        SQL getUserId = new SQL();
        string query = "SELECT Uid FROM tbUser WHERE Email = '" + email + "' AND Password = '" + password + "'";
        uidUserResponse = getUserId.ExecuteDB(query);
    }

    public string GetUID()
    {
        return this.uid;
    }

    public int GetNum()
    {
        return this.num;
    }

    public int GetState()
    {
        return this.stateT;
    }

    public string GetObject()
    {
        return this.obj;
    }

    public DateTime GetDtRequest()
    {
        return this.dtRequest;
    }

    public string GetRequest()
    {
        return this.request;
    }

    public string GetUserResponseId()
    {
        return this.uidUserResponse;
    }

    public string GetResponse()
    {
        return this.response;
    }

    public DateTime GetDtInter()
    {
        return this.dtIntervention;
    }

}





