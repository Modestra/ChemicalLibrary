using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL;

namespace EnviromentCore
{
    public class RedOxGraphics
    {
        public RedOxGraphics()
        {

        }
        /// <summary>
        /// Создание групп вершин графа
        /// </summary>
        public void SetGraph(List<Graph> graphs, float[] floats)
        {

        }
        /// <summary>
        /// Создаёт группу графов на основе полученных данных
        /// </summary>
        /// <returns></returns>
        public List<Graph> CreateGraphs(object obj)
        {
            return (List<Graph>)obj;
        }
    }
    /// <summary>
    /// Реализация компонентов графа
    /// </summary>
    public class Graph
    {
        public float[] Color = new float[3];
        public float[] Position = new float[3];
        public Graph(float[] position, float[] color)
        {
            position = Position; color = Color;
        }
        public void CreateCube(float height, List<float[]> position)
        {

        }
        public void CreateTriangle()
        {
            
        }
    }
    public class Cluster
    {
        public Cluster(List<Graph> graphs, List<Egle> egles)
        {

        }
        public void GetGraphMatrix()
        {

        }
    }
    public class Egle
    {
        public float[] Color = new float[3];
        public Egle()
        {

        }
    }
    public class Dot
    {
        public float[] Color = new float[3];
        public float[] Position = new float[3];
        public Dot(float[] position, float[] color)
        {
            Position = position; Color = color;
        }
    }
}
