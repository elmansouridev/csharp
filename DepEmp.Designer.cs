namespace GestionStock
{
    partial class DepEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bChercher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox_mat = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.textBox_nomDepEmp = new System.Windows.Forms.TextBox();
            this.textBox_fonction = new System.Windows.Forms.TextBox();
            this.textBox_salaire = new System.Windows.Forms.TextBox();
            this.textBox_nomDepDep = new System.Windows.Forms.TextBox();
            this.textBox_codeArticle = new System.Windows.Forms.TextBox();
            this.bAjouter_Dep = new System.Windows.Forms.Button();
            this.bModifier_Emp = new System.Windows.Forms.Button();
            this.bSupprimer_Emp = new System.Windows.Forms.Button();
            this.bModifier_Dep = new System.Windows.Forms.Button();
            this.bSupprimer_Dep = new System.Windows.Forms.Button();
            this.bAjouter_Emp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.bQuitter = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bChercher
            // 
            this.bChercher.Location = new System.Drawing.Point(182, 60);
            this.bChercher.Name = "bChercher";
            this.bChercher.Size = new System.Drawing.Size(75, 23);
            this.bChercher.TabIndex = 0;
            this.bChercher.Text = "Chercher";
            this.bChercher.UseVisualStyleBackColor = true;
            this.bChercher.Click += new System.EventHandler(this.bChercher_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(327, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(335, 19);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(245, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "par Departement";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "par Employe";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox_mat
            // 
            this.textBox_mat.Location = new System.Drawing.Point(221, 9);
            this.textBox_mat.Name = "textBox_mat";
            this.textBox_mat.Size = new System.Drawing.Size(100, 20);
            this.textBox_mat.TabIndex = 9;
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(221, 42);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_nom.TabIndex = 10;
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(221, 68);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(100, 20);
            this.textBox_prenom.TabIndex = 11;
            // 
            // textBox_nomDepEmp
            // 
            this.textBox_nomDepEmp.Location = new System.Drawing.Point(221, 94);
            this.textBox_nomDepEmp.Name = "textBox_nomDepEmp";
            this.textBox_nomDepEmp.Size = new System.Drawing.Size(100, 20);
            this.textBox_nomDepEmp.TabIndex = 12;
            // 
            // textBox_fonction
            // 
            this.textBox_fonction.Location = new System.Drawing.Point(221, 120);
            this.textBox_fonction.Name = "textBox_fonction";
            this.textBox_fonction.Size = new System.Drawing.Size(100, 20);
            this.textBox_fonction.TabIndex = 13;
            // 
            // textBox_salaire
            // 
            this.textBox_salaire.Location = new System.Drawing.Point(221, 146);
            this.textBox_salaire.Name = "textBox_salaire";
            this.textBox_salaire.Size = new System.Drawing.Size(100, 20);
            this.textBox_salaire.TabIndex = 14;
            // 
            // textBox_nomDepDep
            // 
            this.textBox_nomDepDep.Location = new System.Drawing.Point(215, 31);
            this.textBox_nomDepDep.Name = "textBox_nomDepDep";
            this.textBox_nomDepDep.Size = new System.Drawing.Size(100, 20);
            this.textBox_nomDepDep.TabIndex = 15;
            // 
            // textBox_codeArticle
            // 
            this.textBox_codeArticle.Location = new System.Drawing.Point(214, 74);
            this.textBox_codeArticle.Name = "textBox_codeArticle";
            this.textBox_codeArticle.Size = new System.Drawing.Size(100, 20);
            this.textBox_codeArticle.TabIndex = 16;
            // 
            // bAjouter_Dep
            // 
            this.bAjouter_Dep.Location = new System.Drawing.Point(6, 19);
            this.bAjouter_Dep.Name = "bAjouter_Dep";
            this.bAjouter_Dep.Size = new System.Drawing.Size(75, 23);
            this.bAjouter_Dep.TabIndex = 17;
            this.bAjouter_Dep.Text = "Ajouter";
            this.bAjouter_Dep.UseVisualStyleBackColor = true;
            this.bAjouter_Dep.Click += new System.EventHandler(this.bAjouter_Dep_Click);
            // 
            // bModifier_Emp
            // 
            this.bModifier_Emp.Location = new System.Drawing.Point(6, 52);
            this.bModifier_Emp.Name = "bModifier_Emp";
            this.bModifier_Emp.Size = new System.Drawing.Size(75, 23);
            this.bModifier_Emp.TabIndex = 18;
            this.bModifier_Emp.Text = "Modifier";
            this.bModifier_Emp.UseVisualStyleBackColor = true;
            this.bModifier_Emp.Click += new System.EventHandler(this.bModifier_Emp_Click);
            // 
            // bSupprimer_Emp
            // 
            this.bSupprimer_Emp.Location = new System.Drawing.Point(6, 81);
            this.bSupprimer_Emp.Name = "bSupprimer_Emp";
            this.bSupprimer_Emp.Size = new System.Drawing.Size(75, 23);
            this.bSupprimer_Emp.TabIndex = 19;
            this.bSupprimer_Emp.Text = "Supprimer";
            this.bSupprimer_Emp.UseVisualStyleBackColor = true;
            this.bSupprimer_Emp.Click += new System.EventHandler(this.bSupprimer_Emp_Click);
            // 
            // bModifier_Dep
            // 
            this.bModifier_Dep.Location = new System.Drawing.Point(6, 48);
            this.bModifier_Dep.Name = "bModifier_Dep";
            this.bModifier_Dep.Size = new System.Drawing.Size(75, 23);
            this.bModifier_Dep.TabIndex = 20;
            this.bModifier_Dep.Text = "Modifier";
            this.bModifier_Dep.UseVisualStyleBackColor = true;
            this.bModifier_Dep.Click += new System.EventHandler(this.bModifier_Dep_Click);
            // 
            // bSupprimer_Dep
            // 
            this.bSupprimer_Dep.Location = new System.Drawing.Point(6, 79);
            this.bSupprimer_Dep.Name = "bSupprimer_Dep";
            this.bSupprimer_Dep.Size = new System.Drawing.Size(75, 23);
            this.bSupprimer_Dep.TabIndex = 21;
            this.bSupprimer_Dep.Text = "Supprimer";
            this.bSupprimer_Dep.UseVisualStyleBackColor = true;
            this.bSupprimer_Dep.Click += new System.EventHandler(this.bSupprimer_Dep_Click);
            // 
            // bAjouter_Emp
            // 
            this.bAjouter_Emp.Location = new System.Drawing.Point(6, 23);
            this.bAjouter_Emp.Name = "bAjouter_Emp";
            this.bAjouter_Emp.Size = new System.Drawing.Size(75, 23);
            this.bAjouter_Emp.TabIndex = 22;
            this.bAjouter_Emp.Text = "Ajouter";
            this.bAjouter_Emp.UseVisualStyleBackColor = true;
            this.bAjouter_Emp.Click += new System.EventHandler(this.bAjouter_Emp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bAjouter_Emp);
            this.groupBox1.Controls.Add(this.bModifier_Emp);
            this.groupBox1.Controls.Add(this.bSupprimer_Emp);
            this.groupBox1.Controls.Add(this.textBox_mat);
            this.groupBox1.Controls.Add(this.textBox_nom);
            this.groupBox1.Controls.Add(this.textBox_prenom);
            this.groupBox1.Controls.Add(this.textBox_salaire);
            this.groupBox1.Controls.Add(this.textBox_nomDepEmp);
            this.groupBox1.Controls.Add(this.textBox_fonction);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1011, 183);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infos Employes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Salaire :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(125, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Fonction :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Departement :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Prenom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Matricule :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.bAjouter_Dep);
            this.groupBox2.Controls.Add(this.bModifier_Dep);
            this.groupBox2.Controls.Add(this.textBox_codeArticle);
            this.groupBox2.Controls.Add(this.bSupprimer_Dep);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.textBox_nomDepDep);
            this.groupBox2.Location = new System.Drawing.Point(18, 241);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 189);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Infos Departements";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Code Article :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Nom Departement :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.bChercher);
            this.groupBox3.Location = new System.Drawing.Point(635, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 100);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recherche";
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Location = new System.Drawing.Point(670, 407);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.bEnregistrer.TabIndex = 28;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // bQuitter
            // 
            this.bQuitter.Location = new System.Drawing.Point(817, 407);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(75, 23);
            this.bQuitter.TabIndex = 29;
            this.bQuitter.Text = "Quitter";
            this.bQuitter.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(348, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 27);
            this.label9.TabIndex = 30;
            this.label9.Text = "Employés/Departements";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Afficher Tout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DepEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DepEmp";
            this.Text = "DepEmp";
            this.Load += new System.EventHandler(this.DepEmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bChercher;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox_mat;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.TextBox textBox_nomDepEmp;
        private System.Windows.Forms.TextBox textBox_fonction;
        private System.Windows.Forms.TextBox textBox_salaire;
        private System.Windows.Forms.TextBox textBox_nomDepDep;
        private System.Windows.Forms.TextBox textBox_codeArticle;
        private System.Windows.Forms.Button bAjouter_Dep;
        private System.Windows.Forms.Button bModifier_Emp;
        private System.Windows.Forms.Button bSupprimer_Emp;
        private System.Windows.Forms.Button bModifier_Dep;
        private System.Windows.Forms.Button bSupprimer_Dep;
        private System.Windows.Forms.Button bAjouter_Emp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;

    }
}