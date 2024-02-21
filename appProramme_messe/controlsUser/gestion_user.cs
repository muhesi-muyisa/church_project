using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace appProramme_messe.controlsUser
{
    public partial class gestion_user : UserControl
    {

        // Connexion à la base de données
        MySqlConnection con = new MySqlConnection("server=localhost;database=programme_sj;user='root';pwd=''");
        MySqlCommand cmd;

        private static gestion_user Usergestion_user;

        //Création d'une instance
        public static gestion_user instance
        {
            get
            {
                if (Usergestion_user == null)
                {
                    Usergestion_user = new gestion_user();
                }
                return Usergestion_user;
            }
        }
        public gestion_user()
        {
            InitializeComponent();
        }


        // La   méthode pour afficher 

        void affichage()
        {
            try
            {
                cmd = new MySqlCommand("SELECT * FROM auteur", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                int verify = 0;
                dgtUser.Rows.Clear();
                while (dr.Read())
                {
                    verify++;
                    dgtUser.Rows.Add(verify.ToString(), dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                } dr.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex);
                con.Close();
            }
        }

        // Méthode suppression de champs ....................

        void suppressionChamps()
        {
            txtIdAuteur.Clear();
            txtNom.Clear();
            txtPostnom.Clear();
            txtPrenom.Clear();
            txtTelephone.Clear();
        }

        private void gestion_user_Load(object sender, EventArgs e)
        {
            affichage();
            suppressionChamps();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Enregistrement d'un utilisateur ..............................................................................................

            try
            {
                if (txtNom.Text != "" || txtPostnom.Text != "" || txtPrenom.Text != "" || txtTelephone.Text != "")
                {
                    cmd = new MySqlCommand("INSERT INTO auteur(noms,postnom,prenom,telepone) VALUES('" + txtNom.Text + "','" + txtPostnom.Text + "','" + txtPrenom.Text + "','" + txtTelephone.Text + "')", con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Enregistrement réussi");
                        con.Close();
                        affichage();
                        suppressionChamps();
                        pnlAddchant.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Enregistrement échoué");
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Tous les champs sont nécessaires");
                    con.Close();
                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Erreur " + ex);
                con.Close();
            }

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            pnlAddchant.Visible = false;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            pnlAddchant.Visible = !pnlAddchant.Visible;
            lbTitre.Text = "AJOUTER UN NOUVEAU AUTEUR";
            button1.Visible = true;
            button2.Visible = true;
            btnModife.Visible = false;
            suppressionChamps();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            pnlAddchant.Visible = !pnlAddchant.Visible;
            lbTitre.Text = "MODIFICATION DE L'AUTEUR";
            button1.Visible = false;
            button2.Visible = false;
            btnModife.Visible = true;
        }

        private void btnModife_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("UPDATE auteur SET noms='" + txtNom.Text + "', postnom='" + txtPostnom.Text + "',prenom='" + txtPrenom.Text + "',telepone='" + txtTelephone.Text + "' WHERE idAuteur='" + txtIdAuteur.Text + "'", con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Modification réussie");
                    con.Close();
                    affichage();
                    pnlAddchant.Visible = false;
                }
                else
                {
                    MessageBox.Show("Modification échhouée");
                    con.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex);
                con.Close();
            }
        }

        private void dgtUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dgtUser.CurrentRow.Cells[1].Value != null)
            {
                txtIdAuteur.Text = dgtUser.CurrentRow.Cells[1].Value.ToString();
                txtNom.Text = dgtUser.CurrentRow.Cells[2].Value.ToString();
                txtPostnom.Text = dgtUser.CurrentRow.Cells[3].Value.ToString();
                txtPrenom.Text = dgtUser.CurrentRow.Cells[4].Value.ToString();
                txtTelephone.Text = dgtUser.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void btnSupremer_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("DELETE FROM auteur WHERE idAuteur='" + txtIdAuteur.Text + "'", con);
                con.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Suppression réussie");
                    con.Close();
                    affichage();
                    pnlAddchant.Visible = false;
                }
                else
                {
                    MessageBox.Show("échhouée");
                    con.Close();
                }
            }
            catch(MySqlException ex){
                MessageBox.Show("Erreur "+ex);
                con.Close();
            }
        }

        private void txtRecherche_Enter(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "Recherche...........................")
            {
                txtRecherche.Text = "";
                txtRecherche.ForeColor = Color.Black;
            }
        }

        private void txtRecherche_Leave(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "")
            {
                txtRecherche.Text = "Recherche...........................";
                txtRecherche.ForeColor = Color.Silver;
            }
        }
    }
}
