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

        /////////////////////////////////////////////////////////////////////////


        [TestMethod]
        public void esMesGran1()
        {
            int resultat;
            ClBiblio clE = new ClBiblio();
            resultat = clE.esMesGran(5, 10);
            Console.WriteLine("Resultado: " + resultat);
            Assert.AreEqual(10, resultat);
        }

        [TestMethod]
        public void esMesGran2()
        {
            int resultat;
            ClBiblio clE = new ClBiblio();
            resultat = clE.esMesGran(10, 5);
            Console.WriteLine("Resultado: " + resultat);
            Assert.AreEqual(10, resultat);
        }

        [TestMethod]
        public void esMesGran3()
        {
            int resultat;
            ClBiblio clE = new ClBiblio();
            resultat = clE.esMesGran(41, 845);
            Console.WriteLine("Resultado: " + resultat);
            Assert.AreEqual(845, resultat);
        }

        [TestMethod]
        public void esMesGran4()
        {
            int resultat;
            ClBiblio clE = new ClBiblio();
            resultat = clE.esMesGran(41, 84);
            Console.WriteLine("Resultado: " + resultat);
            Assert.AreEqual(84, resultat);
        }

        /////////////////////////////////////////////////////////////

        [TestMethod]
        public void esMesPetit1()
        {
            int resultat;
            ClBiblio clE = new ClBiblio();
            resultat = clE.esMesPetit(41, 84);
            Console.WriteLine("Resultado: " + resultat);
            Assert.AreEqual(41, resultat);
        }

        [TestMethod]
        public void esMesPetit2()
        {
            int resultat;
            ClBiblio clE = new ClBiblio();
            resultat = clE.esMesPetit(2, 24);
            Console.WriteLine("Resultado: " + resultat);
            Assert.AreEqual(2, resultat);
        }

        [TestMethod]
        public void esMesPetit3()
        {
            int resultat;
            ClBiblio clE = new ClBiblio();
            resultat = clE.esMesPetit(14, 12);
            Console.WriteLine("Resultado: " + resultat);
            Assert.AreEqual(12, resultat);
        }
    }
}
