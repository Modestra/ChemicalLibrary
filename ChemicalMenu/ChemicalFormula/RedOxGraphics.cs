using System;
using System.Collections.Generic;
using System.Drawing;
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

    }
    /// <summary>
    /// Реализация компонентов графа
    /// </summary>
    public class Graph
    {
        public float[] Color = new float[3];
        public float[] Position = new float[3];
        private readonly OpenGLControl Gl_controll;
        public Graph(OpenGLControl gl)
        {
            Gl_controll = gl;
        }
        public void CreateCube(float radius, float[] position, float[] color)
        {
            OpenGL gl = Gl_controll.OpenGL;
            gl.Translate(0.0f, 0.0f, -6.0f);
            gl.Begin(OpenGL.GL_TRIANGLES);
            //Левая сторона
            gl.Color(color[0], color[1], color[2]);
            gl.Vertex(1.0f * radius + position[0], 0.0f * radius + position[1], 0.0f * radius + position[2]);
            gl.Vertex(1.0f * radius + position[0], -1.0f * radius + position[1], 0.0f * radius + position[2]);
            gl.Vertex(0.0f * radius + position[0], -1.0f * radius + position[1], 0.0f * radius + position[2]);
            gl.Vertex(0.0f * radius + position[0], -1.0f * radius + position[1], 0.0f * radius + position[2]);
            gl.Vertex(0.0f * radius + position[0], 0.0f * radius + position[1], 0.0f * radius + position[2]);
            gl.Vertex(1.0f * radius + position[0], 0.0f * radius + position[1], 0.0f * radius + position[2]);
            //Правая сторона
            gl.Vertex(0 * radius + position[0], 0 * radius + position[1], 0 * radius + position[2]);
            gl.Vertex(0.0f * radius + position[0], -1.0f * radius + position[1], 0.0f * radius + position[2]);
            gl.Vertex(0.0f * radius + position[0], -1.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(0.0f * radius + position[0], -1.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(0.0f * radius + position[0], 0.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(0 * radius + position[0], 0 + position[1], 0 + position[2]);
            //Дно
            gl.Vertex(0.0f * radius + position[0], -1.0f * radius + position[1], 0.0f * radius + position[2]);
            gl.Vertex(1.0f * radius + position[0], -1.0f * radius + position[1], 0.0f * radius + position[2]);
            gl.Vertex(0.0f * radius + position[0], -1.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(0.0f * radius + position[0], -1.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(1.0f * radius + position[0], -1.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(1.0f * radius + position[0], -1.0f * radius + position[1], 0.0f * radius + position[2]);
            //Вверх
            gl.Vertex(0.0f * radius + position[0], 0.0f * radius + position[1], 0.0f * radius + position[2]);
            gl.Vertex(1.0f * radius + position[0], 0.0f * radius + position[1], 0.0f * radius + position[2]);
            gl.Vertex(0.0f * radius + position[0], 0.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(0.0f * radius + position[0], 0.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(1.0f * radius + position[0], 0.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(1.0f * radius + position[0], 0.0f * radius + position[1], 0.0f * radius + position[2]);
            //Правая сторона
            gl.Vertex(1.0f * radius + position[0], 0.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(1.0f * radius + position[0], -1.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(0.0f * radius + position[0], -1.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(0.0f * radius + position[0], -1.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(0.0f * radius + position[0], 0.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(1.0f * radius + position[0], 0.0f * radius + position[1], 1.0f * radius + position[2]);
            //Левая сторона
            gl.Vertex(1.0f * radius + position[0], 0 * radius + position[1], 0 * radius + position[2]);
            gl.Vertex(1.0f * radius + position[0], -1.0f * radius + position[1], 0.0f * radius + position[2]);
            gl.Vertex(1.0f * radius + position[0], -1.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(1.0f * radius + position[0], -1.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(1.0f * radius + position[0], 0.0f * radius + position[1], 1.0f * radius + position[2]);
            gl.Vertex(1.0f * radius + position[0], 0 * radius + position[1], 0 * radius + position[2]);
        }

    }
    public class Cluster : IDisposable
    {
        private readonly OpenGL gl;
        private readonly OpenGLControl gLControl;
        public Cluster(OpenGLControl gl_control)
        {
            gl = gl_control.OpenGL;
            gLControl = gl_control;
        }
        public void ClearBuffer()
        {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();
        }
        public void CreateCube(float radius, float[] position, float[] color)
        {
            Graph graph = new Graph(gLControl);
            graph.CreateCube(radius, position, color);
        }
        public void EndPaint()
        {
            gl.End();
            gl.LoadIdentity();
        }
        public void Rotate(float angle, float x, float y, float z)
        {
            gl.Rotate(angle, x, y, z);
        }
        public void Translate(float x, float y, float z)
        {
            gl.Translate(x,y,z);
        }
        public void Dispose()
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
