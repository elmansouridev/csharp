using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class ArticleDepEmp : Form
    {
        public ArticleDepEmp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormArticles f = new FormArticles();
            f.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DepEmp f = new DepEmp();
            f.Hide();
            f.ShowDialog();
        }
    }
}
