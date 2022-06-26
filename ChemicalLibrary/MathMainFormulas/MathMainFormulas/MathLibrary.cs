using System.Collections.Generic;
using System.Linq;

namespace MathMainFormulas
{
    public class MathLibrary
    {
        public static long Fact(long n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }
    }
    public class Probability
    {
        private void Prob(List<double> number)
        {
            foreach(int numberItem in number)
            {
                double Item = numberItem / number.Sum();
                number.Remove(numberItem);
                number.Add(Item);
            }
        }
        public void Bernully()
        {

        }
    }
    public class Combinatorics 
    { 
        public int CombSelection(int n, int k)
        {
            return 1;
        }
    }


}
