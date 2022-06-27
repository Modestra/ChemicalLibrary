using System.Collections.Generic;
using System.Linq;

namespace MathMainFormulas
{
    public class MathLibrary
    {
        public long Fact(long n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }
    }
    public class Probability
    {
        MathLibrary library = new MathLibrary();
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
        MathLibrary library = new MathLibrary();
        public long CombSelection(long n, long k) //Работает)
        {
            long b = library.Fact(n)/(library.Fact(k)*library.Fact(n-k));
            return b;

        }
    }


}
