using System;

namespace ChemicalFormulas
{
    public class ControllerFormulas
    {
        OxidIndex od = new BaseSub("something");
        
    }
    public abstract class OxidIndex { //pH
        public string Name {get;}
        public OxidIndex(string name)
        {
            Name = name;
        }
        public void InfoAboutSubstance()
        {

        }
    }
    class BaseSub : OxidIndex 
    {
        public BaseSub(string name): base(name) { }
    }
    class OxidSub : OxidIndex
    {
        public OxidSub(string name): base(name) { }
    }

}
