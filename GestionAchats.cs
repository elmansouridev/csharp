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
    public partial class GestionAchats : Form
    {
        public GestionAchats()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataView dv = new DataView();
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=GestionStock1;Integrated Security=True");
        BindingSource bs = new BindingSource();
        DataTable dt = new DataTable();
        SqlDataAdapter da = null;
        private void GestionAchats_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Achat", cn);
            da.Fill(ds, "Achat");
            dt = ds.Tables["Achat"];
            dataGridView1.DataSource = dt;
            bs.DataSource = dt;

            
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            DataRow datarow = ds.Tables["Achat"].NewRow();
            datarow[0] = textBox1.Text;
            datarow[1] = textBox2.Text;
            datarow[2] = textBox3.Text;
            datarow[3] = dateTimePicker_Achat.Text;
            datarow[4] = textBox4.Text;
            datarow[5] = textBox5.Text;
            ds.Tables["Achat"].Rows.Add(datarow);
            dataGridView1.DataSource = ds.Tables["Achat"];
            bs.DataSource = dt;
            MessageBox.Show("Ajout succes");
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ds.Tables["Achat"].Rows.Count; i++)
            {
                if (ds.Tables["Achat"].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (ds.Tables["Achat"].Rows[i][0].ToString() == textBox1.Text)
                    {
                        ds.Tables["Achat"].Rows[i][0] = textBox1.Text;
                        ds.Tables["Achat"].Rows[i][1] = textBox2.Text;
                        ds.Tables["Achat"].Rows[i][2] = textBox3.Text;
                        ds.Tables["Achat"].Rows[i][3] = dateTimePicker_Achat.Text;
                        ds.Tables["Achat"].Rows[i][4] = textBox4.Text;
                        ds.Tables["Achat"].Rows[i][5] = textBox5.Text;
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
            for (int i = 0; i < ds.Tables["Achat"].Rows.Count; i++)
            {
                if (ds.Tables["Achat"].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (ds.Tables["Achat"].Rows[i][0].ToString() == textBox1.Text)
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
                ds.Tables["Achat"].Rows[indice].Delete();
                MessageBox.Show("l'achat est bien Supprimé");
            }
        }

        private void bRechercher_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int i = bs.Find("CodeAchat", textBox6.Text);
                if (i != -1)
                {
                    bs.Position = i;

                    dv = new DataView(dt);
                    dv.RowFilter = string.Format("CodeAchat='{0}'", textBox6.Text);
                    dataGridView1.DataSource = dv;


                }
                else
                {
                    MessageBox.Show("n'existe pas");
                }
            }

            if (radioButton2.Checked)
            {
                int i = bs.Find("CodeArticle", textBox6.Text);
                if (i != -1)
                {
                    bs.Position = i;

                    dv = new DataView(dt);
                    dv.RowFilter = string.Format("CodeArticle='{0}'", textBox6.Text);
                    dataGridView1.DataSource = dv;


                }
                else
                {
                    MessageBox.Show("n'existe pas");
                }
            }

            if (radioButton3.Checked)
            {
                int i = bs.Find("CodeFournisseur", textBox6.Text);
                if (i != -1)
                {
                    bs.Position = i;

                    dv = new DataView(dt);
                    dv.RowFilter = string.Format("CodeFournisseur='{0}'", textBox6.Text);
                    dataGridView1.DataSource = dv;


                }
                else
                {
                    MessageBox.Show("n'existe pas");
                }
            }
        }

        private void bPremier_Click(object sender, EventArgs e)
        {
           bs.MoveFirst();
           dataGridView1.DataSource = bs;
        }

        private void bPrecedent_Click(object sender, EventArgs e)
        {
            bs.MovePrevious();
            dataGridView1.DataSource = bs;
        }

        private void bSuivant_Click(object sender, EventArgs e)
        {
            bs.MoveNext();
            dataGridView1.DataSource = bs;
        }

        private void bDernier_Click(object sender, EventArgs e)
        {
            bs.MoveLast();
            dataGridView1.DataSource = bs;
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Achat");
            MessageBox.Show("Bien Enregistré");
        }

        private void bGererFournisseurs_Click(object sender, EventArgs e)
        {
            GestionFournisseurs f = new GestionFournisseurs();
            f.Hide();
            f.ShowDialog();
        }

    }
}
