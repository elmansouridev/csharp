using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionStock
{
    public partial class GestionStock : Form
    {
        public GestionStock()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=GestionStock1;Integrated Security=True");
        BindingSource bsArticle = new BindingSource();

        private void bStock_Click(object sender, EventArgs e)
        {

            ArticleDepEmp f = new ArticleDepEmp();
            f.Hide();
            f.ShowDialog();
        }

        private void bAchat_Click(object sender, EventArgs e)
        {
            GestionAchats f = new GestionAchats();
            f.Hide();
            f.ShowDialog();
        }

        private void bVente_Click(object sender, EventArgs e)
        {
            GestionVentes f = new GestionVentes();
            f.Hide();
            f.ShowDialog();
        }


    }
}
