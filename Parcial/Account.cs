using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Parcial
{
    class Account
    {
        Connection conn = new Connection();
        Crud crud = new Crud();

        public int _codUsuario { get; set; }
        public string _firstname { get; set; }
        public string _lastname { get; set; }
        public string _email { get; set; }
        public string _registerDate { get; set; }
        public string _username { get; set; }
        public string _password { get; set; }
 

        public MySqlDataReader getAll()
        {
            string query = "SELECT * FROM account WHERE codUser<>1";
            return crud.select(query); 
        }
        public Boolean registro()
        {
            string query = "INSERT INTO account(codUser, firstname, lastname, email, registerDate, username, password)" + 
                "VALUES('" + _codUsuario + "', '" +  _firstname + "', '" + _lastname + "', '" + _email + "', '" + _registerDate + "', '"  + _username + "', '" + _password + "')";
            crud.executeQuery(query);
            return true; 

        }

        public Boolean logeo()
        {
            string query = "SELECT * FROM account WHERE username='"+_username+"' AND password='" + _password + "'"; 
            if (crud.select(query).HasRows)
            {
                return true;
            }
            return false;
        }
        public void Insertlog()
        {
            string Insertlog = "INSERT INTO userlog(codUser, username, timeLoggedln) VALUES ('" + _codUsuario + "','" + _username + "','"  + DateTime.Now.ToString("ddd, MM ,yyy   hh:mm:ss") + "')";
        crud.executeQuery(Insertlog); 
        }

    public MySqlDataReader GetMy()
    {
            string query = "SELECT * FROM account WHERE  username='" + _username + "'"; 
            return crud.select(query);
              
    }

        public MySqlDataReader GetLog()
        {
            string query = "SELECT * FROM userlog";
            return crud.select(query);
        }



       
    }
}
