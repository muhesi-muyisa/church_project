using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appProramme_messe.models
{
    class Database
    {
        private MySqlConnection con;
        public MySqlConnection getConnection()
        {
            //hervainliko98
            string host = "localhost";
            string database = "programme_sj";
            string username = "root";
            string password = "";
            try
            {
                string connection_string = "datasource =" + host + "; database=" + database + ";username=" + username + ";password=" + password + "";
                con = new MySqlConnection(connection_string);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur "+ex);
            }
            return con;
        }

        //creation de la fonction pour ouvrir la connection
        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        //creation de la fonction pour fermer la connection
        public void Closeconnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        // creation d'une fonction pour retourne la connection
       


    }
}
