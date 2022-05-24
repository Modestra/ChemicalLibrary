using System;

namespace ChemicalFormulas
{
    public class ControllerFormulas
    {
        
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
