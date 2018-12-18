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
    public partial class FormPracticiens : Form
    {
        public FormPracticiens()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGestionDesComptesRendus f = new FormGestionDesComptesRendus();
            f.Show();
        }

        private void FormPracticiens_Load(object sender, EventArgs e)
        {
            
            cbo_Chercher.ValueMember = "idMedecin";//permet de stocker l'identifiant
            cbo_Chercher.DisplayMember = "nom";
            cbo_Chercher.DataSource = Modele.listeMedecins();


          // NE FONCTIONNE PAS   txt_Numero.Text = Modele.listeMedecins()[0].idMedecin;
          //  txt_Nom.Text = Modele.listeMedecins()[0].nom;
          //  txt_Prenom.Text = Modele.listeMedecins()[0].prenom;
          //  txt_Adresse.Text = Modele.listeMedecins()[0].adresse;
           // txt_Ville.Text = Modele.listeMedecins()[0].vill;
         //   txt_CoeffNotoriete.Text = Modele.listeMedecins()[0].contreIndications;
        }

        private void cbo_Chercher_SelectedIndexChanged(object sender, EventArgs e)
        {       
            txt_Numero.Text = cbo_Chercher.SelectedValue.ToString();
            int i = Convert.ToInt32(txt_Numero.Text);
            txt_Nom.Text = Modele.listeMedecins()[i].nom;
            txt_Prenom.Text = Modele.listeMedecins()[i].prenom;
            txt_Adresse.Text = Modele.listeMedecins()[i].adresse;
          //  txt_CoeffNotoriete.Text = Modele.listeMedecins()[i].prenom;

            //    txt_Nom.Text = Modele.lesNomsMedecins(Convert.ToInt32(txt_nom.Text));
            //  txt_Prenom = Modele.lesNomsMedecins
            // txt_Adresse = Modele.lesNomsMedecins
            //  txt_VilleCodePostal = Modele.lesNomsMedecins
            //  txt_CoeffNotoriete = Modele.lesNomsMedecins 

        }
    }
}
