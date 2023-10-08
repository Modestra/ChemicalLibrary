using System;
using System.Windows.Forms;
using SharpGL;

namespace RedOx.AppWFA.SharpGLEntities;

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
        Cube.Graph graph = new Cube.Graph(gLControl);
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