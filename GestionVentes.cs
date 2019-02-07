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
    public partial class GestionVentes : Form
    {
        public GestionVentes()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=GestionStock1;Integrated Security=True");
        BindingSource bsv = new BindingSource();
        SqlDataAdapter da = null;
        SqlDataAdapter da1 = null;
        SqlDataAdapter da2 = null;
        DataRow datarow = null;
        private void GestionVentes_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Vente", cn);
            da1 = new SqlDataAdapter("select * from Client", cn);
            da2 = new SqlDataAdapter("select * from Article", cn);
            da1.Fill(ds, "Client");
            da.Fill(ds, "Vente");
            da2.Fill(ds, "Article");
            dt = ds.Tables["Vente"];
            bsv.DataSource = dt;
            dataGridView1.DataSource = dt;
            comboBox1.DataSource = ds.Tables["Client"];
            comboBox1.DisplayMember = "CodeClient";
            comboBox2.DataSource=ds.Tables["Article"];
            comboBox2.DisplayMember="CodeArticle";
           
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            int indice = -1;
            for (int i = 0; i < ds.Tables["Vente"].Rows.Count; i++)
            {
                if (ds.Tables["Vente"].Rows[i][0].ToString() == tCodeVente.Text)
                {
                    indice = i;
                }
            }
            if (indice != -1)
            {
                MessageBox.Show("Ce Code existe déjà","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                datarow = ds.Tables["Vente"].NewRow();
                datarow[0] = tCodeVente.Text;
                datarow[1] = comboBox2.Text;
                datarow[2] = comboBox1.Text;
                datarow[3] = dateTimePicker_Vente.Value;
                datarow[4] = tPrixArticleVente.Text;
                datarow[5] = tQteVente.Text;
                ds.Tables["Vente"].Rows.Add(datarow);
                bsv.DataSource = dt;
                MessageBox.Show("ajouté avec succes");
                dataGridView1.DataSource = ds.Tables["Vente"];
            }
            
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            int indice = dataGridView1.CurrentRow.Index;
            for (int i = 0; i < ds.Tables["Vente"].Rows.Count; i++)
            {
                if (ds.Tables["Vente"].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (ds.Tables["Vente"].Rows[i][0].ToString() == tCodeVente.Text)
                    {
                        ds.Tables["Vente"].Rows[i][0] = tCodeVente.Text;
                        ds.Tables["Vente"].Rows[i][1] = comboBox2.Text;
                        ds.Tables["Vente"].Rows[i][2] = comboBox1.Text;
                        ds.Tables["Vente"].Rows[i][3] = dateTimePicker_Vente.Value;
                        ds.Tables["Vente"].Rows[i][4] = tPrixArticleVente.Text;
                        ds.Tables["Vente"].Rows[i][5] = tQteVente.Text;
                        bsv.DataSource = dt;
                        MessageBox.Show("Modifié avec succes");
                    }
                    else
                    {
                        MessageBox.Show("n'existe pas");
                    }
                }
            }
        }

        private void bSupprimer_Click(object sender, EventArgs e)
        {
            int indice = -1;
            for (int i = 0; i < ds.Tables["Vente"].Rows.Count; i++)
            {
                if (ds.Tables["Vente"].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (ds.Tables["Vente"].Rows[i][0].ToString() == tCodeVente.Text)
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
                ds.Tables["Vente"].Rows[indice].Delete();
                MessageBox.Show("bien supprimé");
                bsv.DataSource = dt;
            }
        }

        private void bRechercher_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int i = bsv.Find("CodeVente", textBox1.Text);
                if (i != -1)
                {
                    bsv.Position = i;

                    dv = new DataView(dt);
                    dv.RowFilter = string.Format("CodeVente='{0}'", textBox1.Text);
                    dataGridView1.DataSource = dv;


                }
                else
                {
                    MessageBox.Show("n'existe pas");
                }
            }

            if (radioButton2.Checked)
            {
                int i = bsv.Find("CodeArticle", textBox1.Text);
                if (i != -1)
                {
                    bsv.Position = i;

                    dv = new DataView(dt);
                    dv.RowFilter = string.Format("CodeArticle='{0}'", textBox1.Text);
                    dataGridView1.DataSource = dv;


                }
                else
                {
                    MessageBox.Show("n'existe pas");
                }
            }

            if (radioButton3.Checked)
            {
                int i = bsv.Find("CodeClient", textBox1.Text);
                if (i != -1)
                {
                    bsv.Position = i;

                    dv = new DataView(dt);
                    dv.RowFilter = string.Format("CodeClient='{0}'", textBox1.Text);
                    dataGridView1.DataSource = dv;


                }
                else
                {
                    MessageBox.Show("n'existe pas");
                }
            }
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Vente");
            MessageBox.Show("Enregistré avec succes");
        }

        private void bQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bPremier_Click(object sender, EventArgs e)
        {
            bsv.MoveFirst();
            dataGridView1.DataSource = bsv;
        }

        private void bPrecedent_Click(object sender, EventArgs e)
        {
            bsv.MovePrevious();
            dataGridView1.DataSource = bsv;
        }

        private void bSuivant_Click(object sender, EventArgs e)
        {
            bsv.MoveNext();
            dataGridView1.DataSource = bsv;
        }

        private void bDernier_Click(object sender, EventArgs e)
        {
            bsv.MoveLast();
            dataGridView1.DataSource = bsv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bsv;
        }

        private void bGererCient_Click(object sender, EventArgs e)
        {
            GestionClientscs f = new GestionClientscs();
            f.Hide();
            f.ShowDialog();
        }

        private void tPrixArticleVente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        { 
            
        }
    }
}
