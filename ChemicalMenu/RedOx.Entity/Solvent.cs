namespace RedOx.Entity;

public class Solvent : Molecula
{
    public string Name { get; set; }
    public Solvent(string mol) : base(mol)
    {
        Name = mol;
    }
}