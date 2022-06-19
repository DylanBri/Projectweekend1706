using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectweekend1706
{
    public class Proprio
    {
        public string nom;
        public string rue;
        public string ville;
        public string codePostale;
        public string pays;
        public Voitures voiture;

        public Proprio(string pNom, string pRue, string pVille, string pCodePostale, string pPays, Voitures pVoiture)
        {
            nom = pNom;
            rue = pRue;
            ville = pVille;
            codePostale = pCodePostale;
            pays = pPays;
            voiture = pVoiture;
        }
    }
}
