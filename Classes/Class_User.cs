using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class User
    {
        //Déclaration des variables
        string Uid;
        string UidGroup;
        string NameLast;
        string NameFirst;
        string Email;
        string Password;
        int ZipCode;
        string City;
        DateTime HireDate;
        string Id;
        public User(string email, string password)
        {
            //Remplissage des données de l'utilisateur répertoriées dans la base de données
            SQL getUserInfos = new SQL();
            Uid = getUserInfos.ExecuteDB("select Uid from tbUser where email =  '" + email + "' and password = '" + password + "'");
            UidGroup = getUserInfos.ExecuteDB("select UidGroup from tbUser where email =  '" + email + "' and password = '" + password + "'");
            NameLast = getUserInfos.ExecuteDB("select NameLast from tbUser where email =  '" + email + "' and password = '" + password + "'");
            NameFirst = getUserInfos.ExecuteDB("select NameFirst from tbUser where email =  '" + email + "' and password = '" + password + "'");
            Email = email;
            Password = password;
            ZipCode = Convert.ToInt32(getUserInfos.ExecuteDB("select ZipCode from tbUser where email =  '" + email + "' and password = '" + password + "'"));
            City = getUserInfos.ExecuteDB("select City from tbUser where email =  '" + email + "' and password = '" + password + "'");
            HireDate = Convert.ToDateTime(getUserInfos.ExecuteDB("select HireDate from tbUser where email =  '" + email + "' and password = '" + password + "'"));
            Id = getUserInfos.ExecuteDB("select Id from tbUser where email =  '" + email + "' and password = '" + password + "'");
        }

        public User(string ID)
        {
            SQL getUserInfos = new SQL();
            Uid = ID;
            UidGroup = getUserInfos.ExecuteDB("select UidGroup from tbUser where uid =  '" + ID + "'");
            NameLast = getUserInfos.ExecuteDB("select NameLast from tbUser where uid =  '" + ID + "'");
            NameFirst = getUserInfos.ExecuteDB("select NameFirst from tbUser where uid =  '" + ID + "'");
            Email = getUserInfos.ExecuteDB("select Email from tbUser where uid =  '" + ID + "'");
            Password = getUserInfos.ExecuteDB("select Password from tbUser where uid =  '" + ID + "'");
            ZipCode = Convert.ToInt32(getUserInfos.ExecuteDB("select ZipCode from tbUser where uid =  '" + ID + "'"));
            City = getUserInfos.ExecuteDB("select City from tbUser where uid =  '" + ID + "'");
            HireDate = Convert.ToDateTime(getUserInfos.ExecuteDB("select HireDate from tbUser where uid =  '" + ID + "'"));
            Id = getUserInfos.ExecuteDB("select Id from tbUser where uid =  '" + ID + "'");
        }

        public string GetUserId()
        {
            return this.Uid;
        }
        public string GetUserIdGroup()
        {
            return this.UidGroup;
        }
        public string GetUserNames()
        {
            return this.NameFirst + " " + this.NameLast;
        }
        public string GetUserNameLast()
        {
            return this.NameLast;
        }
        public string GetUserNameFirst()
        {
            return this.NameFirst;
        }
        public string GetUserEmail()
        {
            return this.Email;
        }
        public string GetUserPassword()
        {
            return this.Password;
        }
        
    }

