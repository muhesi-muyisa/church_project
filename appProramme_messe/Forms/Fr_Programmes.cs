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

namespace appProramme_messe.Forms
{
    public partial class Fr_Programmes : Form
    {
        public Fr_Programmes()
        {
            InitializeComponent();
        }


        public void myprogramme()
        {
            if (textBox1.Text!="")
            {
                models.Database con = new models.Database();
                CR_programmes fcli = new CR_programmes();
                var db = con.getConnection();
                try
                {
                    db.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM programmes WHERE id='" + int.Parse(textBox1.Text) + "'", db);
                    MySqlDataAdapter ada = new MySqlDataAdapter(cmd);
                    DataSet1 ds = new DataSet1();
                    ada.Fill(ds, "programmes");
                    fcli.SetDataSource(ds.Tables["programmes"]);
                    crystalReportViewer1.ReportSource = fcli;
                    crystalReportViewer1.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    db.Close();
                }

                db.Close();
            }
            else
            {
                MessageBox.Show(txtIdProgramme.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myprogramme();
        }
    }
}
