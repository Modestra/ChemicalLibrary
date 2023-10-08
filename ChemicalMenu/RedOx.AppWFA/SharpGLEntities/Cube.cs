using System;
using System.Windows.Forms;
using SharpGL;

namespace RedOx.AppWFA.SharpGLEntities;

public class Cube
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
        public OpenGLControl Gl_controll;
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
}