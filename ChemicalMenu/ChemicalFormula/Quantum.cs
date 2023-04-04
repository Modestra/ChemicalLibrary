using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemicalFormula
{
    public class Quantum
    {
        private List<Atom> graph;
        public Quantum(Molecula reaction)
        {
            graph = new List<Atom>();
            foreach(Ion ion in reaction.Element)
            {
                for (int i = 0; i <= ion.count - 1; i++)
                {
                    if (ion.atoms[i].Count != 1)
                    {
                        graph.AddRange(Enumerable.Repeat(ion.atoms[i], ion.atoms[i].Count).ToArray());
                    }
                    else
                    {
                        graph.Add(ion.atoms[i]);
                    }
                }
            }
            Atom n;
            for (int w = 0; w < graph.Count; w++)
            {
                for (int i = 0; i < graph.Count - 1; i++)
                {
                    if (graph[i].IonPotential > graph[i + 1].IonPotential)
                    {
                        n = graph[i + 1];
                        graph[i + 1] = graph[i];
                        graph[i] = n;
                    }
                }
            }
            
        }
    }
}
