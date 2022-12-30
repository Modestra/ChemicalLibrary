using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ChemicalMenu;

namespace ChemicalFormula
{
    public class Molecula
    {
        public List<string> element = new List<string>();
        private List<decimal> molarmasslist;
        public decimal molarmass;
        public string Molecular { get; set; }
        public Molecula(string molecular)
        {
            DataBaseConnect connect = new DataBaseConnect();
            molarmasslist = new List<decimal>();
            Regex reg = new Regex(@"([A-Z]+)([^A-Z])*");
            MatchCollection match = reg.Matches(molecular);
            if(match.Count > 0)
            {
                foreach(Match m in match)
                {
                    element.Add(m.Value);
                    decimal mass = connect.GetDecimal(Convert.ToString(m));
                    molarmasslist.Add(mass);
                }
            }
            else
            {
                //Неправильно записанная формула
            }
            molarmass = molarmasslist.Sum();
        }
    }
}
