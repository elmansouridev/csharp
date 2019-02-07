namespace GestionStock
{
    partial class FormArticles
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
            this.tQte = new System.Windows.Forms.TextBox();
            this.tPrix = new System.Windows.Forms.TextBox();
            this.tCategorie = new System.Windows.Forms.TextBox();
            this.tMarque = new System.Windows.Forms.TextBox();
            this.tCodeArticle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bAjouter = new System.Windows.Forms.Button();
            this.bModifier = new System.Windows.Forms.Button();
            this.bSupprimer = new System.Windows.Forms.Button();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Rechercher = new System.Windows.Forms.GroupBox();
            this.bRechercher = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Rechercher.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tQte);
            this.groupBox1.Controls.Add(this.tPrix);
            this.groupBox1.Controls.Add(this.tCategorie);
            this.groupBox1.Controls.Add(this.tMarque);
            this.groupBox1.Controls.Add(this.tCodeArticle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infos Articles";
            // 
            // tQte
            // 
            this.tQte.Location = new System.Drawing.Point(119, 237);
            this.tQte.Name = "tQte";
            this.tQte.Size = new System.Drawing.Size(100, 20);
            this.tQte.TabIndex = 9;
            // 
            // tPrix
            // 
            this.tPrix.Location = new System.Drawing.Point(119, 186);
            this.tPrix.Name = "tPrix";
            this.tPrix.Size = new System.Drawing.Size(100, 20);
            this.tPrix.TabIndex = 8;
            // 
            // tCategorie
            // 
            this.tCategorie.Location = new System.Drawing.Point(119, 132);
            this.tCategorie.Name = "tCategorie";
            this.tCategorie.Size = new System.Drawing.Size(100, 20);
            this.tCategorie.TabIndex = 7;
            // 
            // tMarque
            // 
            this.tMarque.Location = new System.Drawing.Point(119, 80);
            this.tMarque.Name = "tMarque";
            this.tMarque.Size = new System.Drawing.Size(100, 20);
            this.tMarque.TabIndex = 6;
            // 
            // tCodeArticle
            // 
            this.tCodeArticle.Location = new System.Drawing.Point(119, 31);
            this.tCodeArticle.Name = "tCodeArticle";
            this.tCodeArticle.Size = new System.Drawing.Size(100, 20);
            this.tCodeArticle.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantité :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prix :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categorie :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marque :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Article :";
            // 
            // bAjouter
            // 
            this.bAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAjouter.Location = new System.Drawing.Point(306, 39);
            this.bAjouter.Name = "bAjouter";
            this.bAjouter.Size = new System.Drawing.Size(85, 40);
            this.bAjouter.TabIndex = 1;
            this.bAjouter.Text = "Ajouter";
            this.bAjouter.UseVisualStyleBackColor = true;
            this.bAjouter.Click += new System.EventHandler(this.bAjouter_Click);
            // 
            // bModifier
            // 
            this.bModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModifier.Location = new System.Drawing.Point(306, 132);
            this.bModifier.Name = "bModifier";
            this.bModifier.Size = new System.Drawing.Size(85, 41);
            this.bModifier.TabIndex = 2;
            this.bModifier.Text = "Modifier";
            this.bModifier.UseVisualStyleBackColor = true;
            this.bModifier.Click += new System.EventHandler(this.bModifier_Click);
            // 
            // bSupprimer
            // 
            this.bSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSupprimer.Location = new System.Drawing.Point(306, 234);
            this.bSupprimer.Name = "bSupprimer";
            this.bSupprimer.Size = new System.Drawing.Size(85, 40);
            this.bSupprimer.TabIndex = 3;
            this.bSupprimer.Text = "Supprimer";
            this.bSupprimer.UseVisualStyleBackColor = true;
            this.bSupprimer.Click += new System.EventHandler(this.bSupprimer_Click);
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnregistrer.Location = new System.Drawing.Point(481, 341);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(84, 39);
            this.bEnregistrer.TabIndex = 5;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(645, 341);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 39);
            this.button6.TabIndex = 6;
            this.button6.Text = "Quitter";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(445, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // Rechercher
            // 
            this.Rechercher.Controls.Add(this.bRechercher);
            this.Rechercher.Controls.Add(this.textBox1);
            this.Rechercher.Controls.Add(this.radioButton3);
            this.Rechercher.Controls.Add(this.radioButton2);
            this.Rechercher.Controls.Add(this.radioButton1);
            this.Rechercher.Location = new System.Drawing.Point(445, 195);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(310, 140);
            this.Rechercher.TabIndex = 8;
            this.Rechercher.TabStop = false;
            this.Rechercher.Text = "Recherche";
            // 
            // bRechercher
            // 
            this.bRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRechercher.Location = new System.Drawing.Point(124, 87);
            this.bRechercher.Name = "bRechercher";
            this.bRechercher.Size = new System.Drawing.Size(82, 29);
            this.bRechercher.TabIndex = 4;
            this.bRechercher.Text = "Chercher";
            this.bRechercher.UseVisualStyleBackColor = true;
            this.bRechercher.Click += new System.EventHandler(this.bRechercher_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 62);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Par Categorie";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(80, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Par Marque";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(69, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Par Code";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // FormArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 392);
            this.Controls.Add(this.bModifier);
            this.Controls.Add(this.bSupprimer);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.bAjouter);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormArticles";
            this.Text = "FormArticles";
            this.Load += new System.EventHandler(this.FormArticles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Rechercher.ResumeLayout(false);
            this.Rechercher.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tQte;
        private System.Windows.Forms.TextBox tPrix;
        private System.Windows.Forms.TextBox tCategorie;
        private System.Windows.Forms.TextBox tMarque;
        private System.Windows.Forms.TextBox tCodeArticle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAjouter;
        private System.Windows.Forms.Button bModifier;
        private System.Windows.Forms.Button bSupprimer;
        private System.Windows.Forms.Button bEnregistrer;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Rechercher;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button bRechercher;
    }
}