using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appProramme_messe.Forms
{
    public partial class Categorie : Form
    {
        public Categorie()
        {
            InitializeComponent();
            afficher("");
        }

        private void txtGame_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGame_Leave(object sender, EventArgs e)
        {
            if (txtGame.Text=="")
            {
                txtGame.Text = "Entrez la catégireie";
            }
        }

        private void txtGame_Enter(object sender, EventArgs e)
        {
            if (txtGame.Text== "Entrez la catégireie")
            {
                txtGame.Text = "";
            }
        }

        private void btnModife_Click(object sender, EventArgs e)
        {
            if (txtGame.Text!="" && txtGame.Text!= "Entrez la catégireie")
            {
                models.Programme pr = new models.Programme();
                if (pr.addCategorie(txtGame.Text)==true)
                {
                    MessageBox.Show("Catégorie ajoutée");
                    afficher("");
                }
                else
                {
                    MessageBox.Show("Echec d'enregistrement");
                }
            }
        }

        void afficher(string d)
        {
            models.Database db = new models.Database();
            var con=db.getConnection();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM categorie WHERE designation like '%"+d+"%'", con);
            MySqlDataReader rd = cmd.ExecuteReader();
            dgtCategorie.Rows.Clear();
            int coumpte = 0;
            while (rd.Read())
            {
                coumpte++;
                dgtCategorie.Rows.Add(rd[0].ToString(), coumpte, rd[1].ToString());
            }rd.Close();
            con.Close();
        }

        private void txtReasech_Leave(object sender, EventArgs e)
        {
            if (txtReasech.Text=="")
            {
                txtReasech.Text = "Recherche ..........................";
            }
        }

        private void txtReasech_Enter(object sender, EventArgs e)
        {
            if (txtReasech.Text== "Recherche ..........................")
            {
                txtReasech.Text = "";
            }
        }

        private void txtReasech_TextChanged(object sender, EventArgs e)
        {
            if (txtReasech.Text!="" && txtReasech.Text!= "Recherche ..........................")
            {
                afficher(txtReasech.Text);
            }
            else
            {
                afficher("");
            }
        }

        private void Categorie_Load(object sender, EventArgs e)
        {

        }
    }
}
