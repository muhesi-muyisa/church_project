using appProramme_messe.models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appProramme_messe
{
    public partial class Form3 : Form
    {
        // Connexion à la base de données
        MySqlConnection con = new MySqlConnection("server=localhost;database=programme_sj;user='root';pwd=''");
        MySqlCommand cmd;
        private string memntion="";

        // Instance 
        models.Programme programme = new Programme();
        public Form3()
        {
            InitializeComponent();
            detailChant.Visible = false;
            affichage("");
            AffCategorie();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void affichage(string resaeh)
        {
            try
            {
                cmd = new MySqlCommand("SELECT * FROM titrechant WHERE titre LIKE '%"+resaeh+ "%' || idCategorie LIKE '%"+resaeh+"%'", con);
                con.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                int verify = 0;
                dgtChants.Rows.Clear();
                while (dr.Read())
                {
                    verify++;
                    dgtChants.Rows.Add(verify.ToString(), dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                }
                dr.Close();
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur " + ex);
                con.Close();
            }
        }

        private void aJOUTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ajouter Chants D'invitatoire
            memntion = "invitatoire";
            detailChant.Visible = true;
        }

        private void sUPPRIMERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Supprimer le chant d'invitatoire
            if (dgvInvitatoire.CurrentRow != null)
            {
                DialogResult rr = MessageBox.Show("Voulez vou supprimer ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rr == DialogResult.Yes)
                {
                    // Index
                    int index = models.Listes.listInvit.FindIndex(s => s.id == int.Parse(dgvInvitatoire.CurrentRow.Cells[0].Value.ToString()));
                    models.Listes.listInvit.RemoveAt(index);
                    MessageBox.Show("Suppression avec succès");

                    // Actualiser 
                    actualise_dgvIvite();
                }
                else
                {
                    MessageBox.Show("Suppression annulée");
                }

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Ajouter Chants D'entree
            memntion = "entree";
            detailChant.Visible = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Supprimer Chant d'entree
            if (dgvEntree.CurrentRow != null)
            {
                DialogResult rr = MessageBox.Show("Voulez vou supprimer ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rr == DialogResult.Yes)
                {
                    // Index
                    int index = models.ListEnter.listEntre.FindIndex(s => s.id == int.Parse(dgvEntree.CurrentRow.Cells[0].Value.ToString()));
                    models.ListEnter.listEntre.RemoveAt(index);
                    MessageBox.Show("Suppression avec succès");

                    // Actualiser 
                    actualise_dgvIvite();
                }
                else
                {
                    MessageBox.Show("Suppression annulée");
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // Ajouter Chants De kyrie
            memntion = "kyrie";
            detailChant.Visible = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            //supprimer chant de kyrie
            if (dgvKyrie.CurrentRow != null)
            {
                DialogResult rr = MessageBox.Show("Voulez vou supprimer ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rr == DialogResult.Yes)
                {
                    // Index
                    int index = models.ListKyrie.listKyrie.FindIndex(s => s.id == int.Parse(dgvKyrie.CurrentRow.Cells[0].Value.ToString()));
                    models.ListKyrie.listKyrie.RemoveAt(index);
                    MessageBox.Show("Suppression avec succès");

                    // Actualiser 
                    actualise_dgvIvite();
                }
                else
                {
                    MessageBox.Show("Suppression annulée");
                }
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            // Ajouter Chants De gloria
            memntion = "gloria";
            detailChant.Visible = true;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            // Supprimer chant de gloria
            
            if (dgvGloria.CurrentRow != null)
            {
                DialogResult rr = MessageBox.Show("Voulez vou supprimer ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rr == DialogResult.Yes)
                {
                    // Index
                    int index = models.ListGloria.listGloria.FindIndex(s => s.id == int.Parse(dgvGloria.CurrentRow.Cells[0].Value.ToString()));
                    models.ListGloria.listGloria.RemoveAt(index);
                    MessageBox.Show("Suppression avec succès");

                    // Actualiser 
                    actualise_dgvIvite();
                }
                else
                {
                    MessageBox.Show("Suppression annulée");
                }
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            // Ajouter Chants D Vd
            memntion = "vd";
            detailChant.Visible = true;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            // Supprimer chant VD
            if (dgvVD.CurrentRow != null)
            {
                DialogResult rr = MessageBox.Show("Voulez vou supprimer ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rr == DialogResult.Yes)
                {
                    // Index
                    int index = models.ListVD.listVd.FindIndex(s => s.id == int.Parse(dgvVD.CurrentRow.Cells[0].Value.ToString()));
                    models.ListVD.listVd.RemoveAt(index);
                    MessageBox.Show("Suppression avec succès");

                    // Actualiser 
                    actualise_dgvIvite();
                }
                else
                {
                    MessageBox.Show("Suppression annulée");
                }
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            // Ajouter Chants D acclamation
            memntion = "acclamation";
            detailChant.Visible = true;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            //Supprimer chant d'acclamation
            if (dvAcclamation.CurrentRow != null)
            {
                DialogResult rr = MessageBox.Show("Voulez vou supprimer ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rr == DialogResult.Yes)
                {
                    // Index
                    int index = models.ListAccl.listAccl.FindIndex(s => s.id == int.Parse(dvAcclamation.CurrentRow.Cells[0].Value.ToString()));
                    models.ListAccl.listAccl.RemoveAt(index);
                    MessageBox.Show("Suppression avec succès");

                    // Actualiser 
                    actualise_dgvIvite();
                }
                else
                {
                    MessageBox.Show("Suppression annulée");
                }
            }
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            // Ajouter Chants D médiation
            memntion = "meditation";
            detailChant.Visible = true;
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            //Supprimer Chant de méditation
            if (dgvMeditation.CurrentRow != null)
            {
                DialogResult rr = MessageBox.Show("Voulez vou supprimer ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rr == DialogResult.Yes)
                {
                    // Index
                    int index = models.ListMedit.listMedit.FindIndex(s => s.id == int.Parse(dgvMeditation.CurrentRow.Cells[0].Value.ToString()));
                    models.ListMedit.listMedit.RemoveAt(index);
                    MessageBox.Show("Suppression avec succès");

                    // Actualiser 
                    actualise_dgvIvite();
                }
                else
                {
                    MessageBox.Show("Suppression annulée");
                }
            }
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            // Ajouter Chants D PU
            memntion = "pu";
            detailChant.Visible = true;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            // Supprimer chant de PU
            
            if (dgvPU.CurrentRow != null)
            {
                DialogResult rr = MessageBox.Show("Voulez vou supprimer ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rr == DialogResult.Yes)
                {
                    // Index
                    int index = models.ListPU.listPUl.FindIndex(s => s.id == int.Parse(dgvPU.CurrentRow.Cells[0].Value.ToString()));
                    models.ListPU.listPUl.RemoveAt(index);
                    MessageBox.Show("Suppression avec succès");

                    // Actualiser 
                    actualise_dgvIvite();
                }
                else
                {
                    MessageBox.Show("Suppression annulée");
                }
            }
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            // Ajouter Chants D'offertoire
            memntion = "offertoire";
            detailChant.Visible = true;
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            //Supprimer chant d'offertoire
            if (dgvOffertoire.CurrentRow != null)
            {
                DialogResult rr = MessageBox.Show("Voulez vou supprimer ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rr == DialogResult.Yes)
                {
                    // Index
                    int index = models.ListOffertoire.listOff.FindIndex(s => s.id == int.Parse(dgvOffertoire.CurrentRow.Cells[0].Value.ToString()));
                    models.ListOffertoire.listOff.RemoveAt(index);
                    MessageBox.Show("Suppression avec succès");

                    // Actualiser 
                    actualise_dgvIvite();
                }
                else
                {
                    MessageBox.Show("Suppression annulée");
                }
            }
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            // Ajouter Chants D Sanctus
            memntion = "sanctus";
            detailChant.Visible = true;
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            //Supprimer chant d sanctus
            if (dgvSanctus.CurrentRow != null)
            {
                DialogResult rr = MessageBox.Show("Voulez vou supprimer ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rr == DialogResult.Yes)
                {
                    // Index
                    int index = models.ListSanctus.listSanctus.FindIndex(s => s.id == int.Parse(dgvSanctus.CurrentRow.Cells[0].Value.ToString()));
                    models.ListSanctus.listSanctus.RemoveAt(index);
                    MessageBox.Show("Suppression avec succès");

                    // Actualiser 
                    actualise_dgvIvite();
                }
                else
                {
                    MessageBox.Show("Suppression annulée");
                }
            }
        }

        private void ctAD_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            // Ajouter Chants D AD
            memntion = "ad";
            detailChant.Visible = true;
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            //Suppersion de chant AD
            if (dgvAD.CurrentRow != null)
            {
                DialogResult rr = MessageBox.Show("Voulez vou supprimer ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rr == DialogResult.Yes)
                {
                    // Index
                    int index = models.ListAD.listAD.FindIndex(s => s.id == int.Parse(dgvAD.CurrentRow.Cells[0].Value.ToString()));
                    models.ListAD.listAD.RemoveAt(index);
                    MessageBox.Show("Suppression avec succès");

                    // Actualiser 
                    actualise_dgvIvite();
                }
                else
                {
                    MessageBox.Show("Suppression annulée");
                }
            }
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            // Ajouter Chants D communion
            memntion = "communion";
            detailChant.Visible = true;
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            // Suppression chant de communion
            if (dgvCommunion.CurrentRow != null)
            {
                DialogResult rr = MessageBox.Show("Voulez vou supprimer ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rr == DialogResult.Yes)
                {
                    // Index
                    int index = models.ListComm.listComm.FindIndex(s => s.id == int.Parse(dgvCommunion.CurrentRow.Cells[0].Value.ToString()));
                    models.ListComm.listComm.RemoveAt(index);
                    MessageBox.Show("Suppression avec succès");

                    // Actualiser 
                    actualise_dgvIvite();
                }
                else
                {
                    MessageBox.Show("Suppression annulée");
                }
            }
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            // Ajouter Chants D AG
            memntion = "ag";
            detailChant.Visible = true;
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            // Suppression chant AG
            if (dgvAG.CurrentRow != null)
            {
                DialogResult rr = MessageBox.Show("Voulez vou supprimer ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rr == DialogResult.Yes)
                {
                    // Index
                    int index = models.ListAG.listAg.FindIndex(s => s.id == int.Parse(dgvAG.CurrentRow.Cells[0].Value.ToString()));
                    models.ListAG.listAg.RemoveAt(index);
                    MessageBox.Show("Suppression avec succès");

                    // Actualiser 
                    actualise_dgvIvite();
                }
                else
                {
                    MessageBox.Show("Suppression annulée");
                }
            }
        }

        private void ctSortie_Opening(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            // Ajouter Chants D SORTIE
            memntion = "sortie";
            detailChant.Visible = true;
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            //Suppression chants de sortie
            if (dgvSortie.CurrentRow != null)
            {
                DialogResult rr = MessageBox.Show("Voulez vou supprimer ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rr == DialogResult.Yes)
                {
                    // Index
                    int index = models.ListSortie.listSortie.FindIndex(s => s.id == int.Parse(dgvSortie.CurrentRow.Cells[0].Value.ToString()));
                    models.ListSortie.listSortie.RemoveAt(index);
                    MessageBox.Show("Suppression avec succès");

                    // Actualiser 
                    actualise_dgvIvite();
                }
                else
                {
                    MessageBox.Show("Suppression annulée");
                }
            }
        }

        private void txtCouplets_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            detailChant.Visible = false;
        }

        private void dgtChants_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgtChants.CurrentCell.Value!=null)
            {
                txtCouplets.Text = dgtChants.CurrentRow.Cells[3].Value.ToString();
                txtIdChants.Text= dgtChants.CurrentRow.Cells[1].Value.ToString();
                txtTitreChant.Text= dgtChants.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnModife_Click(object sender, EventArgs e)
        {
            if (txtIdChants.Text!=null)
            {
                try
                {
                    if (memntion == "invitatoire")
                    {
                        models.Listes invitatoire = new models.Listes
                        {
                            id = int.Parse(txtIdChants.Text),
                            titre = txtTitreChant.Text,
                            game = txtGame.Text,
                        };
                        if (models.Listes.listInvit.SingleOrDefault(s => s.id == invitatoire.id) != null)
                        {
                            MessageBox.Show("Le Chant a été selectionné");
                        }
                        else
                        {
                            models.Listes.listInvit.Add(invitatoire);
                        }
                    }
                    if (memntion == "entree")
                    {
                        models.ListEnter entree = new models.ListEnter
                        {
                            id = int.Parse(txtIdChants.Text),
                            titre = txtTitreChant.Text,
                            game = txtGame.Text,
                        };
                        if (models.ListEnter.listEntre.SingleOrDefault(s => s.id == entree.id) != null)
                        {
                            MessageBox.Show("Le Chant a été selectionné");
                        }
                        else
                        {
                            models.ListEnter.listEntre.Add(entree);
                        }
                    }
                    if (memntion == "kyrie")
                    {
                        models.ListKyrie kyrie = new models.ListKyrie()
                        {
                            id = int.Parse(txtIdChants.Text),
                            titre = txtTitreChant.Text,
                            game = txtGame.Text,
                        };
                        if (models.ListKyrie.listKyrie.SingleOrDefault(s => s.id == kyrie.id) != null)
                        {
                            MessageBox.Show("Le Chant a été selectionné");
                        }
                        else
                        {
                            models.ListKyrie.listKyrie.Add(kyrie);
                        }
                    }

                    if (memntion == "gloria")
                    {
                        models.ListGloria gloria = new models.ListGloria()
                        {
                            id = int.Parse(txtIdChants.Text),
                            titre = txtTitreChant.Text,
                            game = txtGame.Text,
                        };
                        if (models.ListGloria.listGloria.SingleOrDefault(s => s.id == gloria.id) != null)
                        {
                            MessageBox.Show("Le Chant a été selectionné");
                        }
                        else
                        {
                            models.ListGloria.listGloria.Add(gloria);
                        }
                    }

                    if (memntion == "vd")
                    {
                        models.ListVD vd = new models.ListVD()
                        {
                            id = int.Parse(txtIdChants.Text),
                            titre = txtTitreChant.Text,
                            game = txtGame.Text,
                        };
                        if (models.ListVD.listVd.SingleOrDefault(s => s.id == vd.id) != null)
                        {
                            MessageBox.Show("Le Chant a été selectionné");
                        }
                        else
                        {
                            models.ListVD.listVd.Add(vd);
                        }
                    }

                    if (memntion == "acclamation")
                    {
                        models.ListAccl accl = new models.ListAccl()
                        {
                            id = int.Parse(txtIdChants.Text),
                            titre = txtTitreChant.Text,
                            game = txtGame.Text,
                        };
                        if (models.ListAccl.listAccl.SingleOrDefault(s => s.id == accl.id) != null)
                        {
                            MessageBox.Show("Le Chant a été selectionné");
                        }
                        else
                        {
                            models.ListAccl.listAccl.Add(accl);
                        }
                    }
                    if (memntion == "meditation")
                    {
                        models.ListMedit meditation = new models.ListMedit()
                        {
                            id = int.Parse(txtIdChants.Text),
                            titre = txtTitreChant.Text,
                            game = txtGame.Text,
                        };
                        if (models.ListMedit.listMedit.SingleOrDefault(s => s.id == meditation.id) != null)
                        {
                            MessageBox.Show("Le Chant a été selectionné");
                        }
                        else
                        {
                            models.ListMedit.listMedit.Add(meditation);
                        }
                    }

                    if (memntion == "pu")
                    {
                        models.ListPU pu = new models.ListPU()
                        {
                            id = int.Parse(txtIdChants.Text),
                            titre = txtTitreChant.Text,
                            game = txtGame.Text,
                        };
                        if (models.ListPU.listPUl.SingleOrDefault(s => s.id == pu.id) != null)
                        {
                            MessageBox.Show("Le Chant a été selectionné");
                        }
                        else
                        {
                            models.ListPU.listPUl.Add(pu);
                        }
                    }

                    if (memntion == "offertoire")
                    {
                        models.ListOffertoire offert = new models.ListOffertoire()
                        {
                            id = int.Parse(txtIdChants.Text),
                            titre = txtTitreChant.Text,
                            game = txtGame.Text,
                        };
                        if (models.ListOffertoire.listOff.SingleOrDefault(s => s.id == offert.id) != null)
                        {
                            MessageBox.Show("Le Chant a été selectionné");
                        }
                        else
                        {
                            models.ListOffertoire.listOff.Add(offert);
                        }
                    }

                    if (memntion == "sanctus")
                    {
                        models.ListSanctus sanctus = new models.ListSanctus()
                        {
                            id = int.Parse(txtIdChants.Text),
                            titre = txtTitreChant.Text,
                            game = txtGame.Text,
                        };
                        if (models.ListSanctus.listSanctus.SingleOrDefault(s => s.id == sanctus.id) != null)
                        {
                            MessageBox.Show("Le Chant a été selectionné");
                        }
                        else
                        {
                            models.ListSanctus.listSanctus.Add(sanctus);
                        }
                    }


                    if (memntion == "ad")
                    {
                        models.ListAD ad = new models.ListAD()
                        {
                            id = int.Parse(txtIdChants.Text),
                            titre = txtTitreChant.Text,
                            game = txtGame.Text,
                        };
                        if (models.ListAD.listAD.SingleOrDefault(s => s.id == ad.id) != null)
                        {
                            MessageBox.Show("Le Chant a été selectionné");
                        }
                        else
                        {
                            models.ListAD.listAD.Add(ad);
                        }
                    }

                    if (memntion == "communion")
                    {
                        models.ListComm comm = new models.ListComm()
                        {
                            id = int.Parse(txtIdChants.Text),
                            titre = txtTitreChant.Text,
                            game = txtGame.Text,
                        };
                        if (models.ListComm.listComm.SingleOrDefault(s => s.id == comm.id) != null)
                        {
                            MessageBox.Show("Le Chant a été selectionné");
                        }
                        else
                        {
                            models.ListComm.listComm.Add(comm);
                        }
                    }

                    if (memntion == "ag")
                    {
                        models.ListAG ag = new ListAG()
                        {
                            id = int.Parse(txtIdChants.Text),
                            titre = txtTitreChant.Text,
                            game = txtGame.Text,
                        };
                        if (models.ListAG.listAg.SingleOrDefault(s => s.id == ag.id) != null)
                        {
                            MessageBox.Show("Le Chant a été selectionné");
                        }
                        else
                        {
                            models.ListAG.listAg.Add(ag);
                        }
                    }

                    if (memntion == "sortie")
                    {
                        models.ListSortie sortie = new ListSortie()
                        {
                            id = int.Parse(txtIdChants.Text),
                            titre = txtTitreChant.Text,
                            game = txtGame.Text,
                        };
                        if (models.ListSortie.listSortie.SingleOrDefault(s => s.id == sortie.id) != null)
                        {
                            MessageBox.Show("Le Chant a été selectionné");
                        }
                        else
                        {
                            models.ListSortie.listSortie.Add(sortie);
                        }
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Selectionnez un chant");
                }

               
                // Actualiser le dgvdetailCommande 

                txtIdChants.Clear();
                detailChant.Visible = false;
            }
            else
            {
                MessageBox.Show("veuillez selectionner au moins un chant");
            }
            actualise_dgvIvite();

        }



        public void actualise_dgvIvite()
        {
            dgvInvitatoire.Rows.Clear();
            foreach (var item in models.Listes.listInvit)
            {
                dgvInvitatoire.Rows.Add(item.id, item.titre,item.game);
            }


            dgvEntree.Rows.Clear();
            foreach (var item in models.ListEnter.listEntre)
            {
                dgvEntree.Rows.Add(item.id, item.titre, item.game);
            }

            dgvKyrie.Rows.Clear();
            foreach (var item in models.ListKyrie.listKyrie)
            {
                dgvKyrie.Rows.Add(item.id, item.titre, item.game);
            }
            dgvGloria.Rows.Clear();
            foreach (var item in models.ListGloria.listGloria)
            {
                dgvGloria.Rows.Add(item.id, item.titre, item.game);
            }
            dgvVD.Rows.Clear();
            foreach (var item in models.ListVD.listVd)
            {
                dgvVD.Rows.Add(item.id, item.titre, item.game);
            }
            dvAcclamation.Rows.Clear();
            foreach (var item in models.ListAccl.listAccl)
            {
                dvAcclamation.Rows.Add(item.id, item.titre, item.game);
            }
            dgvMeditation.Rows.Clear();
            foreach (var item in models.ListMedit.listMedit)
            {
                dgvMeditation.Rows.Add(item.id, item.titre, item.game);
            }
            dgvPU.Rows.Clear();
            foreach (var item in models.ListPU.listPUl)
            {
                dgvPU.Rows.Add(item.id, item.titre, item.game);
            }
            dgvOffertoire.Rows.Clear();
            foreach (var item in models.ListOffertoire.listOff)
            {
                dgvOffertoire.Rows.Add(item.id, item.titre, item.game);
            }
            dgvSanctus.Rows.Clear();
            foreach (var item in models.ListSanctus.listSanctus)
            {
                dgvSanctus.Rows.Add(item.id, item.titre, item.game);
            }
            dgvAD.Rows.Clear();
            foreach (var item in models.ListAD.listAD)
            {
                dgvAD.Rows.Add(item.id, item.titre, item.game);
            }
            dgvCommunion.Rows.Clear();
            foreach (var item in models.ListComm.listComm)
            {
                dgvCommunion.Rows.Add(item.id, item.titre, item.game);
            }
            dgvAG.Rows.Clear();
            foreach (var item in models.ListAG.listAg)
            {
                dgvAG.Rows.Add(item.id, item.titre, item.game);
            }
            dgvSortie.Rows.Clear();
            foreach (var item in models.ListSortie.listSortie)
            {
                dgvSortie.Rows.Add(item.id, item.titre, item.game);
            }

        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            if (txtRecherche.Text != "Recherche..........................." && txtRecherche.Text != "")
            {
                affichage(txtRecherche.Text);
            }
            else affichage("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Enregistrement 
            if (txtPeriode.Text!="" && cmbCategorie.Text!="")
            {
                string dateCreate=  string.Format("{0}-{1}-{2}", dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                Random rm= new Random();
                int num= rm.Next();
                if (programme.addProgramme(num,txtPeriode.Text,dateCreate,cmbCategorie.Text)==true)
                {
                    string categorie;
                    
                    foreach (var item1 in models.Listes.listInvit)
                    {
                        categorie = "Invitatoire";
                        programme.addDatailProgramme(num, item1.id, categorie);
                    }
                    foreach (var item2 in models.ListEnter.listEntre)
                    {
                        categorie = "Entree";
                        programme.addDatailProgramme(num, item2.id,categorie);
                    }
                    foreach (var item3 in models.ListKyrie.listKyrie)
                    {
                        categorie = "Kyrie";
                        programme.addDatailProgramme(num, item3.id, categorie);
                    }
                    foreach (var item4 in models.ListGloria.listGloria)
                    {
                        categorie = "Gloria";
                        programme.addDatailProgramme(num, item4.id, categorie);
                    }
                    foreach (var item5 in models.ListVD.listVd)
                    {
                        categorie = "Vd";
                        programme.addDatailProgramme(num, item5.id, categorie);
                    }
                    foreach (var item7 in models.ListMedit.listMedit)
                    {
                        categorie = "Méditation";
                        programme.addDatailProgramme(num, item7.id, categorie);
                    }
                    foreach (var item6 in models.ListAccl.listAccl)
                    {
                        categorie = "Acclamation";
                        programme.addDatailProgramme(num, item6.id, categorie);
                    }
                    
                    foreach (var item8 in models.ListPU.listPUl)
                    {
                        categorie = "Pu";
                        programme.addDatailProgramme(num, item8.id, categorie);
                    }
                    foreach (var item9 in models.ListOffertoire.listOff)
                    {
                        categorie = "Offertoire";
                        programme.addDatailProgramme(num, item9.id, categorie);
                    }
                    foreach (var item10 in models.ListSanctus.listSanctus)
                    {
                        categorie = "Sanctus";
                        programme.addDatailProgramme(num, item10.id, categorie);
                    }
                    foreach (var item11 in models.ListAD.listAD)
                    {
                        categorie = "Agnus Déui";
                        programme.addDatailProgramme(num, item11.id, categorie);
                    }
                    foreach (var item12 in models.ListComm.listComm)
                    {
                        categorie = "Communion";
                        programme.addDatailProgramme(num, item12.id, categorie);
                    }
                    
                    foreach (var item in models.ListAG.listAg)
                    {
                        categorie = "Action de Grâce";
                        programme.addDatailProgramme(num, item.id,categorie);
                    }
                    foreach (var item13 in models.ListSortie.listSortie)
                    {
                        categorie = "Sortie";
                        programme.addDatailProgramme(num, item13.id, categorie);
                    }

                    MessageBox.Show("Enregistrement réussi");
                    vidage();
                    actualise_dgvIvite();
                }
                else
                {
                    MessageBox.Show("Echec d'enregistrement");
                }
            }
            else
            {
                MessageBox.Show("Compléter tous les champs");
            }


        }

        private void txtGame_Leave(object sender, EventArgs e)
        {
            if (txtGame.Text=="")
            {
                txtGame.Text = "Entrez la game";
            }
        }

        private void txtGame_Enter(object sender, EventArgs e)
        {
            if (txtGame.Text== "Entrez la game")
            {
                txtGame.Text = "";
            }
        }

        void AffCategorie()
        {
            models.Database db = new models.Database();
            var con = db.getConnection();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM categorie ", con);
            MySqlDataReader rd = cmd.ExecuteReader();
            cmbCategorie.Items.Clear();
            while (rd.Read())
            {
                cmbCategorie.Items.Add(rd[1].ToString());
            }
            rd.Close();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.Categorie cat= new Forms.Categorie();
            cat.Show();
        }
        public void vidage()
        {
            models.Listes.listInvit.Clear();
            models.ListEnter.listEntre.Clear();
            models.ListKyrie.listKyrie.Clear();
            models.ListGloria.listGloria.Clear();
            models.ListVD.listVd.Clear();
            models.ListMedit.listMedit.Clear();
            models.ListAccl.listAccl.Clear();
            models.ListPU.listPUl.Clear();
            models.ListOffertoire.listOff.Clear();
            models.ListSanctus.listSanctus.Clear();
            models.ListAD.listAD.Clear();
            models.ListComm.listComm.Clear();
            models.ListAG.listAg.Clear();
            models.ListSortie.listSortie.Clear();
        }

        private void txtRecherche_Leave(object sender, EventArgs e)
        {
            if (txtRecherche.Text == "") txtRecherche.Text = "Recherche...........................";
        }

        private void txtRecherche_Enter(object sender, EventArgs e)
        {
            if (txtRecherche.Text== "Recherche...........................")
            {
                txtRecherche.Text = "";
            }
        }
    }
}
