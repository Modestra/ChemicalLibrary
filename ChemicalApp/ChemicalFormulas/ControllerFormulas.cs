using System;

namespace ChemicalFormulas
{
    public class ControllerFormulas
    {
        public void NumberRule(int val)
        {
            if (val < 0 || val > 14)
            {
                throw new NumberException("", val);

            }
        }
    }
    public abstract class OxidIndex
    { //pH
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
    public class NeitralSub : OxidIndex
    {
        public override void IndexHydrogen()
        {

        }
    }
    public class NumberException : Exception
    {
        public int Number { get; }
        public NumberException(string message, int num) : base(message)
        {
            Number = num;
        }
    }

}
