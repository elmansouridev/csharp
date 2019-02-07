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
    public partial class GestionFournisseurs : Form
    {
        public GestionFournisseurs()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataView dv = new DataView();
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=GestionStock1;Integrated Security=True");
        BindingSource bsf = new BindingSource();
        DataTable dt = new DataTable();
        SqlDataAdapter da = null;
        DataRow datarow = null;
        private void GestionFournisseurs_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Fournisseur", cn);
            da.Fill(ds, "Fournisseur");
            dt = ds.Tables["Fournisseur"];
            dataGridView1.DataSource = dt;
            bsf.DataSource = dt;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            int indice = -1;
            for (int i = 0; i < ds.Tables["Fournisseur"].Rows.Count; i++)
            {
                if (ds.Tables["Fournisseur"].Rows[i][0].ToString() == textBox1.Text)
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
                datarow = ds.Tables["Fournisseur"].NewRow();
                datarow[0] = textBox1.Text;
                datarow[1] = textBox2.Text;
                datarow[2] = textBox3.Text;
                datarow[3] = textBox4.Text;
                ds.Tables["Fournisseur"].Rows.Add(datarow);
                MessageBox.Show("ajout avec succes");
                dt = ds.Tables["Fournisseur"];
                bsf.DataSource = dt;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ds.Tables["Fournisseur"].Rows.Count; i++)
            {
                if (ds.Tables["Fournisseur"].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (ds.Tables["Fournisseur"].Rows[i][0].ToString() == textBox1.Text)
                    {
                        ds.Tables["Fournisseur"].Rows[i][0] = textBox1.Text;
                        ds.Tables["Fournisseur"].Rows[i][1] = textBox2.Text;
                        ds.Tables["Fournisseur"].Rows[i][2] = textBox3.Text;
                        ds.Tables["Fournisseur"].Rows[i][3] = textBox4.Text;
                        MessageBox.Show("Modifié avec succes");
                        dt = ds.Tables["Fournisseur"];
                        bsf.DataSource = ds.Tables["Fournisseur"];
                    }
                    else
                    {
                        MessageBox.Show("n'existe pas");
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int indice = -1;
            for (int i = 0; i < ds.Tables["Fournisseur"].Rows.Count; i++)
            {
                if (ds.Tables["Fournisseur"].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (ds.Tables["Fournisseur"].Rows[i][0].ToString() == textBox1.Text)
                    {
                        indice = i;
                    }
                }
            }
            if (indice == -1)
            {
                MessageBox.Show("tapez le code a supprimer");
            }
            else
            {
                ds.Tables["Fournisseur"].Rows[indice].Delete();
            }
        }

        private void bRechercher_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int i = bsf.Find("CodeFournisseur", textBox6.Text);
                if (i == -1)
                {
                    MessageBox.Show("n'existe pas");
                }
                else
                {
                    bsf.Position = i;
                    dv = new DataView(dt);
                    dv.RowFilter = string.Format("CodeFournisseur='{0}'", textBox6.Text);
                    dataGridView1.DataSource = dv;
                }

            }
            else if (radioButton2.Checked)
            {
                int i = bsf.Find("NomFournisseur", textBox6.Text);
                if (i == -1)
                {
                    MessageBox.Show("n'existe pas");
                }
                else
                {
                    bsf.Position = i;
                    dv = new DataView(dt);
                    dv.RowFilter = string.Format("NomFournisseur='{0}'", textBox6.Text);
                    dataGridView1.DataSource = dv;
                }
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("le Champ est Vide");
            }
            else
            {
                MessageBox.Show("Veuillez choisir le type de recherche");
            }
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds, "Fournisseur");
            MessageBox.Show("Bien Enregistré");
        }



        

        private void bPremier1_Click(object sender, EventArgs e)
        {
            bsf.MoveFirst();
            dataGridView1.DataSource = bsf;
        }

        private void bPrecedent_Click(object sender, EventArgs e)
        {
            bsf.MovePrevious();
            dataGridView1.DataSource = bsf;
        }

        private void bSuivant_Click(object sender, EventArgs e)
        {
            bsf.MoveNext();
            dataGridView1.DataSource = bsf;
        }

        private void bDernier_Click(object sender, EventArgs e)
        {
            bsf.MoveLast();
            dataGridView1.DataSource = bsf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bsf;
        }
    }
}
