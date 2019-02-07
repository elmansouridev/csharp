namespace GestionStock
{
    partial class GestionVentes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bGererCient = new System.Windows.Forms.Button();
            this.dateTimePicker_Vente = new System.Windows.Forms.DateTimePicker();
            this.tQteVente = new System.Windows.Forms.TextBox();
            this.tPrixArticleVente = new System.Windows.Forms.TextBox();
            this.tCodeVente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.bModifier = new System.Windows.Forms.Button();
            this.bAjouter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bRechercher = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.bQuitter = new System.Windows.Forms.Button();
            this.bPremier = new System.Windows.Forms.Button();
            this.bDernier = new System.Windows.Forms.Button();
            this.bSuivant = new System.Windows.Forms.Button();
            this.bPrecedent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.bGererCient);
            this.groupBox1.Controls.Add(this.dateTimePicker_Vente);
            this.groupBox1.Controls.Add(this.tQteVente);
            this.groupBox1.Controls.Add(this.tPrixArticleVente);
            this.groupBox1.Controls.Add(this.tCodeVente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infos Vente";
            // 
            // bGererCient
            // 
            this.bGererCient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bGererCient.Location = new System.Drawing.Point(43, 261);
            this.bGererCient.Name = "bGererCient";
            this.bGererCient.Size = new System.Drawing.Size(127, 35);
            this.bGererCient.TabIndex = 12;
            this.bGererCient.Text = "Gerer les Clients";
            this.bGererCient.UseVisualStyleBackColor = true;
            this.bGererCient.Click += new System.EventHandler(this.bGererCient_Click);
            // 
            // dateTimePicker_Vente
            // 
            this.dateTimePicker_Vente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Vente.Location = new System.Drawing.Point(124, 143);
            this.dateTimePicker_Vente.Name = "dateTimePicker_Vente";
            this.dateTimePicker_Vente.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_Vente.TabIndex = 11;
            // 
            // tQteVente
            // 
            this.tQteVente.Location = new System.Drawing.Point(124, 235);
            this.tQteVente.Name = "tQteVente";
            this.tQteVente.Size = new System.Drawing.Size(100, 20);
            this.tQteVente.TabIndex = 10;
            // 
            // tPrixArticleVente
            // 
            this.tPrixArticleVente.Location = new System.Drawing.Point(124, 190);
            this.tPrixArticleVente.Name = "tPrixArticleVente";
            this.tPrixArticleVente.ReadOnly = true;
            this.tPrixArticleVente.Size = new System.Drawing.Size(100, 20);
            this.tPrixArticleVente.TabIndex = 9;
            this.tPrixArticleVente.TextChanged += new System.EventHandler(this.tPrixArticleVente_TextChanged);
            // 
            // tCodeVente
            // 
            this.tCodeVente.Location = new System.Drawing.Point(124, 36);
            this.tCodeVente.Name = "tCodeVente";
            this.tCodeVente.Size = new System.Drawing.Size(100, 20);
            this.tCodeVente.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantité de Vente :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prix Article :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date Vente :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Code Client :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code Article :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Vente :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bSupprimer);
            this.groupBox2.Controls.Add(this.bModifier);
            this.groupBox2.Controls.Add(this.bAjouter);
            this.groupBox2.Location = new System.Drawing.Point(272, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // bSupprimer
            // 
            this.bSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSupprimer.Location = new System.Drawing.Point(187, 27);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(89, 48);
            this.bSupprimer.TabIndex = 2;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = true;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // bModifier
            // 
            this.bModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModifier.Location = new System.Drawing.Point(96, 27);
            this.bModifier.Name = "bModifier";
            this.bModifier.Size = new System.Drawing.Size(75, 48);
            this.bModifier.TabIndex = 1;
            this.bModifier.Text = "Modifier";
            this.bModifier.UseVisualStyleBackColor = true;
            this.bModifier.Click += new System.EventHandler(this.bModifier_Click);
            // 
            // bAjouter
            // 
            this.bAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAjouter.Location = new System.Drawing.Point(6, 27);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(75, 48);
            this.bAjouter.TabIndex = 0;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 186);
            this.dataGridView1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.bRechercher);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Location = new System.Drawing.Point(278, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rechercher";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // bRechercher
            // 
            this.bRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRechercher.Location = new System.Drawing.Point(133, 49);
            this.bRechercher.Name = "bRechercher";
            this.bRechercher.Size = new System.Drawing.Size(75, 41);
            this.bRechercher.TabIndex = 4;
            this.bRechercher.Text = "Chercher";
            this.bRechercher.UseVisualStyleBackColor = true;
            this.bRechercher.Click += new System.EventHandler(this.bRechercher_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 67);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(98, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Par Code Client";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Par Code Article";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Par Code Vente ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnregistrer.Location = new System.Drawing.Point(304, 264);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(91, 32);
            this.bEnregistrer.TabIndex = 3;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // bQuitter
            // 
            this.bQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuitter.Location = new System.Drawing.Point(490, 264);
            this.bQuitter.Name = "bQuitter";
            this.bQuitter.Size = new System.Drawing.Size(75, 32);
            this.bQuitter.TabIndex = 4;
            this.bQuitter.Text = "Quitter";
            this.bQuitter.UseVisualStyleBackColor = true;
            this.bQuitter.Click += new System.EventHandler(this.bQuitter_Click);
            // 
            // bPremier
            // 
            this.bPremier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPremier.Location = new System.Drawing.Point(41, 26);
            this.bPremier.Name = "bPremier";
            this.bPremier.Size = new System.Drawing.Size(75, 23);
            this.bPremier.TabIndex = 15;
            this.bPremier.Text = "<<";
            this.bPremier.UseVisualStyleBackColor = true;
            this.bPremier.Click += new System.EventHandler(this.bPremier_Click);
            // 
            // bDernier
            // 
            this.bDernier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDernier.Location = new System.Drawing.Point(314, 26);
            this.bDernier.Name = "bDernier";
            this.bDernier.Size = new System.Drawing.Size(75, 23);
            this.bDernier.TabIndex = 18;
            this.bDernier.Text = ">>";
            this.bDernier.UseVisualStyleBackColor = true;
            this.bDernier.Click += new System.EventHandler(this.bDernier_Click);
            // 
            // bSuivant
            // 
            this.bSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSuivant.Location = new System.Drawing.Point(224, 26);
            this.bSuivant.Name = "bSuivant";
            this.bSuivant.Size = new System.Drawing.Size(75, 23);
            this.bSuivant.TabIndex = 17;
            this.bSuivant.Text = ">";
            this.bSuivant.UseVisualStyleBackColor = true;
            this.bSuivant.Click += new System.EventHandler(this.bSuivant_Click);
            // 
            // bPrecedent
            // 
            this.bPrecedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrecedent.Location = new System.Drawing.Point(134, 26);
            this.bPrecedent.Name = "bPrecedent";
            this.bPrecedent.Size = new System.Drawing.Size(75, 23);
            this.bPrecedent.TabIndex = 16;
            this.bPrecedent.Text = "<";
            this.bPrecedent.UseVisualStyleBackColor = true;
            this.bPrecedent.Click += new System.EventHandler(this.bPrecedent_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(170, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 41);
            this.button1.TabIndex = 19;
            this.button1.Text = "Afficher Tout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(311, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Gestion des Ventes";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bPremier);
            this.groupBox4.Controls.Add(this.bPrecedent);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.bSuivant);
            this.groupBox4.Controls.Add(this.bDernier);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(571, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(500, 296);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Liste des Ventes";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(124, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // GestionVentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 326);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.bQuitter);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionVentes";
            this.Text = "GestionVentes";
            this.Load += new System.EventHandler(this.GestionVentes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Vente;
        private System.Windows.Forms.TextBox tQteVente;
        private System.Windows.Forms.TextBox tPrixArticleVente;
        private System.Windows.Forms.TextBox tCodeVente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Button bModifier;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bRechercher;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.Button bQuitter;
        private System.Windows.Forms.Button bPremier;
        private System.Windows.Forms.Button bDernier;
        private System.Windows.Forms.Button bSuivant;
        private System.Windows.Forms.Button bPrecedent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bGererCient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}