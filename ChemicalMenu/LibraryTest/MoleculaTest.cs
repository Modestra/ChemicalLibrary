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
        [TestMethod]
        public void Test_molecula_Dummy()
        {
            string errorMessage = "Не явно выражена формула";
            Molecula molecula = new Molecula("");
            Assert.AreEqual(molecula.errorMessage, errorMessage);
        }
    }
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void Solution_Zero_Value()
        {
            Molecula molecula = new Molecula("LiHe");
            string test = "Объем не может быть меньше или равен нулю";
            Solution solution = new Solution(0, molecula);
            Assert.AreEqual(solution.errorMessage, test);
        }
        [TestMethod]
        public void Solution_Count_Of_Moleculas()
        {
            Molecula molecula = new Molecula("LiHe");
            
        }
    }
}
