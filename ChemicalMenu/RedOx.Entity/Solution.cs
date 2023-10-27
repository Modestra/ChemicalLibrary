namespace RedOx.Entity;

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