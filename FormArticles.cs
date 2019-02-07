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
    public partial class FormArticles : Form
    {
        public FormArticles()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=GestionStock1;Integrated Security=True");
        BindingSource bsa = new BindingSource();
        SqlDataAdapter da = null;
        DataView dv = new DataView();
        private void FormArticles_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Article",cn);
            da.Fill(ds, "Article");
            dt=ds.Tables["Article"];
            bsa.DataSource = dt;
            dataGridView1.DataSource = dt;

        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            DataRow datarow = ds.Tables["Article"].NewRow();
            datarow[0] = tCodeArticle.Text;
            datarow[1] = tMarque.Text;
            datarow[2] = tCategorie.Text;
            datarow[3] = float.Parse(tPrix.Text);
            datarow[4] = int.Parse(tQte.Text);
            ds.Tables["Article"].Rows.Add(datarow);
            MessageBox.Show("ajout succes");
            dataGridView1.DataSource = ds.Tables["Article"];
            bsa.DataSource = ds.Tables["Article"];
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            bsa.EndEdit();
            
            int indice = dataGridView1.CurrentRow.Index;
            for (int i = 0; i < ds.Tables["Article"].Rows.Count; i++)
            {
                if (ds.Tables["Article"].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (ds.Tables["Article"].Rows[i][0].ToString() == tCodeArticle.Text)
                    {
                        ds.Tables["Article"].Rows[i][0] = tCodeArticle.Text;
                        ds.Tables["Article"].Rows[i][1] = tMarque.Text;
                        ds.Tables["Article"].Rows[i][2] = tCategorie.Text;
                        ds.Tables["Article"].Rows[i][3] = float.Parse(tPrix.Text);
                        ds.Tables["Article"].Rows[i][4] = int.Parse(tQte.Text);
                        bsa.DataSource = ds.Tables["Article"];
                        MessageBox.Show("modifié succes");
                    }
                }
            }
            
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            int indice = -1;
            for (int i = 0; i < ds.Tables["Article"].Rows.Count; i++)
            {

                if (ds.Tables["Article"].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (ds.Tables["Article"].Rows[i][0].ToString() == tCodeArticle.Text)
                    {
                        indice = i;
                    }

                }
            }
            if (indice == -1)
            {
                MessageBox.Show("n'existe pas");
            }
            else
            {
                ds.Tables["Article"].Rows[indice].Delete();
                MessageBox.Show("bien supprimé");
            }
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Article");
            MessageBox.Show("mise a jour faite avec succes");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bRechercher_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int i = bsa.Find("CodeArticle", textBox1.Text);
                if (i != -1)
                {
                    bsa.Position = i;

                    dv = new DataView(dt);
                    dv.RowFilter = string.Format("CodeArticle='{0}'", textBox1.Text);
                    bsa.DataSource = dv;
                    dataGridView1.DataSource = dv;

                }
                else
                {
                    MessageBox.Show("n'existe pas");
                }
            }

            if (radioButton2.Checked)
            {
                int i = bsa.Find("Marque", textBox1.Text);
                if (i != -1)
                {
                    bsa.Position = i;

                    dv = new DataView(dt);
                    dv.RowFilter = string.Format("Marque='{0}'", textBox1.Text);
                    bsa.DataSource = dv;
                    dataGridView1.DataSource = dv;


                }
                else
                {
                    MessageBox.Show("n'existe pas");
                }
            }

            if (radioButton3.Checked)
            {
                int i = bsa.Find("Categorie", textBox1.Text);
                if (i != -1)
                {
                    bsa.Position = i;

                    dv = new DataView(dt);
                    dv.RowFilter = string.Format("Categorie='{0}'", textBox1.Text);
                    bsa.DataSource = dv;
                    dataGridView1.DataSource = dv;


                }
                else
                {
                    MessageBox.Show("n'existe pas");
                }
            }
        }

        

        
    }
}
