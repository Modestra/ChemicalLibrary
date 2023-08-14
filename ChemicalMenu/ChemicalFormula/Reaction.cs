using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EnviromentCore
{
    internal class Reaction
    {
        public string errorMessage { get; set; }
        public Reaction(List<Molecula> components)
        {
            Thread reaction = Thread.CurrentThread;
            if(components.Count != 0)
            {
                reaction.Start();
                for (int i = 0; i < components.Count; i++ )
                {
                    
                }
            }
            else
            {
                errorMessage = "Отсутствие компонентов для проведения реакции";
            }
        }
    }
}
