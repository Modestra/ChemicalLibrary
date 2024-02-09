using System;
using System.Windows.Forms;
using SharpGL;

namespace RedOx.AppWFA.SharpGLEntities;
public class Graph {
    
    public float[] Color = new float[3];
    public float[] Position = new float[3];
    public OpenGL Gl_controll;
    public Graph(OpenGL gl)
    {
        Gl_controll = gl;
    }
    public void CreateSphere(float radius,  float[] color)
    {
        OpenGL gl = Gl_controll;
        // x^3 + y^3 + z^3 = R
        for (double x = -1; x <= 1; x += 0.1)
        {
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(color[0], color[1], color[2]);
            gl.Vertex(Math.Pow(x, 2), 0, Math.Pow(1, 2) - Math.Pow(x, 2));
        }
        gl.End();
    }
    public void CreateCube(float radius, float[] position, float[] color)
    {
        OpenGL gl = Gl_controll;
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
        gl.Vertex(1.0f + position[0], 0.0f + position[1], 0.0f + position[2]);
        gl.Vertex(1.0f + position[0], -1.0f + position[1], 0.0f + position[2]);
        gl.Vertex(0.0f + position[0], -1.0f + position[1], 0.0f + position[2]);
        gl.Vertex(0.0f + position[0], -1.0f + position[1], 0.0f + position[2]);
        gl.Vertex(0.0f + position[0], 0.0f + position[1], 0.0f + position[2]);
        gl.Vertex(1.0f + position[0], 0.0f + position[1], 0.0f + position[2]);
        //Правая сторона
        gl.Vertex(0 + position[0], 0 + position[1], 0 + position[2]);
        gl.Vertex(0.0f + position[0], -1.0f + position[1], 0.0f + position[2]);
        gl.Vertex(0.0f + position[0], -1.0f + position[1], 1.0f + position[2]);
        gl.Vertex(0.0f + position[0], -1.0f + position[1], 1.0f + position[2]);
        gl.Vertex(0.0f + position[0], 0.0f + position[1], 1.0f + position[2]);
        gl.Vertex(0 + position[0], 0 + position[1], 0 + position[2]);
        //Дно
        gl.Vertex(0.0f + position[0], -1.0f + position[1], 0.0f + position[2]);
        gl.Vertex(1.0f + position[0], -1.0f + position[1], 0.0f + position[2]);
        gl.Vertex(0.0f + position[0], -1.0f + position[1], 1.0f + position[2]);
        gl.Vertex(0.0f + position[0], -1.0f + position[1], 1.0f + position[2]);
        gl.Vertex(1.0f + position[0], -1.0f + position[1], 1.0f + position[2]);
        gl.Vertex(1.0f + position[0], -1.0f + position[1], 0.0f + position[2]);
        //Вверх
        gl.Vertex(0.0f + position[0], 0.0f + position[1], 0.0f + position[2]);
        gl.Vertex(1.0f + position[0], 0.0f + position[1], 0.0f + position[2]);
        gl.Vertex(0.0f + position[0], 0.0f + position[1], 1.0f + position[2]);
        gl.Vertex(0.0f + position[0], 0.0f + position[1], 1.0f + position[2]);
        gl.Vertex(1.0f + position[0], 0.0f + position[1], 1.0f + position[2]);
        gl.Vertex(1.0f + position[0], 0.0f + position[1], 0.0f + position[2]);
        //Правая сторона
        gl.Vertex(1.0f + position[0], 0.0f + position[1], 1.0f + position[2]);
        gl.Vertex(1.0f + position[0], -1.0f + position[1], 1.0f + position[2]);
        gl.Vertex(0.0f + position[0], -1.0f + position[1], 1.0f + position[2]);
        gl.Vertex(0.0f + position[0], -1.0f + position[1], 1.0f + position[2]);
        gl.Vertex(0.0f + position[0], 0.0f + position[1], 1.0f + position[2]);
        gl.Vertex(1.0f + position[0], 0.0f + position[1], 1.0f + position[2]);
        //Левая сторона
        gl.Vertex(1.0f + position[0], 0 + position[1], 0 + position[2]);
        gl.Vertex(1.0f + position[0], -1.0f + position[1], 0.0f + position[2]);
        gl.Vertex(1.0f + position[0], -1.0f + position[1], 1.0f + position[2]);
        gl.Vertex(1.0f + position[0], -1.0f + position[1], 1.0f + position[2]);
        gl.Vertex(1.0f + position[0], 0.0f + position[1], 1.0f + position[2]);
        gl.Vertex(1.0f + position[0], 0 + position[1], 0 + position[2]);
        gl.End();
    }

}
