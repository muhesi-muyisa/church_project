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
    public partial class gestion_programme : UserControl
    {
        // Connexion à la base de données
        MySqlConnection con = new MySqlConnection("server=localhost;database=programme_sj;user='root';pwd=''");
        MySqlCommand cmd;
        private static gestion_programme Usergestion_programme;

        //Création d'une instance
        public static gestion_programme instance
        {
            get
            {
                if (Usergestion_programme == null)
                {
                    Usergestion_programme = new gestion_programme();
                }
                return Usergestion_programme;
            }


        }


        // La   méthode pour afficher 

        void affichage()
        {
            try
            {
                cmd = new MySqlCommand("SELECT * FROM programme", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                int verify = 0;
                dgtProgramme.Rows.Clear();
                while (dr.Read())
                {
                    verify++;
                    dgtProgramme.Rows.Add(verify.ToString(), dr[0].ToString(), dr[1].ToString());
                } dr.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex);
                con.Close();
            }
        }
        public gestion_programme()
        {
            InitializeComponent();
            remplissage();
            affichage();
            afficher("");
        }

        //Méthode de remplissagge de champs par defaut
        void remplissage()
        {
            if (cbInvitatoire.Text=="")
            {
                txtInvitatoire1.Text = "-1";
            }
            if (cbInvitatoire2.Text == "")
            {
                txtInvitatoire2.Text = "-1";
            }
            if (cbEntree.Text=="")
            {
                txtEntree1.Text = "-1";
            }
            if (cbEntree2.Text == "")
            {
                txtEntree2.Text = "-1";
            } 
            if (cbA_G1.Text == "")
            {
                txtA_G1.Text = "-1";
            }
            if (cbA_G2.Text == "")
            {
                txtA_G2.Text = "-1";
            }
            if (cbA_G3.Text == "")
            {
                txtA_G3.Text = "-1";
            }
            if (cbCommunion1.Text == "")
            {
                txtCommunion1.Text = "-1";
            }
            if (cbCommunion2.Text == "")
            {
                txtCommunion2.Text = "-1";
            }
            if (cbOffertoir1.Text == "")
            {
                txtOffertoire1.Text = "-1";
            }
            if (cbOffertoire2.Text == "")
            {
                txtOffertoire2.Text = "-1";
            }

        }


        void viderCbUniversal() {
            cbInvitatoire.Items.Clear();
            cbInvitatoire2.Items.Clear();
            cbEntree.Items.Clear();
            cbEntree2.Items.Clear();
            cbCommunion1.Items.Clear();
            cbCommunion2.Items.Clear();
            cbA_G1.Items.Clear();
            cbA_G2.Items.Clear();
            cbA_G3.Items.Clear();
            cbSortie.Items.Clear();
        }
        private void gestion_programme_Load(object sender, EventArgs e)
        {
            //Vérification des informations de la base de données ...................................................................
            try
            {
                cmd = new MySqlCommand("SELECT * FROM titrechant",con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                viderCbUniversal();
                while (dr.Read())
                {
                    cbInvitatoire.Items.Add(dr[1].ToString());
                    cbInvitatoire2.Items.Add(dr[1].ToString());
                    cbEntree.Items.Add(dr[1].ToString());
                    cbEntree2.Items.Add(dr[1].ToString());
                    cbCommunion1.Items.Add(dr[1].ToString());
                    cbCommunion2.Items.Add(dr[1].ToString());
                    cbA_G1.Items.Add(dr[1].ToString());
                    cbA_G2.Items.Add(dr[1].ToString());
                    cbA_G3.Items.Add(dr[1].ToString());
                    cbSortie.Items.Add(dr[1].ToString());
                } dr.Close();


                //Selection de chants kyrie......................................

                cmd = new MySqlCommand("SELECT * FROM titrechant WHERE idCategorie='KYRIE'", con);
                MySqlDataReader kyrie = cmd.ExecuteReader();
                cbKyrie.Items.Clear();
                while (kyrie.Read())
                {
                    cbKyrie.Items.Add(kyrie[1].ToString());
                }
                kyrie.Close();

                //Selection de chants GLORIA......................................

                cmd = new MySqlCommand("SELECT * FROM titrechant WHERE idCategorie='GLORIA'", con);
                MySqlDataReader gloria = cmd.ExecuteReader();
                cbGloria.Items.Clear();
                while (gloria.Read())
                {
                    cbGloria.Items.Add(gloria[1].ToString());
                }
                gloria.Close();


                //Selection de chants VD......................................

                cmd = new MySqlCommand("SELECT * FROM titrechant WHERE idCategorie='VD'", con);
                MySqlDataReader vd = cmd.ExecuteReader();
                cbV_D.Items.Clear();
                while (vd.Read())
                {
                    cbV_D.Items.Add(vd[1].ToString());
                }
                vd.Close();


                //Selection de chants Meditation......................................

                cmd = new MySqlCommand("SELECT * FROM titrechant WHERE idCategorie='MEDITATION PSAUME'", con);
                MySqlDataReader ps = cmd.ExecuteReader();
                cbMeditation.Items.Clear();
                while (ps.Read())
                {
                    cbMeditation.Items.Add(ps[1].ToString());
                }
                ps.Close();

                //Selection de chants Acclamation......................................

                cmd = new MySqlCommand("SELECT * FROM titrechant WHERE idCategorie='ACCLAMATION'", con);
                MySqlDataReader cll = cmd.ExecuteReader();
                cbAcclamation.Items.Clear();
                while (cll.Read())
                {
                    cbAcclamation.Items.Add(cll[1].ToString());
                }
                cll.Close();

                //Selection de chants Acclamation......................................

                cmd = new MySqlCommand("SELECT * FROM titrechant WHERE idCategorie='P.U'", con);
                MySqlDataReader pu = cmd.ExecuteReader();
                cbP_U.Items.Clear();
                while (pu.Read())
                {
                    cbP_U.Items.Add(pu[1].ToString());
                }
                pu.Close();

                //Selection de chants Acclamation......................................

                cmd = new MySqlCommand("SELECT * FROM titrechant WHERE idCategorie='OFFERTOIRE'", con);
                MySqlDataReader offf = cmd.ExecuteReader();
                cbOffertoir1.Items.Clear();
                cbOffertoire2.Items.Clear();
                while (offf.Read())
                {
                    cbOffertoir1.Items.Add(offf[1].ToString());
                    cbOffertoire2.Items.Add(offf[1].ToString());
                }
                offf.Close();

                //Selection de chants SANCTUS......................................

                cmd = new MySqlCommand("SELECT * FROM titrechant WHERE idCategorie='SANCTUS'", con);
                MySqlDataReader sanc = cmd.ExecuteReader();
                cbSanctus.Items.Clear();
                while (sanc.Read())
                {
                    cbSanctus.Items.Add(sanc[1].ToString());
                }
                sanc.Close();

                //Selection de chants AGNUS DEI......................................

                cmd = new MySqlCommand("SELECT * FROM titrechant WHERE idCategorie='AD'", con);
                MySqlDataReader ad = cmd.ExecuteReader();
                cbA_D.Items.Clear();
                while (ad.Read())
                {
                    cbA_D.Items.Add(ad[1].ToString());
                }
                ad.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur "+ex);
                con.Close();
            }
        }

        private void pnlAddchant_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddChant_Click(object sender, EventArgs e)
        {
            Form3 pro = new Form3();
            lbTitre.Text = "ARRANGEMENT D'UN NOUVEAU PROGRAMME";
            button1.Visible = true;
            button2.Visible = true;
            btnModife.Visible = false;
            pro.Show();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            pnlAddchant.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mettre l'argistrement d'un nouveau programme .........................................................


        }

        private void btnModife_Click(object sender, EventArgs e)
        {
            //Modification du programme..............................................................................


        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            pnlAddchant.Visible = !pnlAddchant.Visible;
            lbTitre.Text = "MODIFICATION DU PROGRAMME";
            button1.Visible = false;
            button2.Visible = false;
            btnModife.Visible = true;
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Recherche...........................")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Recherche...........................";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void cbInvitatoire_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbInvitatoire.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtInvitatoire1.Text = "-1";
            if (In1.Read())
            {
                txtInvitatoire1.Text=In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbInvitatoire2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbInvitatoire2.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtInvitatoire2.Text = "-1";
            
            if (In1.Read())
            {
                txtInvitatoire2.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbEntree_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbEntree.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtEntree1.Text = "-1";
            if (In1.Read())
            {
                txtEntree1.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbEntree2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbEntree2.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtEntree2.Text = "-1";
            if (In1.Read())
            {
                txtEntree2.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbKyrie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbKyrie.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtKyrie.Text = "-1";
            if (In1.Read())
            {
                txtKyrie.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbGloria_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbGloria.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
           txtGloria.Text="-1";
            if (In1.Read())
            {
                txtGloria.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbV_D_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbV_D.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtV_D.Text = "-1";
            if (In1.Read())
            {
                txtV_D.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbMeditation_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbMeditation.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtMeditation.Text = "-1";
            if (In1.Read())
            {
                txtMeditation.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbAcclamation_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbAcclamation.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtAcclamation.Text = "-1";
            if (In1.Read())
            {
                txtAcclamation.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbP_U_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbP_U.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtP_U.Text = "-1";
            if (In1.Read())
            {
                txtP_U.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbOffertoir1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbOffertoir1.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtOffertoire1.Text = "- 1";
            if (In1.Read())
            {
                txtOffertoire1.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbOffertoire2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbOffertoire2.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtOffertoire2.Text = "-1";
            if (In1.Read())
            {
                txtOffertoire2.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbSanctus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbSanctus.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtSanctus.Text = "-1";
            if (In1.Read())
            {
                txtSanctus.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbA_D_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbA_D.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtA_D.Text = "-1";
            if (In1.Read())
            {
                txtA_D.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbCommunion1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbCommunion1.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtCommunion1.Clear();
            if (In1.Read())
            {
                txtCommunion1.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbCommunion2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbCommunion2.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtCommunion2.Text = "-1";
            if (In1.Read())
            {
                txtCommunion2.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbA_G1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbA_G1.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtA_G1.Text = "-1";
            if (In1.Read())
            {
                txtA_G1.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbA_G2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbA_G2.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtA_G2.Text = "-1";
            if (In1.Read())
            {
                txtA_G2.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbA_G3_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbA_G3.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtA_G3.Text = "-1";
            if (In1.Read())
            {
                txtA_G3.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void cbSortie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new MySqlCommand("SELECT idTitre FROM titrechant WHERE titre='" + cbSortie.Text + "'", con);
            con.Open();
            MySqlDataReader In1 = cmd.ExecuteReader();
            txtSortie.Text = "-1";
            if (In1.Read())
            {
                txtSortie.Text = In1[0].ToString();
            }
            In1.Close();
            con.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (ChampObligatoire()!=null)
                {
                    MessageBox.Show(ChampObligatoire());
                }
                else
                {
                    //Conversion du format de la date
                    string dateConvete = string.Format("{0}-{1}-{2}", dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                    cmd = new MySqlCommand("INSERT INTO programme( dateProgramme, periode, invitatoire,invitatoire2,entree,entree2,kyrie,gloria,vd,meditation,acclamation,pu, offertoire, offertoire2,sanctus,ad,communion,communion2,ag,ag2, ag3,sortie)VALUES('" + dateConvete + "','" + txtPeriode.Text + "','" + txtInvitatoire1.Text + "','" + txtInvitatoire2.Text + "','" + txtEntree1.Text + "','" + txtEntree2.Text + "','" + txtKyrie.Text + "','" + txtGloria.Text + "','" + txtV_D.Text + "','" + txtMeditation.Text + "','" + txtAcclamation.Text + "','" + txtP_U.Text + "','" + txtOffertoire1.Text + "','" + txtOffertoire2.Text + "','" + txtSanctus.Text + "','" + txtA_D.Text + "','" + txtCommunion1.Text + "','" + txtCommunion2.Text + "','" + txtA_G1.Text + "','" + txtA_G2.Text + "','" + txtA_G3.Text + "','" + txtSortie.Text + "')", con);
                    con.Open();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Enregistrement réussi");
                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Echec");
                        con.Close();
                    }
                }
                
               
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur "+ex);
                con.Close();
            }
        }
        // Fonction de verification ....................
        string ChampObligatoire()
        {
            if (cbEntree.Text=="")
            {
                return "Choisissez le chant d'entrée";
            }
            if (cbInvitatoire.Text == "")
            {
                return "Choisissez le chant d'invitatoire";
            }
            if (cbV_D.Text=="")
            {
                return "Choisissez le chant pour le VD";
            }
            if (cbGloria.Text == "")
            {
                return "Choisissez le chant de Gloria";
            }
            if (cbKyrie.Text == "")
            {
                return "Choisissez le chant de Kyrie";
            }
            if (cbMeditation.Text == "")
            {
                return "Choisissez le chant de la méditation";
            }
            if (cbAcclamation.Text == "")
            {
                return "Choisissez le chant de l'acclamation";
            }
            if (cbP_U.Text == "")
            {
                return "Choisissez le chant de la prière universelle";
            }
            if (cbOffertoir1.Text == "")
            {
                return "Choisissez le chant de l'offertoire";
            }
            if (cbSanctus.Text == "")
            {
                return "Choisissez le Sanctus";
            }
            if (cbA_G1.Text == "")
            {
                return "Choisissez le chant  D'action de grâce";
            }
            if (cbCommunion1.Text == "")
            {
                return "Choisissez le chant de la communion";
            }
            if (cbA_D.Text == "")
            {
                return "Choisissez l AD";
            }
            if (cbSortie.Text == "")
            {
                return "Choisissez le chant de la sortie";
            }
            return null;
        }

        void afficher(string d)
        {
            models.Database db = new models.Database();
            var con = db.getConnection();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM programme WHERE titreProgramme like '%" + d + "%'", con);
            MySqlDataReader rd = cmd.ExecuteReader();
            dgtProgramme.Rows.Clear();
            int co = 0;
            while (rd.Read())
            {
                co++;
                dgtProgramme.Rows.Add(co,rd[0].ToString(), rd[1].ToString(), rd[2].ToString(), rd[3].ToString());
            }
            rd.Close();
            con.Close();
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            afficher("");
        }

        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Impression 
            //Forms.Fr_Programmes p = new Forms.Fr_Programmes();
            Form4 p = new Form4();
            if (dgtProgramme.CurrentCell!=null)
            {
                int id = int.Parse(dgtProgramme.CurrentRow.Cells[1].Value.ToString());
                p.txtId.Text = id.ToString();
                p.Show();
            }
        }
    }
}
