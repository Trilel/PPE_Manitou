using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PPE_Manitou
{
    class Modele
    {
        private static ManitouEntities1 maConnexion;
        //private static VISITEUR utilisateurConnecte;

        public static void init()
        {
            /* Instantiation d’un objet de la classe typée chaine de connexion SqlConnection */
            maConnexion = new ManitouEntities1();
        }
        private static string GetMd5Hash(string PasswdSaisi)
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(PasswdSaisi);
            byte[] hash = (MD5.Create()).ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString().ToUpper();
        }
        public static Visiteur VisiteurChoisi { get => VisiteurChoisi; set => VisiteurChoisi = value; }
        public static fichefrais FichefraisChoisi { get => FichefraisChoisi; set => FichefraisChoisi = value; }
        public static List<Visiteur> listeVisiteur()
        {
            return maConnexion.Visiteur.ToList();
        }
        public static Object VisiteurConnecte(string identifiant)
        {
            var LQuery = maConnexion.Visiteur.ToList()
                           .Where(x => x.identifiant == identifiant)
                           .Select(x => new { x.idVisiteur, x.idLabo, x.nom, x.prenom, x.rue, x.cp, x.ville, x.dateEmbauche, x.identifiant, x.password });
            return LQuery.ToList();
        }

        public static bool connection(string id , string mp)
        {
            bool vretour = false;
            var LQuery = maConnexion.Visiteur.ToList()
                           .Where(x => x.identifiant == id)
                           .Select(x => new { x.identifiant, x.password });
            foreach (var v in LQuery)
            {
                if(v.password.Substring(2) == GetMd5Hash(mp))
                {
                    vretour = true;
                }
            }
            return vretour;
        }
        public static bool soumettreFiche(string unIdVisiteur, string unMois, int uneAnnee, int unNbJustificatifs = 0, decimal unMontantValide = 0 ,string unIdEtat = "CR")
        {
            bool vretour = true;
            try
            {
                FichefraisChoisi = new fichefrais();
                FichefraisChoisi.idVisiteur = unIdVisiteur;
                FichefraisChoisi.mois = unIdVisiteur;
                FichefraisChoisi.annee = uneAnnee;
                FichefraisChoisi.nbJustificatifs = unNbJustificatifs;
                FichefraisChoisi.montantValide = unMontantValide;
                FichefraisChoisi.idEtat = unIdEtat;
                maConnexion.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
            }
            return vretour;
        }
    }
}
