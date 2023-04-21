using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ChemicalFormula;

namespace EnviromentCore
{
    /// <summary>
    /// Среда, в которой будут происходить взаимодействия веществ.
    /// Используется для ассинхронного программирования
    /// </summary>
    public class Enviroment
    {
        public List<Molecula> Components { get; set; }
        public Enviroment(string molecula)
        {
            Thread myThread1 = new Thread(new ParameterizedThreadStart(AddComponentsAsync));
            myThread1.Name = molecula;
            myThread1.Start(molecula);

        }
        private void AddComponentsAsync(object mole)
        {
            Molecula mol = new Molecula((string)mole);
        }

        public Enviroment(string[] moleculalist)
        {

        }
    }
}
