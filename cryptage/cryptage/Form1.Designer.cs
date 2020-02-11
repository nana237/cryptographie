namespace cryptage
{
    partial class btnOuvrirFichier
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrypter = new System.Windows.Forms.Button();
            this.btnDecrypter = new System.Windows.Forms.Button();
            this.txtSimple = new System.Windows.Forms.TextBox();
            this.txtCrypter = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnOuvrirUnFichier = new System.Windows.Forms.Button();
            this.btnEnregistrerSous = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CryptoRapid";
            // 
            // btnCrypter
            // 
            this.btnCrypter.Location = new System.Drawing.Point(254, 257);
            this.btnCrypter.Name = "btnCrypter";
            this.btnCrypter.Size = new System.Drawing.Size(75, 23);
            this.btnCrypter.TabIndex = 1;
            this.btnCrypter.Text = "vider";
            this.btnCrypter.UseVisualStyleBackColor = true;
            this.btnCrypter.Click += new System.EventHandler(this.btnCrypter_Click);
            // 
            // btnDecrypter
            // 
            this.btnDecrypter.Location = new System.Drawing.Point(563, 480);
            this.btnDecrypter.Name = "btnDecrypter";
            this.btnDecrypter.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypter.TabIndex = 2;
            this.btnDecrypter.Text = "vider";
            this.btnDecrypter.UseVisualStyleBackColor = true;
            this.btnDecrypter.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSimple
            // 
            this.txtSimple.Location = new System.Drawing.Point(206, 37);
            this.txtSimple.Multiline = true;
            this.txtSimple.Name = "txtSimple";
            this.txtSimple.Size = new System.Drawing.Size(561, 214);
            this.txtSimple.TabIndex = 3;
            // 
            // txtCrypter
            // 
            this.txtCrypter.Location = new System.Drawing.Point(206, 286);
            this.txtCrypter.Multiline = true;
            this.txtCrypter.Name = "txtCrypter";
            this.txtCrypter.Size = new System.Drawing.Size(561, 179);
            this.txtCrypter.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCle);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 515);
            this.panel1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 44);
            this.button3.TabIndex = 0;
            this.button3.Text = "cesar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(355, 480);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnOuvrirUnFichier
            // 
            this.btnOuvrirUnFichier.Location = new System.Drawing.Point(578, 257);
            this.btnOuvrirUnFichier.Name = "btnOuvrirUnFichier";
            this.btnOuvrirUnFichier.Size = new System.Drawing.Size(144, 23);
            this.btnOuvrirUnFichier.TabIndex = 7;
            this.btnOuvrirUnFichier.Text = "ouvrir un fichier";
            this.btnOuvrirUnFichier.UseVisualStyleBackColor = true;
            this.btnOuvrirUnFichier.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnEnregistrerSous
            // 
            this.btnEnregistrerSous.Location = new System.Drawing.Point(462, 480);
            this.btnEnregistrerSous.Name = "btnEnregistrerSous";
            this.btnEnregistrerSous.Size = new System.Drawing.Size(95, 23);
            this.btnEnregistrerSous.TabIndex = 8;
            this.btnEnregistrerSous.Text = "Enregistrer sous";
            this.btnEnregistrerSous.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "decrypter cesar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCle
            // 
            this.txtCle.Location = new System.Drawing.Point(70, 230);
            this.txtCle.Name = "txtCle";
            this.txtCle.Size = new System.Drawing.Size(127, 20);
            this.txtCle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "clé";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(646, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "ouvrir un fichier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Miror";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 342);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "decrypter Miror";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // btnOuvrirFichier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 515);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEnregistrerSous);
            this.Controls.Add(this.btnOuvrirUnFichier);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCrypter);
            this.Controls.Add(this.txtSimple);
            this.Controls.Add(this.btnDecrypter);
            this.Controls.Add(this.btnCrypter);
            this.Controls.Add(this.label1);
            this.Name = "btnOuvrirFichier";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrypter;
        private System.Windows.Forms.Button btnDecrypter;
        private System.Windows.Forms.TextBox txtSimple;
        private System.Windows.Forms.TextBox txtCrypter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnOuvrirUnFichier;
        private System.Windows.Forms.Button btnEnregistrerSous;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}

