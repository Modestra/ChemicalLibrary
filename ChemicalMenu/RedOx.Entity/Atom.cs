namespace RedOx.Entity;
using System.Collections;

[Serializable]
public class Atom: IChemPartical
{
    public string AtomName { get; set; }
    public double AtomMass { get; set; }
    public int Count { get; set; }
    public bool IsMetal;
    public double IonPotential;
    public Atom(string atomName, int count)
    {
        this.AtomName = atomName;
        this.Count = count;
        if (IonPotential < 1.5 && IonPotential != 0)
        {
            IsMetal = true;
        }
    }

    public void SetQuantumParams()
    {
        throw new NotImplementedException();
    }

    public void ConcatPartical()
    {
        throw new NotImplementedException();
    }

    public void GetQuantumParams()
    {
        throw new NotImplementedException();
    }
}