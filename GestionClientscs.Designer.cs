namespace GestionStock
{
    partial class GestionClientscs
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bPremier = new System.Windows.Forms.Button();
            this.bDernier = new System.Windows.Forms.Button();
            this.bSuivant = new System.Windows.Forms.Button();
            this.bPrecedent = new System.Windows.Forms.Button();
            this.bRechercher = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.bQuitter = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.bModifier = new System.Windows.Forms.Button();
            this.bAjouter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 153);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(130, 251);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.bPremier);
            this.groupBox4.Controls.Add(this.bDernier);
            this.groupBox4.Controls.Add(this.bSuivant);
            this.groupBox4.Controls.Add(this.bPrecedent);
            this.groupBox4.Location = new System.Drawing.Point(569, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(454, 312);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Liste des Clients";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // bPremier
            // 
            this.bPremier.Location = new System.Drawing.Point(47, 30);
            this.bPremier.Name = "bPremier";
            this.bPremier.Size = new System.Drawing.Size(75, 23);
            this.bPremier.TabIndex = 11;
            this.bPremier.Text = "<<";
            this.bPremier.UseVisualStyleBackColor = true;
            this.bPremier.Click += new System.EventHandler(this.bPremier_Click);
            // 
            // bDernier
            // 
            this.bDernier.Location = new System.Drawing.Point(320, 28);
            this.bDernier.Name = "bDernier";
            this.bDernier.Size = new System.Drawing.Size(75, 23);
            this.bDernier.TabIndex = 14;
            this.bDernier.Text = ">>";
            this.bDernier.UseVisualStyleBackColor = true;
            this.bDernier.Click += new System.EventHandler(this.bDernier_Click);
            // 
            // bSuivant
            // 
            this.bSuivant.Location = new System.Drawing.Point(230, 28);
            this.bSuivant.Name = "bSuivant";
            this.bSuivant.Size = new System.Drawing.Size(75, 23);
            this.bSuivant.TabIndex = 13;
            this.bSuivant.Text = ">";
            this.bSuivant.UseVisualStyleBackColor = true;
            this.bSuivant.Click += new System.EventHandler(this.bSuivant_Click);
            // 
            // bPrecedent
            // 
            this.bPrecedent.Location = new System.Drawing.Point(140, 30);
            this.bPrecedent.Name = "bPrecedent";
            this.bPrecedent.Size = new System.Drawing.Size(75, 23);
            this.bPrecedent.TabIndex = 12;
            this.bPrecedent.Text = "<";
            this.bPrecedent.UseVisualStyleBackColor = true;
            this.bPrecedent.Click += new System.EventHandler(this.bPrecedent_Click);
            // 
            // bRechercher
            // 
            this.bRechercher.Location = new System.Drawing.Point(133, 49);
            this.bRechercher.Name = "bRechercher";
            this.bRechercher.Size = new System.Drawing.Size(75, 41);
            this.bRechercher.TabIndex = 4;
            this.bRechercher.Text = "Chercher";
            this.bRechercher.UseVisualStyleBackColor = true;
            this.bRechercher.Click += new System.EventHandler(this.bRechercher_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(130, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresse:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Client :";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 61);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Par Nom Client";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telephone :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Client :";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(122, 23);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(130, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Par Code Client";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Location = new System.Drawing.Point(302, 310);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.bEnregistrer.TabIndex = 19;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // bQuitter
            // 
            this.bQuitter.Location = new System.Drawing.Point(471, 310);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(75, 23);
            this.bQuitter.TabIndex = 20;
            this.bQuitter.Text = "Quitter";
            this.bQuitter.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox6);
            this.groupBox3.Controls.Add(this.bRechercher);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(279, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rechercher";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bSupprimer);
            this.groupBox2.Controls.Add(this.bModifier);
            this.groupBox2.Controls.Add(this.bAjouter);
            this.groupBox2.Location = new System.Drawing.Point(276, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // bSupprimer
            // 
            this.bSupprimer.Location = new System.Drawing.Point(201, 27);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(75, 48);
            this.bSupprimer.TabIndex = 2;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = true;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // bModifier
            // 
            this.bModifier.Location = new System.Drawing.Point(106, 27);
            this.bModifier.Name = "bModifier";
            this.bModifier.Size = new System.Drawing.Size(75, 48);
            this.bModifier.TabIndex = 1;
            this.bModifier.Text = "Modifier";
            this.bModifier.UseVisualStyleBackColor = true;
            this.bModifier.Click += new System.EventHandler(this.bModifier_Click);
            // 
            // bAjouter
            // 
            this.bAjouter.Location = new System.Drawing.Point(6, 27);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(75, 48);
            this.bAjouter.TabIndex = 0;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 348);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infos Client";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Afficher Tout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Gestion des Clients";
            // 
            // GestionClientscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 365);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionClientscs";
            this.Text = "GestionClientscs";
            this.Load += new System.EventHandler(this.GestionClientscs_Load_1);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bPremier;
        private System.Windows.Forms.Button bDernier;
        private System.Windows.Forms.Button bSuivant;
        private System.Windows.Forms.Button bPrecedent;
        private System.Windows.Forms.Button bRechercher;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Button bModifier;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}