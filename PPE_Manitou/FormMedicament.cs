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
    public partial class FormMedicament : Form
    {
        public FormMedicament()
        {
    
            InitializeComponent();
        }

        private void btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGestionDesComptesRendus f = new FormGestionDesComptesRendus();
            f.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void FormMedicament_Load(object sender, EventArgs e)
        {/*
            comboBox1.Text = Modele.listeMedicaments()[0].idMedicament;
            textBox2.Text = Modele.listeMedicaments()[0].nomCommercial;
            textBox3.Text = Modele.listeMedicaments()[0].idFamille;
            textBox4.Text = Modele.listeMedicaments()[0].composition;
            textBox5.Text = Modele.listeMedicaments()[0].effets;
            textBox6.Text = Modele.listeMedicaments()[0].contreIndications;
        */
            comboBox1.ValueMember = "idMedicament";//permet de stocker l'identifiant
            comboBox1.DisplayMember = "idMedicament";
            comboBox1.DataSource = Modele.listeMedicaments();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

          //  txt_Numero.Text = comboBox1.SelectedValue.ToString();
            int i = Convert.ToInt32(comboBox1.SelectedIndex);
            textBox2.Text = Modele.listeMedicaments()[i].nomCommercial;
            textBox3.Text = Modele.listeMedicaments()[i].FAMILLE.libFamille;
            textBox4.Text = Modele.listeMedicaments()[i].composition;
            textBox5.Text = Modele.listeMedicaments()[i].effets;
            textBox6.Text = Modele.listeMedicaments()[i].contreIndications;

        }
    }
}
