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

        public static bool connection(string unId , string unMdp)
        {
            bool vretour = false;
            var LQuery = maConnexion.Visiteur.ToList()
                           .Where(x => x.identifiant == unId)
                           .Select(x => new { x.identifiant, x.password });
            foreach (var v in LQuery)
            {
                if(v.password == unMdp)
                {
                    vretour = true;
                }
            }
            return vretour;
        }
    }
}
