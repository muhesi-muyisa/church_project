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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!pnlPrincipal.Controls.Contains(controlsUser.gestion_chant.instance))
            {
                pnlPrincipal.Controls.Add(controlsUser.gestion_chant.instance);
                controlsUser.gestion_chant.instance.Dock = DockStyle.Fill;
                controlsUser.gestion_chant.instance.BringToFront();
            }
            else
            {
                controlsUser.gestion_chant.instance.BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!pnlPrincipal.Controls.Contains(controlsUser.gestion_user.instance))
            {
                pnlPrincipal.Controls.Add(controlsUser.gestion_user.instance);
                controlsUser.gestion_user.instance.Dock = DockStyle.Fill;
                controlsUser.gestion_user.instance.BringToFront();
            }
            else
            {
                controlsUser.gestion_user.instance.BringToFront();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!pnlPrincipal.Controls.Contains(controlsUser.gestion_programme.instance))
            {
                pnlPrincipal.Controls.Add(controlsUser.gestion_programme.instance);
                controlsUser.gestion_programme.instance.Dock = DockStyle.Fill;
                controlsUser.gestion_programme.instance.BringToFront();
            }
            else
            {
                controlsUser.gestion_programme.instance.BringToFront();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 app = new Form2();
            app.Show();
        }
    }
}
