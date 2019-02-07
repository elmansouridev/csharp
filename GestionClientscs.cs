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
    public partial class GestionClientscs : Form
    {
        public GestionClientscs()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataView dv = new DataView();
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=GestionStock1;Integrated Security=True");
        BindingSource bsc = new BindingSource();
        DataTable dt = new DataTable();
        SqlDataAdapter da = null;
        DataRow datarow = null;
        private void GestionClientscs_Load_1(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from Client", cn);
            da.Fill(ds, "Client");
            dt = ds.Tables["Client"];
            bsc.DataSource = dt;
            dataGridView1.DataSource = dt;
        }

        private void bAjouter_Click(object sender, EventArgs e)
        {
            int indice = -1;
            for (int i = 0; i < ds.Tables["Client"].Rows.Count; i++)
            {
                if (ds.Tables["Client"].Rows[i][0].ToString() == textBox1.Text)
                {
                    indice = i;
                }
            }
            if (indice != -1)
            {
                MessageBox.Show("Ce Code existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                datarow = ds.Tables["Client"].NewRow();
                datarow[0] = textBox1.Text;
                datarow[1] = textBox2.Text;
                datarow[2] = textBox3.Text;
                datarow[3] = textBox4.Text;
                ds.Tables["Client"].Rows.Add(datarow);
                MessageBox.Show("ajout avec succes");
                dt = ds.Tables["Client"];
                bsc.DataSource = dt;
            }
        }

        private void bModifier_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ds.Tables["Client"].Rows.Count; i++)
            {
                if (ds.Tables["Client"].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (ds.Tables["Client"].Rows[i][0].ToString() == textBox1.Text)
                    {
                        ds.Tables["Client"].Rows[i][0] = textBox1.Text;
                        ds.Tables["Client"].Rows[i][1] = textBox2.Text;
                        ds.Tables["Client"].Rows[i][2] = textBox3.Text;
                        ds.Tables["Client"].Rows[i][3] = textBox4.Text;
                        MessageBox.Show("Modifié avec succes");
                        dt = ds.Tables["Client"];
                        bsc.DataSource = dt;
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
            for (int i = 0; i < ds.Tables["Client"].Rows.Count; i++)
            {
                if (ds.Tables["Client"].Rows[i].RowState != DataRowState.Deleted)
                {
                    if (ds.Tables["Client"].Rows[i][0].ToString() == textBox1.Text)
                    {
                        indice = i;
                    }
                }
            }
            if (indice == -1)
            {
                MessageBox.Show("tapez le code de client a supprimer");
            }
            else
            {
                ds.Tables["Client"].Rows[indice].Delete();
            }
        }

        private void bRechercher_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int i = bsc.Find("CodeClient", textBox6.Text);
                if (i == -1)
                {
                    MessageBox.Show("n'existe pas");
                }
                else
                {
                    bsc.Position = i;
                    dv = new DataView(dt);
                    dv.RowFilter = string.Format("CodeClient='{0}'", textBox6.Text);
                    dataGridView1.DataSource = dv;
                }
                    
            }
            else if (radioButton2.Checked)
            {
                int i=bsc.Find("NomClient",textBox6.Text);
                if (i == -1)
                {
                    MessageBox.Show("n'existe pas");
                }
                else
                {
                    bsc.Position = i;
                    dv = new DataView(dt);
                    dv.RowFilter = string.Format("NomClient='{0}'", textBox6.Text);
                    dataGridView1.DataSource = dv;
                }
            }
            else if(textBox6.Text=="")
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
            da.Update(ds, "Client");
            MessageBox.Show("Bien Enregistré");
        }

        private void bPremier_Click(object sender, EventArgs e)
        {
            bsc.MoveFirst();
            dataGridView1.DataSource = bsc;
        }

        private void bPrecedent_Click(object sender, EventArgs e)
        {
            bsc.MovePrevious();
            dataGridView1.DataSource = bsc;
        }

        private void bSuivant_Click(object sender, EventArgs e)
        {
            bsc.MoveNext();
            dataGridView1.DataSource = bsc;
        }

        private void bDernier_Click(object sender, EventArgs e)
        {
            bsc.MoveLast();
            dataGridView1.DataSource = bsc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bsc;
        }




    }
}
