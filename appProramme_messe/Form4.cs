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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtId.Text!="")
            {
                try 
                {
                    // TODO: cette ligne de code charge les données dans la table 'DataSet1.Programmess'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
                this.ProgrammessTableAdapter.Fill(this.DataSet1.Programmess,int.Parse(txtId.Text));

                this.reportViewer1.RefreshReport();
                }
                catch (Exception xe) { MessageBox.Show(xe.Message); }
            }
        }
    }
}
