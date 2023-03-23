using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Remoting.Contexts;
using System.Collections;

namespace ChemicalFormula
{
    [Serializable]
    public class Molecula
    {
        public string molecular { get; set; }
        public double molarmass { get; set; }
        public List<Ion> element = new List<Ion>();
        public double mole { get; set; }
        [NonSerialized]
        private List<double> molarmasslist;
        public string errorMessage { get; set; }
        public Molecula(string molecular)
        {
            this.molecular = molecular;
            molarmasslist = new List<double>();
            List<string> list = molecular.Split(new char[] {'(',')','[',']'}).ToList();
            for(int i = 0; i < list.Count; i++)
            {
                if(i+1 != list.Count)
                {
                    if (int.TryParse(list[i + 1], out int n))
                    {
                        Ion ion = new Ion(list[i], int.Parse(list[i + 1]));
                        element.Add(ion);
                        list.RemoveAt(i + 1);
                    }
                    else
                    {
                        Ion ion = new Ion(list[i], 1);
                        element.Add(ion);
                        continue;
                    }
                }
                else
                {
                    Ion ion = new Ion(list[i], 1);
                    element.Add(ion);
                    continue;
                }
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
            foreach(Ion ion in element)
            {
                for(int i = 0; i < ion.atoms.Count - 1; i++)
                {
                    if((ion.atoms[i].IsMetal == false && ion.atoms[i].IsMetal == true) || 
                        (ion.atoms[i].IsMetal == true && ion.atoms[i].IsMetal == false))
                    {
                        list.Add($"{ion.atoms[i].atomName} - {ion.atoms[i+1].atomName}", -1); //Ионная связь
                    }
                    else if (ion.atoms[i].IsMetal == true && ion.atoms[i].IsMetal == true)
                    {
                        list.Add($"{ion.atoms[i].atomName} - {ion.atoms[i + 1].atomName}", 0); //Металлическая связь
                    }
                    else
                    {
                        list.Add($"{ion.atoms[i].atomName} - {ion.atoms[i + 1].atomName}", 1); //Ковалентная связь
                    }
                }
            }
            return list;
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
    public class Ion : IEnumerable
    {
        public string ionName { get; set; }
        public List<Atom> atoms = new List<Atom>();
        public int count { get; set; }
        public bool IsMetal;
        public IEnumerator GetEnumerator() => atoms.GetEnumerator();
        private char[] numbers = "0123456789".ToCharArray();

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

            }

        }
    }
    [Serializable]
    public class Atom
    {
        public string atomName { get; set; }
        public double atomMass { get; set; }
        public int count { get; set; }
        public bool IsMetal;
        private double ionPotential;
        public Atom(string atomName, int count)
        {
            DataBaseConnect connect = new DataBaseConnect();
            this.atomName = atomName;
            this.count = count;
            atomMass = Convert.ToDouble(connect.GetCharacteristic(atomName, 3));
            ionPotential = Convert.ToDouble(connect.GetCharacteristic(atomName, 4));
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
