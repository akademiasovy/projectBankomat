using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    class Database
    {
        private string serverName = "localhost";
        private string user = "root";
        private string password = "";
        private string port = "3306";
        private string dbName = "bankomat";
        private MySqlConnection conn;
    

    public void openConnection()
    {
        string conStr = "server=" + serverName +
                  ";user=" + user +
                  ";database=" + dbName +
                  ";port=" + port +
                  ";password=" + password + ";";
            conn = new MySqlConnection(conStr);
    }
    }
}
