using System;
using System.Collections.Generic;
using System.IO;
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
        public string Name { get; set; }
        public string ThreadEnviromentState = "";
        public string PathLog;
        public Enviroment(string molecula, string log)
        {
            PathLog = log + $"{molecula}.log";
            Name = $"env_{molecula}";
            FileStream fs = new FileStream(PathLog, FileMode.OpenOrCreate);
            Thread myThread1 = new Thread(new ParameterizedThreadStart(CreateEnviroment));
            myThread1.Name = molecula;
            myThread1.Start(molecula);
            fs.Close();
        }
        private void AddComponentsAsync(object mole)
        {
            ThreadEnviromentState = "";
            Molecula mol = new Molecula((string)mole);
            //mol.GetJsonMolecula(mol, $@"C:\Users\Пользователь\OneDrive\Рабочий стол\Проектный менеджмент\testing\{mol.Molecular}.json");
        }
        private void CreateEnviroment(object reaction)
        {
            ThreadEnviromentState = $"Среда {Name} успешно запущена";
            File.AppendAllText(PathLog, ThreadEnviromentState);
        }
        public Enviroment(string[] moleculalist)
        {

        }
    }
}
