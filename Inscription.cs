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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=GestionStock1;Integrated Security=True");
        BindingSource bsEmp = new BindingSource();
        SqlDataAdapter da = null;

        private void bInscrire_Click(object sender, EventArgs e)
        {
            int indice = -1;
            if (textBox3.Text == textBox2.Text)
            {
                try
                {
                    
                    for (int i = 0; i < ds.Tables["Inscription"].Rows.Count; i++)
                    {
                        if (ds.Tables["Inscription"].Rows[i][0].ToString() == textBox1.Text)
                        {
                            indice = i;
                        }
                    }
                    if (indice == -1)
                    {
                        DataRow datarow = ds.Tables["Inscription"].NewRow();
                        datarow[0] = textBox1.Text;
                        datarow[1] = textBox2.Text;
                        ds.Tables["Inscription"].Rows.Add(datarow);
                        SqlCommandBuilder cb = new SqlCommandBuilder(da);
                        da.Update(ds, "Inscription");
                        MessageBox.Show("Enregistré avec succès");
                    }
                    else
                    {
                        MessageBox.Show("vous êtes déjà inscrit", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("Ce Matricule n'existe pas","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Les deux Champs de Mot de Passe doit être Identiques", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {
           
            
        }



       

        
    }
}
