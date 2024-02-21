using appProramme_messe.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appProramme_messe.models
{
    class Programme
    {
        Database database = new Database();
        //int idProgramme;
        //string titreProgramme;
        //string dateCreation;
        //string dateExecution;
        //int idCategorie;

        public bool addProgramme(int idProgramme, string titreProgramme,string dateExecution, string Categorie)
        {

            var con = database.getConnection();
            con.Open();
            // Selection 
            MySqlCommand cm = new MySqlCommand("SELECT idCategorie FROM categorie WHERE designation='" + Categorie + "'", con);
            MySqlDataReader rd = cm.ExecuteReader();
            int idCategorie = 0;
            if (rd.Read())
            {
                idCategorie = int.Parse(rd[0].ToString());
            }
            rd.Close();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO programme(`idProgramme`, `titreProgramme`, `dateExecution`, `idCategorie`) VALUES('" + idProgramme + "','" + titreProgramme + "','" + dateExecution + "','" + idCategorie + "')", con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    con.Close();
                    return true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur "+ex);
                con.Close();
            }
            con.Close();
            return false;
        }
        public bool addDatailProgramme(int idProgramme, int chants, string categirie)
        {
            var con = database.getConnection();
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO detailprogramme(`idProgramme`, `chants`, `categirie`) VALUES('" + idProgramme + "','" + chants+ "','" + categirie + "')", con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    con.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur " + ex);
                con.Close();
            }
            con.Close();
            return false;
        }


        public bool addCategorie(string designation)
        {

            var con = database.getConnection();
            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO categorie(designation) VALUES('" + designation + "')", con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    con.Close();
                    return true;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur " + ex);
                con.Close();
            }
            con.Close();
            return false;
        }
    }
}
