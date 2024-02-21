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
    public partial class gestion_chant : UserControl
    {

        // Connexion à la base de données
        MySqlConnection con = new MySqlConnection("server=localhost;database=programme_sj;user='root';pwd=''");
        MySqlCommand cmd;

        private static gestion_chant Usergestion_chant;

        //Création d'une instance
        public static gestion_chant instance
        {
            get
            {
                if (Usergestion_chant == null)
                {
                    Usergestion_chant = new gestion_chant();
                }
                return Usergestion_chant;
            }
        }
        public gestion_chant()
        {
            InitializeComponent();
            cbAuteur.Text ="";
            cbCategorie.Text = "";
        }


        void affichage()
        {
            try
            {
                cmd = new MySqlCommand("SELECT * FROM titrechant", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                int verify = 0;
                dgtChants.Rows.Clear();
                while (dr.Read())
                {
                    verify++;
                    dgtChants.Rows.Add(verify.ToString(), dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                } dr.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex);
                con.Close();
            }
        }

       void vider(){

            txtCouplets.Clear();
            txtIdChant.Clear();
            txtTitre.Clear();
            cbCategorie.Text = "";
            cbAuteur.Text = "";

        }
        private void gestion_chant_Load(object sender, EventArgs e)
        {
            affichage();
            vider();
            try
            {
                // Récupération des parents ........................................................

                cmd = new MySqlCommand("SELECT * FROM auteur", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbAuteur.Items.Add(dr[2].ToString());
                } dr.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Erreur " + ex);
                con.Close();
            }
        }

        private void btnAddChant_Click(object sender, EventArgs e)
        {
            pnlAddchant.Visible = !pnlAddchant.Visible;
            lbTitre.Text = "AJOUTER UN NOUVEAU CHANT";
            button1.Visible = true;
            button2.Visible = true;
            btnModife.Visible = false;
            vider();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            pnlAddchant.Visible = !pnlAddchant.Visible;
            lbTitre.Text = "MODIFICATION D'UN CHANT";
            button1.Visible = false;
            button2.Visible = false;
            btnModife.Visible = true;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            pnlAddchant.Visible = false;
        }

        private void btnModife_Click(object sender, EventArgs e)
        {
            try
            {
                
                cmd = new MySqlCommand("UPDATE titrechant SET titre='" + txtTitre.Text + "', couplet='" + txtCouplets.Text + "',idAuteur='" +cbAuteur.Text + "',idCategorie='" +cbCategorie.Text + "' WHERE idTitre='" +txtIdChant.Text+ "'", con);
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

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (cbAuteur.Text == "")
            {
                cbAuteur.Text = "Non connu";
            }
            // Enregistrement d'un nouveau chant.........................................................................................
            try
            {
                

                if (txtCouplets.Text != "" || txtTitre.Text != "" || cbAuteur.Text != "" || cbCategorie.Text != "")
                {
                    cmd = new MySqlCommand("INSERT INTO titrechant (titre,couplet,idCategorie,idAuteur) VALUES('" + txtTitre.Text + "','" + txtCouplets.Text + "','" + cbCategorie.Text + "','" + cbAuteur.Text + "')", con);

                    con.Open();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        if (MessageBox.Show("Enregistrement réussi \n Voulez - vous fermer le formulaire ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                        {
                            con.Close();
                            affichage();
                            vider();
                            pnlAddchant.Visible = false;
                        }
                        else
                        {
                            con.Close();
                            affichage();
                            vider();
                            pnlAddchant.Visible = true;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Enreggistrement échhoué");
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Tous les champs sont obligatoires");
                    con.Close();
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Erreur " + ex);
                con.Close();
            }
        }

        private void btnSupremer_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("DELETE titrechant WHERE idTitre='"+txtIdChant.Text+"'", con);
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex);
                con.Close();
            }
        }

        private void dgtChants_SelectionChanged(object sender, EventArgs e)
        {
            if (dgtChants.CurrentRow.Cells[1].Value != null)
            {
                txtIdChant.Text=dgtChants.CurrentRow.Cells[1].Value.ToString();
                txtTitre.Text = dgtChants.CurrentRow.Cells[2].Value.ToString();
                txtCouplets.Text = dgtChants.CurrentRow.Cells[3].Value.ToString();
                cbCategorie.Text = dgtChants.CurrentRow.Cells[4].Value.ToString();
                cbAuteur.Text = dgtChants.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void txtRecherche_Leave(object sender, EventArgs e)
        {
            if (txtRecherche.Text=="")
            {
                txtRecherche.Text = "Recherche...........................";
                txtRecherche.ForeColor = Color.Silver;
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

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbRecharche.Text == "TITRE")
                {
                    cmd = new MySqlCommand("SELECT * FROM titrechant WHERE titre ='" + txtRecherche.Text + "' OR titre LIKE '%" + txtRecherche.Text + "%'", con);
                    con.Open();
                    dgtChants.Rows.Clear();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    int verify = 0;

                    while (dr.Read())
                    {
                        verify++;
                        dgtChants.Rows.Add(verify.ToString(), dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                    }
                    dr.Close();
                    con.Close();
                }

                if (cbRecharche.Text == "CATEGORIE")
                {
                    cmd = new MySqlCommand("SELECT * FROM titrechant WHERE idCategorie ='" + txtRecherche.Text + "' OR idCategorie LIKE '%" + txtRecherche.Text + "%'", con);
                    con.Open();
                    dgtChants.Rows.Clear();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    int verify = 0;

                    while (dr.Read())
                    {
                        verify++;
                        dgtChants.Rows.Add(verify.ToString(), dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                    }
                    dr.Close();
                    con.Close();
                }
                if (cbRecharche.Text == "AUTEUR")
                {
                    cmd = new MySqlCommand("SELECT * FROM titrechant WHERE idAuteur ='" + txtRecherche.Text + "' OR idAuteur LIKE '%" + txtRecherche.Text + "%'", con);
                    con.Open();
                    dgtChants.Rows.Clear();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    int verify = 0;

                    while (dr.Read())
                    {
                        verify++;
                        dgtChants.Rows.Add(verify.ToString(), dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                    }
                    dr.Close();
                    con.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur "+ex);
                con.Close();
            }
        }
    }
}
