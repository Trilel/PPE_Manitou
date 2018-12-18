namespace PPE_Manitou
{
    partial class FormPracticiens
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Practiciens = new System.Windows.Forms.Label();
            this.lbl_Chercher = new System.Windows.Forms.Label();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.lbl_Prenom = new System.Windows.Forms.Label();
            this.lbl_Adresse = new System.Windows.Forms.Label();
            this.lbl_CoeffNotoriete = new System.Windows.Forms.Label();
            this.lbl_LieuExercice = new System.Windows.Forms.Label();
            this.cbo_Chercher = new System.Windows.Forms.ComboBox();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.txt_Adresse = new System.Windows.Forms.TextBox();
            this.txt_CoeffNotoriete = new System.Windows.Forms.TextBox();
            this.cbo_LieuExercice = new System.Windows.Forms.ComboBox();
            this.btn_Precedent = new System.Windows.Forms.Button();
            this.btn_Suivant = new System.Windows.Forms.Button();
            this.btn_Fermer = new System.Windows.Forms.Button();
            this.Praticiens = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Praticiens)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Practiciens
            // 
            this.lbl_Practiciens.AutoSize = true;
            this.lbl_Practiciens.Location = new System.Drawing.Point(346, 9);
            this.lbl_Practiciens.Name = "lbl_Practiciens";
            this.lbl_Practiciens.Size = new System.Drawing.Size(78, 13);
            this.lbl_Practiciens.TabIndex = 0;
            this.lbl_Practiciens.Text = "PRACTICIENS";
            // 
            // lbl_Chercher
            // 
            this.lbl_Chercher.AutoSize = true;
            this.lbl_Chercher.Location = new System.Drawing.Point(13, 66);
            this.lbl_Chercher.Name = "lbl_Chercher";
            this.lbl_Chercher.Size = new System.Drawing.Size(50, 13);
            this.lbl_Chercher.TabIndex = 1;
            this.lbl_Chercher.Text = "Chercher";
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Location = new System.Drawing.Point(13, 151);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(32, 13);
            this.lbl_Nom.TabIndex = 2;
            this.lbl_Nom.Text = "NOM";
            // 
            // lbl_Prenom
            // 
            this.lbl_Prenom.AutoSize = true;
            this.lbl_Prenom.Location = new System.Drawing.Point(13, 193);
            this.lbl_Prenom.Name = "lbl_Prenom";
            this.lbl_Prenom.Size = new System.Drawing.Size(54, 13);
            this.lbl_Prenom.TabIndex = 3;
            this.lbl_Prenom.Text = "PRENOM";
            this.lbl_Prenom.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_Adresse
            // 
            this.lbl_Adresse.AutoSize = true;
            this.lbl_Adresse.Location = new System.Drawing.Point(13, 241);
            this.lbl_Adresse.Name = "lbl_Adresse";
            this.lbl_Adresse.Size = new System.Drawing.Size(58, 13);
            this.lbl_Adresse.TabIndex = 4;
            this.lbl_Adresse.Text = "ADRESSE";
            // 
            // lbl_CoeffNotoriete
            // 
            this.lbl_CoeffNotoriete.AutoSize = true;
            this.lbl_CoeffNotoriete.Location = new System.Drawing.Point(13, 282);
            this.lbl_CoeffNotoriete.Name = "lbl_CoeffNotoriete";
            this.lbl_CoeffNotoriete.Size = new System.Drawing.Size(110, 13);
            this.lbl_CoeffNotoriete.TabIndex = 6;
            this.lbl_CoeffNotoriete.Text = "COEFF. NOTORIETE";
            // 
            // lbl_LieuExercice
            // 
            this.lbl_LieuExercice.AutoSize = true;
            this.lbl_LieuExercice.Location = new System.Drawing.Point(13, 329);
            this.lbl_LieuExercice.Name = "lbl_LieuExercice";
            this.lbl_LieuExercice.Size = new System.Drawing.Size(97, 13);
            this.lbl_LieuExercice.TabIndex = 7;
            this.lbl_LieuExercice.Text = "LIEU D\'EXERCICE";
            // 
            // cbo_Chercher
            // 
            this.cbo_Chercher.FormattingEnabled = true;
            this.cbo_Chercher.Location = new System.Drawing.Point(185, 63);
            this.cbo_Chercher.Name = "cbo_Chercher";
            this.cbo_Chercher.Size = new System.Drawing.Size(121, 21);
            this.cbo_Chercher.TabIndex = 8;
            this.cbo_Chercher.SelectedIndexChanged += new System.EventHandler(this.cbo_Chercher_SelectedIndexChanged);
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(185, 151);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(100, 20);
            this.txt_Nom.TabIndex = 9;
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Location = new System.Drawing.Point(13, 116);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(55, 13);
            this.lbl_Numero.TabIndex = 10;
            this.lbl_Numero.Text = "NUMERO";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(185, 113);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(100, 20);
            this.txt_Numero.TabIndex = 11;
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Location = new System.Drawing.Point(185, 190);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(100, 20);
            this.txt_Prenom.TabIndex = 12;
            // 
            // txt_Adresse
            // 
            this.txt_Adresse.Location = new System.Drawing.Point(185, 238);
            this.txt_Adresse.Name = "txt_Adresse";
            this.txt_Adresse.Size = new System.Drawing.Size(436, 20);
            this.txt_Adresse.TabIndex = 13;
            // 
            // txt_CoeffNotoriete
            // 
            this.txt_CoeffNotoriete.Location = new System.Drawing.Point(185, 279);
            this.txt_CoeffNotoriete.Name = "txt_CoeffNotoriete";
            this.txt_CoeffNotoriete.Size = new System.Drawing.Size(100, 20);
            this.txt_CoeffNotoriete.TabIndex = 16;
            // 
            // cbo_LieuExercice
            // 
            this.cbo_LieuExercice.FormattingEnabled = true;
            this.cbo_LieuExercice.Location = new System.Drawing.Point(185, 326);
            this.cbo_LieuExercice.Name = "cbo_LieuExercice";
            this.cbo_LieuExercice.Size = new System.Drawing.Size(121, 21);
            this.cbo_LieuExercice.TabIndex = 17;
            // 
            // btn_Precedent
            // 
            this.btn_Precedent.Location = new System.Drawing.Point(291, 415);
            this.btn_Precedent.Name = "btn_Precedent";
            this.btn_Precedent.Size = new System.Drawing.Size(75, 23);
            this.btn_Precedent.TabIndex = 18;
            this.btn_Precedent.Text = "Précédent";
            this.btn_Precedent.UseVisualStyleBackColor = true;
            // 
            // btn_Suivant
            // 
            this.btn_Suivant.Location = new System.Drawing.Point(372, 415);
            this.btn_Suivant.Name = "btn_Suivant";
            this.btn_Suivant.Size = new System.Drawing.Size(75, 23);
            this.btn_Suivant.TabIndex = 19;
            this.btn_Suivant.Text = "Suivant";
            this.btn_Suivant.UseVisualStyleBackColor = true;
            // 
            // btn_Fermer
            // 
            this.btn_Fermer.Location = new System.Drawing.Point(696, 415);
            this.btn_Fermer.Name = "btn_Fermer";
            this.btn_Fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_Fermer.TabIndex = 20;
            this.btn_Fermer.Text = "Fermer";
            this.btn_Fermer.UseVisualStyleBackColor = true;
            this.btn_Fermer.Click += new System.EventHandler(this.btn_Fermer_Click);
            // 
            // Praticiens
            // 
            this.Praticiens.DataSource = typeof(PPE_Manitou.MEDECIN);
            // 
            // FormPracticiens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Fermer);
            this.Controls.Add(this.btn_Suivant);
            this.Controls.Add(this.btn_Precedent);
            this.Controls.Add(this.cbo_LieuExercice);
            this.Controls.Add(this.txt_CoeffNotoriete);
            this.Controls.Add(this.txt_Adresse);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.lbl_Numero);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.cbo_Chercher);
            this.Controls.Add(this.lbl_LieuExercice);
            this.Controls.Add(this.lbl_CoeffNotoriete);
            this.Controls.Add(this.lbl_Adresse);
            this.Controls.Add(this.lbl_Prenom);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.lbl_Chercher);
            this.Controls.Add(this.lbl_Practiciens);
            this.Name = "FormPracticiens";
            this.Text = "FormPracticiens";
            this.Load += new System.EventHandler(this.FormPracticiens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Praticiens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Practiciens;
        private System.Windows.Forms.Label lbl_Chercher;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.Label lbl_Prenom;
        private System.Windows.Forms.Label lbl_Adresse;
        private System.Windows.Forms.Label lbl_CoeffNotoriete;
        private System.Windows.Forms.Label lbl_LieuExercice;
        private System.Windows.Forms.ComboBox cbo_Chercher;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.TextBox txt_Adresse;
        private System.Windows.Forms.TextBox txt_CoeffNotoriete;
        private System.Windows.Forms.ComboBox cbo_LieuExercice;
        private System.Windows.Forms.Button btn_Precedent;
        private System.Windows.Forms.Button btn_Suivant;
        private System.Windows.Forms.Button btn_Fermer;
        private System.Windows.Forms.BindingSource Praticiens;
    }
}