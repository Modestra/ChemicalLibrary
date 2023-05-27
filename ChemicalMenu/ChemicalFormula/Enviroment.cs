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
    public class Enviroment : IDisposable
    {
        public List<Molecula> Components = new List<Molecula>();
        public List<Thread> Threads = new List<Thread>();
        public string Name { get; set; }
        public string ThreadEnviromentState = "";
        public string PathLog;
        private bool Isdisposed = false;
        public Enviroment(string name, string mrdir)
        {
            Name = name;
            PathLog = mrdir + Name;
            Directory.CreateDirectory(PathLog);
            Thread myThread1 = new Thread(new ParameterizedThreadStart(CreateEnviroment));
            Threads.Add(myThread1);
            myThread1.Name = Name;
            myThread1.Start(Name);
        }
        public void AddComponents(object mole)
        {
            if (Threads[0].Name == Name) //Действует ли поток Среды на данный момент?
            {
                Thread synthes = new Thread(new ParameterizedThreadStart(SynthesesMolecula));
                synthes.Name = (string)mole;
                synthes.Start((string)mole);
                Threads[0].Suspend();
            }
        }
        private void SynthesesMolecula(object mole) //Реализация класса Molecula (Создание молекулы)
        {
            Molecula mol = new Molecula((string)mole);
            mol.GetJsonMolecula(mol, PathLog + $@"\{mole}.json");
            if (mol.ErrorMessage == null)
            {
                Components.Add(mol);
                File.AppendAllText(PathLog + $@"\{Name}.log", $"\n {DateTime.Now} - Молекула {mol.Molecular} успешно добавлена в среду");
                Threads[0].Resume();
            }
            else
            {
                File.AppendAllText(PathLog + $@"\{Name}.log", $"\n Не удалось создать файл: {mol.ErrorMessage}");
            }
        }
        private void CreateEnviroment(object reaction)
        {
            ThreadEnviromentState = $"\n {DateTime.Now} - Среда {Name} успешно запущена";
            File.AppendAllText(PathLog + $@"\{Name}.log", ThreadEnviromentState);
            File.AppendAllText(PathLog + $@"\{Name}.log", $"\n {DateTime.Now} -  Среда {Name} успешно создана");
        }

        public void Dispose()
        {
            if(Isdisposed) return;
        }
    }
}
