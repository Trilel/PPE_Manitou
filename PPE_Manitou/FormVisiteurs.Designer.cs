namespace PPE_Manitou
{
    partial class FormVisiteurs
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.lbl_Chercher = new System.Windows.Forms.Label();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.lbl_Prenom = new System.Windows.Forms.Label();
            this.lbl_Adresse = new System.Windows.Forms.Label();
            this.lbl_Labo = new System.Windows.Forms.Label();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.txt_Adresse = new System.Windows.Forms.TextBox();
            this.cbo_Chercher = new System.Windows.Forms.ComboBox();
            this.cbo_Labo = new System.Windows.Forms.ComboBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VISITEURS";
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.Location = new System.Drawing.Point(696, 399);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_Fermer.TabIndex = 1;
            this.btn_Fermer.Text = "Fermer";
            this.btn_Fermer.UseVisualStyleBackColor = true;
            this.btn_Fermer.Click += new System.EventHandler(this.btn_Fermer_Click);
            // 
            // lbl_Chercher
            // 
            this.lbl_Chercher.AutoSize = true;
            this.lbl_Chercher.Location = new System.Drawing.Point(13, 50);
            this.lbl_Chercher.Name = "lbl_Chercher";
            this.lbl_Chercher.Size = new System.Drawing.Size(50, 13);
            this.lbl_Chercher.TabIndex = 2;
            this.lbl_Chercher.Text = "Chercher";
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Location = new System.Drawing.Point(13, 109);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(32, 13);
            this.lbl_Nom.TabIndex = 3;
            this.lbl_Nom.Text = "NOM";
            // 
            // lbl_Prenom
            // 
            this.lbl_Prenom.AutoSize = true;
            this.lbl_Prenom.Location = new System.Drawing.Point(13, 146);
            this.lbl_Prenom.Name = "lbl_Prenom";
            this.lbl_Prenom.Size = new System.Drawing.Size(54, 13);
            this.lbl_Prenom.TabIndex = 4;
            this.lbl_Prenom.Text = "PRENOM";
            // 
            // lbl_Adresse
            // 
            this.lbl_Adresse.AutoSize = true;
            this.lbl_Adresse.Location = new System.Drawing.Point(13, 186);
            this.lbl_Adresse.Name = "lbl_Adresse";
            this.lbl_Adresse.Size = new System.Drawing.Size(58, 13);
            this.lbl_Adresse.TabIndex = 5;
            this.lbl_Adresse.Text = "ADRESSE";
            // 
            // lbl_Labo
            // 
            this.lbl_Labo.AutoSize = true;
            this.lbl_Labo.Location = new System.Drawing.Point(13, 215);
            this.lbl_Labo.Name = "lbl_Labo";
            this.lbl_Labo.Size = new System.Drawing.Size(35, 13);
            this.lbl_Labo.TabIndex = 8;
            this.lbl_Labo.Text = "LABO";
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(158, 106);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(170, 20);
            this.txt_Nom.TabIndex = 11;
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Location = new System.Drawing.Point(158, 143);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(170, 20);
            this.txt_Prenom.TabIndex = 12;
            // 
            // txt_Adresse
            // 
            this.txt_Adresse.Location = new System.Drawing.Point(158, 183);
            this.txt_Adresse.Name = "txt_Adresse";
            this.txt_Adresse.Size = new System.Drawing.Size(234, 20);
            this.txt_Adresse.TabIndex = 13;
            // 
            // cbo_Chercher
            // 
            this.cbo_Chercher.FormattingEnabled = true;
            this.cbo_Chercher.Location = new System.Drawing.Point(158, 47);
            this.cbo_Chercher.Name = "cbo_Chercher";
            this.cbo_Chercher.Size = new System.Drawing.Size(121, 21);
            this.cbo_Chercher.TabIndex = 18;
            this.cbo_Chercher.SelectedIndexChanged += new System.EventHandler(this.cbo_Chercher_SelectedIndexChanged);
            // 
            // cbo_Labo
            // 
            this.cbo_Labo.FormattingEnabled = true;
            this.cbo_Labo.Location = new System.Drawing.Point(158, 215);
            this.cbo_Labo.Name = "cbo_Labo";
            this.cbo_Labo.Size = new System.Drawing.Size(121, 21);
            this.cbo_Labo.TabIndex = 20;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(302, 45);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(42, 23);
            this.btn_OK.TabIndex = 21;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // FormVisiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.cbo_Labo);
            this.Controls.Add(this.cbo_Chercher);
            this.Controls.Add(this.txt_Adresse);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.lbl_Labo);
            this.Controls.Add(this.lbl_Adresse);
            this.Controls.Add(this.lbl_Prenom);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.lbl_Chercher);
            this.Controls.Add(this.btn_Fermer);
            this.Controls.Add(this.label1);
            this.Name = "FormVisiteurs";
            this.Text = "FormVisiterus";
            this.Load += new System.EventHandler(this.FormVisiterus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.Label lbl_Chercher;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.Label lbl_Prenom;
        private System.Windows.Forms.Label lbl_Adresse;
        private System.Windows.Forms.Label lbl_Labo;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.TextBox txt_Adresse;
        private System.Windows.Forms.ComboBox cbo_Chercher;
        private System.Windows.Forms.ComboBox cbo_Labo;
        private System.Windows.Forms.Button btn_OK;
    }
}