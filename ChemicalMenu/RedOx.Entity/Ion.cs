using System.Collections;

namespace RedOx.Entity;
using EnviromentCore;
using System.Text.RegularExpressions;
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