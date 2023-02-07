using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChemicalFormula
{
    internal class CreateReaction
    {
        public string errorMessage { get; set; }
        public CreateReaction(List<Molecula> components)
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
