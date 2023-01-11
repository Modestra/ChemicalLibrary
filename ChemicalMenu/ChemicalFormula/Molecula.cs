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
        public decimal molarmass;
        public string Molecular { get; set; }
        public decimal mole;

        private List<decimal> molarmasslist;
        public Molecula(string molecular)
        {
            molarmasslist = new List<decimal>();
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
        }
        public int RedOxFeature()
        {
            return 0;
        }
    }
    public class Solution
    {
        public List<Molecula> ions;
        public string errorMessage;
        public List<decimal> concentration;
        public object solutionColor { get; }
        public decimal Volume;
        public Solution(decimal volume, List<Molecula> list)
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
        public Solution(decimal volume, Molecula molecula)
        {
            Volume = volume;
            if (Volume > 0 && Volume < molecula.mole)
            {
                concentration.Add(molecula.mole/Volume);
            }
            else
            {
                errorMessage = "Объем не может быть меньше или равен нулю";
            }


        }
        public Solution(decimal volume, Molecula molecula, Solvent solvent)
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
        public decimal atomicMass;

        public Ion(string ionName)
        {
            DataBaseConnect connect = new DataBaseConnect();
            this.ionName = ionName;
            atomicMass = connect.GetColumn(ionName, 3);
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
