using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectweekend1706
{
    public class Voitures
    {
        public string plaque;
        public string annee;

        public bool VerifieLaasPlaque(string unePlaque)
        {
            string les4PremieresLettres = unePlaque.Substring(0,4);
            int les4PremieresLettresInt = Int32.Parse(les4PremieresLettres);
            if ((Regex.Match(unePlaque, @"^\d{4} LAAS").Success) && (OrderedNumbers.Primes().Contains(les4PremieresLettresInt))) 
                return true;
            else
                return false;
        }

        public Voitures(string pPlaque, string pAnne)
        {
             plaque = pPlaque;
             annee = pAnne;
        }

    }
}
