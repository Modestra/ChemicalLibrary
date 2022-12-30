using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChemicalFormula;
using System;

namespace LibraryTest
{
    [TestClass]
    public class MoleculaTest
    {
        [TestMethod]
        public void Test_of_molecula()
        {
            int num_of_list = 2;
            Molecula molecula = new Molecula("LiHe");
            Assert.AreEqual(molecula.element.Count, num_of_list);
        }
        [TestMethod]
        public void Test_molecular_mass()
        {
            decimal test = 10.94M;
            Molecula molecula = new Molecula("LiHe");
            Assert.AreEqual(molecula.molarmass, test);
        }
    }
}
