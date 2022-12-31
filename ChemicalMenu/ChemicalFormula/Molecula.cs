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
    public class Solution
    {
        public List<Molecula> ions;
        private decimal volume;
        public string errorMessage;
        public decimal Volume
        {
            get { return volume; }
            set
            {
                if (Volume > 0)
                {
                   volume = value;
                }
                else
                {
                    errorMessage = "Объем не может быть меньше или равен нулю";
                }
            }
        }
        public Solution(decimal volume)
        {
            Volume = volume;
        }
    }
    public class Ion
    {

    }
}
