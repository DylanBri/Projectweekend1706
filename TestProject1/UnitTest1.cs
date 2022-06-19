using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projectweekend1706;
using System.Collections.Generic;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLaasPlaque()
        {
            Voitures voiture1 = new Voitures("1009 LAAS", "2011");
            Assert.AreEqual(voiture1.VerifieLaasPlaque(voiture1.plaque), "De Laas");

            Voitures voiture2 = new Voitures("1008 Aix", "2011");
            Assert.AreEqual(voiture2.VerifieLaasPlaque(voiture2.plaque), "Pas de Laas");
        }

        [TestMethod]
        public void TestNombrePremier()
        {
            Assert.AreEqual(OrderedNumbers.Primes(1009), "Ok");
        }

        [TestMethod]
        public void TestProprioLaas()
        {
            Voitures voiture1 = new Voitures("1009 LAAS", "2011");
            Proprio proprio1 = new Proprio("Quentin", "13 rue Mat", "Aix", "13080", "France", voiture1);
            Assert.AreNotEqual(proprio1.ville, "Laas");
        }

        [TestMethod]
        public void TestListProprioLaas()
        {
            Voitures voiture1 = new Voitures("1009 LAAS", "2011");
            Proprio proprio1 = new Proprio("Quentin", "13 rue Mat", "Aix", "13080", "France", voiture1);


            Voitures voiture2 = new Voitures("1009 PQQR", "2011");
            Proprio proprio2 = new Proprio("Math", "13 rue Mat", "Aix", "13080", "France", voiture2);

            Voitures voiture3 = new Voitures("1009 LAAS", "2011");
            Proprio proprio3 = new Proprio("Felippe", "13 rue Mat", "Aix", "13080", "France", voiture3);

            List<Proprio> proprios = new List<Proprio>();

            if (proprio1.voiture.VerifieLaasPlaque(proprio1.voiture.plaque) == "De Laas")
                proprios.Add(proprio1);
            if (proprio2.voiture.VerifieLaasPlaque(proprio2.voiture.plaque) == "De Laas")
                proprios.Add(proprio2);
            if (proprio3.voiture.VerifieLaasPlaque(proprio3.voiture.plaque) == "De Laas")
                proprios.Add(proprio3);
            Assert.AreEqual(proprios.Count, 2);
        }
    }
}
