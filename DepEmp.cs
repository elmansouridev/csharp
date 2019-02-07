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
    public partial class DepEmp : Form
    {
        public DepEmp()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataView dv = new DataView();
        DataView dv1 = new DataView();
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=GestionStock1;Integrated Security=True");
        BindingSource bs = new BindingSource();
        BindingSource bs1 = new BindingSource();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        SqlDataAdapter da = null;
        SqlDataAdapter da1 = null;
        SqlCommandBuilder cb;
        SqlCommandBuilder cb1;
        private void DepEmp_Load(object sender, EventArgs e)
        {
            da1 = new SqlDataAdapter("select * from Employe", cn);
            da1.Fill(ds, "Employe");
            dataGridView1.DataSource = ds.Tables["Employe"];
            bs1.DataSource = ds.Tables["Employe"];
            da = new SqlDataAdapter("select * from Departement", cn);
            da.Fill(ds, "Departement");
            dataGridView2.DataSource = ds.Tables["Departement"];
            bs.DataSource = ds.Tables["Departement"];
        }

        private void bChercher_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int i = bs.Find("NomDep", textBox1.Text);
                if (i != -1)
                {
                    bs.Position = i;

                    dv = new DataView(ds.Tables["Departement"]);
                    dv.RowFilter = string.Format("NomDep='{0}'", textBox1.Text);
                    bs.DataSource = dv;
                    dataGridView2.DataSource = dv;
                }
                else
                {
                    MessageBox.Show("n'existe pas");
                }
            }
            if (radioButton2.Checked)
            {
                int i = bs1.Find("MatriculeEmp", textBox1.Text);
                if (i != -1)
                {
                    bs1.Position = i;

                    dv1 = new DataView(ds.Tables["Employe"]);
                    dv1.RowFilter = string.Format("MatriculeEmp='{0}'", textBox1.Text);
                    bs1.DataSource = dv1;
                    dataGridView1.DataSource = dv1;
                }
                else
                {
                    MessageBox.Show("n'existe pas");
                }
            }


        }

        private void bAfficherTout_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables["Employe"];
            dataGridView2.DataSource = ds.Tables["Departement"];
        }

        private void bAjouter_Emp_Click(object sender, EventArgs e)
        {
            int indice = -1;
            for (int i = 0; i < ds.Tables["Employe"].Rows.Count; i++)
            {
                if (ds.Tables["Employe"].Rows[i][0].ToString() == textBox_mat.Text)
                {
                    indice = i;
                }
            }
            if (indice != -1)
            {
                MessageBox.Show("Ce Matricule existe déjà","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DataRow datarow1;
                datarow1 = ds.Tables["Employe"].NewRow();
                datarow1[0] = textBox_mat.Text;
                datarow1[1] = textBox_nom.Text;
                datarow1[2] = textBox_prenom.Text;
                datarow1[3] = textBox_nomDepEmp.Text;
                datarow1[4] = textBox_fonction.Text;
                datarow1[5] = textBox_salaire.Text;
                ds.Tables["Employe"].Rows.Add(datarow1);
                bs1.DataSource = ds.Tables["Employe"];
                MessageBox.Show("Ajout avec succès");
            }
            
        }

        private void bModifier_Emp_Click(object sender, EventArgs e)
        {
            int indice = -1;
            for (int i = 0; i < ds.Tables["Employe"].Rows.Count; i++)
            {

                if (ds.Tables["Employe"].Rows[i][0].ToString() == textBox_mat.Text)
                {
                    indice = i;
                    break;
                }

            }
            if (indice != -1)
            {
                ds.Tables["Employe"].Rows[indice][1] = textBox_nom.Text;
                ds.Tables["Employe"].Rows[indice][2] = textBox_prenom.Text;
                ds.Tables["Employe"].Rows[indice][3] = textBox_nomDepEmp.Text;
                ds.Tables["Employe"].Rows[indice][4] = textBox_fonction.Text;
                ds.Tables["Employe"].Rows[indice][5] = textBox_salaire.Text;
                MessageBox.Show("Modifié avec succes");
            }
            else
            {
                MessageBox.Show("Matricule n'existe pas");
            }
        }

        private void bSupprimer_Emp_Click(object sender, EventArgs e)
        {
            int indice = -1;
            for (int i = 0; i < ds.Tables["Employe"].Rows.Count; i++)
            {

                if (ds.Tables["Employe"].Rows[i][0].ToString() == textBox_mat.Text)
                {
                    indice = i;
                    break;
                }

            }
            if (indice != -1)
            {
                ds.Tables["Employe"].Rows[indice].Delete();
                MessageBox.Show("Supprimé avec succes");
            }
            else
            {
                MessageBox.Show("Matricule n'existe pas");
            }
        }

        private void bAjouter_Dep_Click(object sender, EventArgs e)
        {
            int indice = -1;
            for (int i = 0; i < ds.Tables["Departement"].Rows.Count; i++)
            {
                if (ds.Tables["Departement"].Rows[i][0].ToString() == textBox_nomDepDep.Text)
                {
                    indice = i;
                }
            }
            if (indice != -1)
            {
                MessageBox.Show("Cette Departement existe déjà");
            }
            else
            {
                DataRow datarow;
                datarow = ds.Tables["Departement"].NewRow();
                datarow[0] = textBox_nomDepDep.Text;
                datarow[1] = textBox_codeArticle.Text;
                ds.Tables["Departement"].Rows.Add(datarow);
                bs.DataSource = ds.Tables["Departement"];
                MessageBox.Show("Ajout avec succes");
            }
            
        }

        private void bModifier_Dep_Click(object sender, EventArgs e)
        {
            int indice = -1;
            for (int i = 0; i < ds.Tables["Departement"].Rows.Count; i++)
            {

                if (ds.Tables["Departement"].Rows[i][0].ToString() == textBox_nomDepDep.Text)
                {
                    indice = i;
                    break;
                }

            }
            if (indice != -1)
            {;
                ds.Tables["Departement"].Rows[indice][1] = textBox_codeArticle.Text;
                MessageBox.Show("Modifié avec succes");
            }
            else
            {
                MessageBox.Show("ce Departement n'existe pas");
            }
        }

        private void bSupprimer_Dep_Click(object sender, EventArgs e)
        {
            int indice = -1;
            for (int i = 0; i < ds.Tables["Departement"].Rows.Count; i++)
            {

                if (ds.Tables["Departement"].Rows[i][0].ToString() == textBox_nomDepDep.Text)
                {
                    indice = i;
                    break;
                }

            }
            if (indice != -1)
            {
                ds.Tables["Departement"].Rows[indice].Delete();
                MessageBox.Show("Supprimé avec succes");
            }
            else
            {
                MessageBox.Show("cette Departement n'existe pas");
            }
        }

        private void bEnregistrer_Click(object sender, EventArgs e)
        {
            cb = new SqlCommandBuilder(da1);
            da1.Update(ds, "Employe");
            cb1 = new SqlCommandBuilder(da);
            da.Update(ds, "Departement");
            MessageBox.Show("Enregistré avec succes");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables["Employe"];
            dataGridView2.DataSource = ds.Tables["Departement"];
        }




    }
}
