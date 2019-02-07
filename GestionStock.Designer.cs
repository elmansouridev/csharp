namespace GestionStock
{
    partial class GestionStock
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
            this.bVente = new System.Windows.Forms.Button();
            this.bAchat = new System.Windows.Forms.Button();
            this.bStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bVente
            // 
            this.bVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVente.Location = new System.Drawing.Point(99, 132);
            this.bVente.Name = "bVente";
            this.bVente.Size = new System.Drawing.Size(131, 88);
            this.bVente.TabIndex = 0;
            this.bVente.Text = "VENTE";
            this.bVente.UseVisualStyleBackColor = true;
            this.bVente.Click += new System.EventHandler(this.bVente_Click);
            // 
            // bAchat
            // 
            this.bAchat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAchat.Location = new System.Drawing.Point(680, 132);
            this.bAchat.Name = "bAchat";
            this.bAchat.Size = new System.Drawing.Size(170, 98);
            this.bAchat.TabIndex = 1;
            this.bAchat.Text = "ACHAT";
            this.bAchat.UseVisualStyleBackColor = true;
            this.bAchat.Click += new System.EventHandler(this.bAchat_Click);
            // 
            // bStock
            // 
            this.bStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStock.Location = new System.Drawing.Point(342, 142);
            this.bStock.Name = "bStock";
            this.bStock.Size = new System.Drawing.Size(217, 78);
            this.bStock.TabIndex = 4;
            this.bStock.Text = "GESTION DE STOCK";
            this.bStock.UseVisualStyleBackColor = true;
            this.bStock.Click += new System.EventHandler(this.bStock_Click);
            // 
            // GestionStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionStock.Properties.Resources.Tribune_Soldes_necessaire_synergie_entre_equipes_vente__T;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 380);
            this.Controls.Add(this.bStock);
            this.Controls.Add(this.bAchat);
            this.Controls.Add(this.bVente);
            this.Name = "GestionStock";
            this.Text = "GestionStock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bVente;
        private System.Windows.Forms.Button bAchat;
        private System.Windows.Forms.Button bStock;
    }
}