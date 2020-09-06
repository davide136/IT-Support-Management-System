using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Manager_riparazioni.Util
{
    class DBConnection
    {
        private DBConnection()
        {
        }

        public string Password { get; set; }

        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {                
                String db_name = Properties.Settings.Default.DB_Name;
                if (String.IsNullOrEmpty(db_name))
                    return false;
                String uri = Properties.Settings.Default.URI_Database;
                String username = Properties.Settings.Default.Username;
                String password = Properties.Settings.Default.Password;
                string connstring = string.Format("Server="+uri+"; database={0}; UID=" + username + "; password= " + password, db_name);
                connection = new MySqlConnection(connstring);
                connection.Open();
            }

            return true;
        }

        public void Disconnect()
        {
            if (Connection != null)
            {
                connection.Close();
                connection = null;
            }

        }


    }
}
