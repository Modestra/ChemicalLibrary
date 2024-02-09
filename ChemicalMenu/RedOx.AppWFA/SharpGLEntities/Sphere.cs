using System;
using SharpGL;

namespace RedOx.AppWFA.SharpGLEntities;

public class Sphere
{
    private OpenGLControl Gl_controll;
    public Sphere(OpenGLControl gl)
    {
        Gl_controll = gl;
    }
    public void CreateSphere(float radius,  float[] color)
    {
        OpenGL gl = Gl_controll.OpenGL;
        // x^3 + y^3 + z^3 = R
        for (double x = -1; x <= 1; x += 0.1)
        {
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(color[0], color[1], color[2]);
            gl.Vertex(Math.Pow(x, 2), 0, Math.Pow(1, 2) - Math.Pow(x, 2));
        }
    }
}