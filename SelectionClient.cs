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
    public partial class SelectionClient : Form
    {
        public SelectionClient()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=GestionStock1;Integrated Security=True");
        DataTable dt = new DataTable();
        SqlDataAdapter da = null;
        DataRow datarow = null;
        private void SelectionClient_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Client", cn);
            da.Fill(ds, "Client");
            dataGridView1.DataSource = ds.Tables["Client"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestionVentes gv = new GestionVentes();
            this.Hide();
            gv.Show();
        }
    }
}
