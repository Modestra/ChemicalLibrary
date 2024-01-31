using RedOx.DataBase;

namespace RedOx.Entity;
using System.Collections;

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