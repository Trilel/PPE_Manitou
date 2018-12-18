using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_Manitou
{
    public partial class FormVisiteurs : Form
    {
        public FormVisiteurs()
        {
            InitializeComponent();
        }

        private void FormVisiterus_Load(object sender, EventArgs e)
        {
            cbo_Chercher.ValueMember = "idVisiteur";//permet de stocker l'identifiant
            cbo_Chercher.DisplayMember = "nom";
            cbo_Chercher.DataSource = Modele.listeVisiteur();

            cbo_Labo.ValueMember = "idLabo";//permet de stocker l'identifiant
            cbo_Labo.DisplayMember = "nomLabo";
            cbo_Labo.DataSource = Modele.listeLaboratoire();

        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGestionDesComptesRendus f = new FormGestionDesComptesRendus();
            f.Show();
        }

        private void cbo_Chercher_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(cbo_Chercher.SelectedIndex);
            txt_Nom.Text = Modele.listeMedecins()[i].nom;
            txt_Prenom.Text = Modele.listeMedecins()[i].prenom;
            txt_Adresse.Text = Modele.listeMedecins()[i].adresse;
        }
    }
}
