using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedOx.Entity
{
    internal interface IChemPartical
    {
        void GetQuantumParams();
        void SetQuantumParams();
        void ConcatPartical();
    }
}
