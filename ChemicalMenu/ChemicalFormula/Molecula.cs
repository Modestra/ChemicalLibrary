using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.Json;

namespace ChemicalFormula
{
    [Serializable]
    public class Molecula
    {
        public string errorMessage;

        public List<Ion> element = new List<Ion>();
        public double molarmass;
        public string Molecular { get; set; }
        public double mole;
        [NonSerialized]
        private List<double> molarmasslist;
        private char[] numbers = "0123456789".ToCharArray();
        public Molecula(string molecular)
        {
            molarmasslist = new List<double>();
            Regex reg = new Regex(@"([A-Z]+[a-z].)|([A-Z]\d)|([A-Z])");
            MatchCollection match = reg.Matches(molecular);
                if (match.Count > 0)
                {
                    foreach (Match m in match)
                    {
                        if (char.IsDigit(m.Value[m.Length - 1]))
                        {
                            Ion ion = new Ion(m.Value.Trim(numbers), (int)m.Value[m.Length - 1] - 48);
                            element.Add(ion);
                            molarmasslist.Add(ion.atomicMass * (int)m.Value[m.Length - 1] - 48);
                        }
                        else
                        {
                            Ion ion = new Ion(m.Value, 1);
                            element.Add(ion);
                            molarmasslist.Add(ion.atomicMass);
                        }
                    }
                }
                else
                {
                    errorMessage = "Не явно выражена формула";
                }
            molarmass = molarmasslist.Sum();
            GC.Collect();
            GC.GetTotalMemory(true);
            GC.WaitForPendingFinalizers();
        }
        public int RedOxFeature()
        {
            return 0;
        }
        public Dictionary<string, int> TypeOfBound()
        {
            Dictionary<string,int> list = new Dictionary<string, int>();
            int n = element.Count;
            for(int i = 0; i < element.Count; i++)
            {
                if(i+1 != n)
                {
                    if (element[i].IsMetal == true && !element[i + 1].IsMetal == true)
                    {
                        list.Add($"{element[i].ionName}-{element[i + 1].ionName}", 1); //Ионная связь
                    }
                    else
                    {
                        list.Add($"{element[i].ionName}-{element[i + 1].ionName}", 0); //Ковалентная связь
                    }
                }
                else
                {
                    continue;
                }
            }
            return list;
        }
        public async void SaveInJson(Molecula mol)
        {
            using (FileStream fs = new FileStream(@"C:\Users\Пользователь\OneDrive\Рабочий стол\user.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync(fs, mol);
            }
        }
    }
    public class Solution
    {
        public List<Molecula> ions;
        public string errorMessage;
        public List<double> concentration = new List<double>();
        public object solutionColor { get; }
        public double Volume;
        public Solution(double volume, List<Molecula> list)
        {
            Volume = volume;
            if (Volume > 0)
            {
                
            }
            else
            {
                errorMessage = "Объем не может быть меньше или равен нулю";
            }
            ions = list;

        }
        public Solution(double volume, Molecula molecula)
        {
            Volume = volume;
            if (Volume > 0 && Volume > molecula.mole)
            {
                concentration.Add(molecula.mole/Volume);
            }
            else
            {
                errorMessage = "Объем не может быть меньше или равен нулю";
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
                errorMessage = "Объем не может быть меньше или равен нулю";
            }
            ions.Add(molecula);
        }
        public void AddMolecula(Molecula mol)
        {
            ions.Add(mol);
        }
    }
    public class Ion 
    {
        public string ionName { get; set; }
        public double atomicMass;
        public int count;
        public bool IsMetal;
        [NonSerialized]
        private double ionPotential;

        public Ion(string ionName, int count)
        {
            DataBaseConnect connect = new DataBaseConnect();
            this.ionName = ionName;
            this.count = count;
            atomicMass = Convert.ToDouble(connect.GetCharacteristic(ionName, 3));
            ionPotential = Convert.ToDouble(connect.GetCharacteristic(ionName, 4));
            if (ionPotential < 1.5 && ionPotential != 0)
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
