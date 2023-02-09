using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChemicalFormula
{
    public class Molecula
    {
        public string errorMessage;

        public List<Ion> element = new List<Ion>();
        public double molarmass;
        public string Molecular { get; set; }
        public double mole;

        private List<double> molarmasslist;
        public Molecula(string molecular)
        {
            molarmasslist = new List<double>();

            Regex reg = new Regex(@"([A-Z]+)([^A-Z])*");
            MatchCollection match = reg.Matches(molecular);
            if(match.Count > 0)
            {
                foreach(Match m in match)
                {
                    Ion ion = new Ion(m.Value);
                    element.Add(ion);
                    molarmasslist.Add(ion.atomicMass);
                }
            }
            else
            {
                errorMessage = "Не явно выражена формула";
            }
            molarmass = molarmasslist.Sum();
            GC.Collect();
            GC.GetTotalMemory(true); GC.WaitForPendingFinalizers();
        }
        public int RedOxFeature()
        {
            return 0;
        }
        public List<int> TypeOfBound()
        {
            List<int> list = new List<int>();
            int n = element.Count;
            for(int i = 0; i < element.Count; i++)
            {
                if(i+1 != n)
                {
                    if (element[i].IsMetal == true && element[i + 1].IsMetal == true)
                    {
                        list.Add(1);
                    }
                    else
                    {
                        list.Add(0);
                    }
                }
                else
                {
                    continue;
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
    public class Ion 
    {
        private double ionPotential;
        public string ionName { get; set; }
        public List<double> ions { get; set; }
        public double atomicMass;
        public bool IsMetal;

        public Ion(string ionName)
        {
            DataBaseConnect connect = new DataBaseConnect();
            this.ionName = ionName;
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
