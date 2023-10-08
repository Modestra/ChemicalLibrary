using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Collections;
using Newtonsoft.Json;
using System.Threading;
using EnviromentCore;
using static IronPython.Modules._ast;

namespace RedOx.Entity
{
    [Serializable]
    public class Molecula
    {
        public string Molecular { get; set; }
        public double Molarmass { get; set; }
        public List<Ion> Element = new List<Ion>();
        public double Mole { get; set; }
        [NonSerialized]
        private List<double> Molarmasslist;
        public string[] ErrorMessage { get; set; }
        /// <summary>
        /// Основной класс RedOx. Характеристики молекулы
        /// </summary>
        /// <param name="molecular">Название молекулы</param>
        public Molecula(string molecular)
        {
            Molecular = molecular;
            if(molecular != String.Empty || molecular.GetType() != typeof(string))
            {
                Molarmasslist = new List<double>();
                List<string> list = molecular.Split(new char[] { '(', ')', '[', ']' }).ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    if (i + 1 != list.Count)
                    {
                        if (int.TryParse(list[i + 1], out int n))
                        {
                            Ion ion = new Ion(list[i], int.Parse(list[i + 1]));
                            Element.Add(ion);
                            list.RemoveAt(i + 1);
                            ErrorMessage.Append(ion.ErrorMessage);
                        }
                        else
                        {
                            Ion ion = new Ion(list[i], 1);
                            Element.Add(ion);
                            ErrorMessage.Append(ion.ErrorMessage);
                            continue;
                        }
                    }
                    else
                    {
                        Ion ion = new Ion(list[i], 1);
                        Element.Add(ion);
                        ErrorMessage.Append(ion.ErrorMessage);
                        continue;
                    }
                }
                Molarmass = Molarmasslist.Sum();
            }
            else
            {
                ErrorMessage.Append($"\n {DateTime.Now} - Некорректный ввод данных. Тип данных Molecula.molecular - {molecular.GetType()}");
            }
        }
        public void GetJsonMolecula(Molecula mol, string path)
        {
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                {
                    fs.Close();
                    string json = JsonConvert.SerializeObject(mol, Formatting.Indented);
                    File.AppendAllText(path, json);
                }
            }
            catch
            {
                ErrorMessage.Append("Отказано в пути к папке");
            }
        }
        public int RedOxFeature()
        {
            return 0;
        }
        /// <summary>
        /// Выводит список всех связей в молекуле
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> TypeOfBound()
        {
            Dictionary<string,int> list = new Dictionary<string, int>();
            foreach(Ion ion in Element)
            {
                for(int i = 0; i < ion.atoms.Count - 1; i++)
                {
                    if((ion.atoms[i].IsMetal == false && ion.atoms[i].IsMetal == true) || 
                        (ion.atoms[i].IsMetal == true && ion.atoms[i].IsMetal == false))
                    {
                        list.Add($"{ion.atoms[i].AtomName} - {ion.atoms[i+1].AtomName}", -1); //Ионная связь
                    }
                    else if (ion.atoms[i].IsMetal == true && ion.atoms[i].IsMetal == true)
                    {
                        list.Add($"{ion.atoms[i].AtomName} - {ion.atoms[i + 1].AtomName}", 0); //Металлическая связь
                    }
                    else
                    {
                        list.Add($"{ion.atoms[i].AtomName}  -  {ion.atoms[i + 1].AtomName}", 1); //Ковалентная связь
                    }
                }
            }
            return list;
        }
    }
    public class Solution
    {
        public List<Molecula> Ions;
        public string ErrorMessage;
        public List<double> Concentration = new List<double>();
        public object SolutionColor { get; }
        public double Volume;
        /// <summary>
        /// Класс, описывающий систему, в состав в которую входят более 2-3 типов молекул
        /// </summary>
        /// <param name="volume"></param>
        /// <param name="list">Список молекул, находящиеся в растворе</param>
        /// <param name="solvent">Растворитель</param>
        public Solution(double volume, List<Molecula> list, Solvent solvent)
        {
            Volume = volume;
            if (Volume > 0)
            {
                
            }
            else
            {
                ErrorMessage = "Объем не может быть меньше или равен нулю";
            }
            Ions = list;

        }
        public Solution(double volume, Molecula molecula)
        {
            Volume = volume;
            if (Volume > 0 && Volume > molecula.Mole)
            {
                Concentration.Add(molecula.Mole/Volume);
            }
            else
            {
                ErrorMessage = "Объем не может быть меньше или равен нулю";
            }


        }
        public Solution(double volume, Molecula molecula, Solvent solvent)
        {
            Volume = volume;
            if (Volume > 0)
            {

            }
            else
            {
                ErrorMessage = "Объем не может быть меньше или равен нулю";

            }
            Ions.Add(molecula);
        }
        public void AddMolecula(Molecula mol)
        {
            Ions.Add(mol);
        }
    }
    public class Ion : IEnumerable
    {
        public string ionName { get; set; }
        public List<Atom> atoms = new List<Atom>();
        public int count { get; set; }
        public bool IsMetal;
        public IEnumerator GetEnumerator() => atoms.GetEnumerator();
        private char[] numbers = "0123456789".ToCharArray();

        public string ErrorMessage { get; set; }

        public Ion(string ionName, int count)
        {
            DataBaseConnect connect = new DataBaseConnect();
            this.ionName = ionName;
            Regex region = new Regex(@"([A-Z]+[a-z]\d)|([A-Z]+[a-z])|([A-Z]+[a-z]\d)|([A-Z]\d)|([A-Z])");
            this.count = count;
            MatchCollection match = region.Matches(this.ionName);
            if(match.Count > 0)
            {
                foreach(Match m in match)
                {
                    if (Char.IsDigit(m.Value[m.Length - 1]))
                    {
                        Atom atom = new Atom(m.Value.Trim(numbers), (int)m.Value[m.Length - 1] - 48);
                        atoms.Add(atom);
                    }
                    else
                    {
                        Atom atom = new Atom(m.Value, 1);
                        atoms.Add(atom);
                    }
                }
            }
            else
            {
                ErrorMessage = $"\n {DateTime.Now} - Недостаточно компонентов для реализации иона";
            }

        }
    }
    [Serializable]
    public class Atom
    {
        public string AtomName { get; set; }
        public double AtomMass { get; set; }
        public int Count { get; set; }
        public bool IsMetal;
        public double IonPotential;
        public Atom(string atomName, int count)
        {
            DataBaseConnect connect = new DataBaseConnect();
            this.AtomName = atomName;
            this.Count = count;
            AtomMass = Convert.ToDouble(connect.GetCharacteristic(atomName, 3));
            IonPotential = Convert.ToDouble(connect.GetCharacteristic(atomName, 4));
            if (IonPotential < 1.5 && IonPotential != 0)
            {
                IsMetal = true;
            }
        }
    }
    public class Solvent : Molecula
    {
        public string Name { get; set; }
        public Solvent(string mol) : base(mol)
        {
            Name = mol;
        }
    }
}
