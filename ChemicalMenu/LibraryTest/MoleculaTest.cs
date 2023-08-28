using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnviromentCore;
using System;

namespace LibraryTest
{
    [TestClass]
    public class MoleculaTest
    {
        
    }
    [TestClass]
    public class SolutionTest
    {

    }
    [TestClass]
    public class EnviromentTest 
    {
        public string TestPath = @"C:\Users\Пользователь\OneDrive\Рабочий стол\Работа\";
        [TestMethod]
        public void Molecula_NonCorrect_Value()
        {
            string molecular = "";
            string result = $"\n {DateTime.Now} - Некорректный ввод данных. Тип данных Molecula.molecular - {molecular.GetType()}";
            using (Enviroment enviroment = new Enviroment("test", TestPath))
            {
                enviroment.AddComponents(molecular);
                Molecula mol = enviroment.Components[0];
                Assert.AreEqual(molecular, mol.ErrorMessage[0]);

            }
        }
    }
}
