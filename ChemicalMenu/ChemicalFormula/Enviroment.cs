using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
        private bool disposed = false;
        public Enviroment(string molecula, string mrdir)
        {
            Name = $"env_{molecula}";
            PathLog = mrdir + Name;
            Directory.CreateDirectory(PathLog);
            Thread myThread1 = new Thread(new ParameterizedThreadStart(CreateEnviroment));
            myThread1.Name = molecula;
            myThread1.Start(molecula);
        }
        private void AddComponents(object mole)
        {
            Molecula mol = new Molecula((string)mole);
        }
        private void CreateEnviroment(object reaction)
        {
            ThreadEnviromentState = $"Среда {Name} успешно запущена";
            FileStream fs = new FileStream(PathLog + $@"\{Name}.log", FileMode.OpenOrCreate);
            fs.Close();
            File.AppendAllText(PathLog + $@"\{Name}.log", ThreadEnviromentState);
        }
        public Enviroment(string[] moleculalist)
        {

        }
    }
}
