using System;
using DebugUtilites;

namespace ChemicalFormulas
{
    public class ControllerFormulas
    {
        public void ReagentsList(string[] list)
        {
            FileWriter writer = new FileWriter();
            writer.AddTextInFile(list.ToString());
            
        }
    }
    public abstract class OxidIndex { //pH
        public abstract void IndexHydrogen();
    }
    public class OxidSub : OxidIndex
    {
        public override void IndexHydrogen()
        {
            
        }
    }
    public class BaseSub : OxidIndex
    {
        public override void IndexHydrogen()
        {

        }
    }
    public class NeitralSub : OxidIndex{
        public override void IndexHydrogen()
        {
            
        }
    }


}
