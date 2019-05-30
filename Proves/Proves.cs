using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Llibreria;

namespace Proves
{
    [TestClass]
    public class Proves
    {
        [TestMethod]
        public void primer1()
        {
            Boolean resultat;
            ClBiblio clE = new ClBiblio();
            resultat = clE.esPrimer(7);
            //Console.WriteLine("Resultado: " + resultat);
            Assert.AreEqual(false, resultat);
        }

        [TestMethod]
        public void primer2()
        {
            Boolean resultat;
            ClBiblio clE = new ClBiblio();
            resultat = clE.esPrimer(5);
            //Console.WriteLine("Resultado: " + resultat);
            Assert.AreEqual(false, resultat);
        }

        [TestMethod]
        public void primer3()
        {
            Boolean resultat;
            ClBiblio clE = new ClBiblio();
            resultat = clE.esPrimer(8);
            //Console.WriteLine("Resultado: " + resultat);
            Assert.AreEqual(true, resultat);
        }

        [TestMethod]
        public void primer4()
        {
            Boolean resultat;
            ClBiblio clE = new ClBiblio();
            resultat = clE.esPrimer(3);
            //Console.WriteLine("Resultado: " + resultat);
            Assert.AreEqual(false, resultat);
        }

    }
}
