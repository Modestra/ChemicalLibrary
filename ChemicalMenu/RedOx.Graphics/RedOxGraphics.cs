using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedOx.Graphics
{
   
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
