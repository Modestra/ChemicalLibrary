using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Threading;
using EnviromentCore;
using SharpGL;
using System.Runtime.InteropServices;

namespace ChemicalMenu
{
    public partial class Form1 : Form
    {
        private float axis_rotate_X;
        private float axis_rotate_Y;
        private float axis_rotate_Z;
        public Form1()
        {
            InitializeComponent();
            this.axis_rotate_X = 0;

            this.axis_rotate_Y = 0;

            this.axis_rotate_Z = 0;
        }

        private void ChemTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            var dir = new FolderBrowserDialog();
            dir.ShowDialog();
            //Запуск потока 1
            using (Enviroment environment = new Enviroment(@"\env_test", dir.SelectedPath))
            {
                //Создание молекулы
                environment.AddComponents(textBox1.Text);
            }
        }

        private void apppath_Click(object sender, EventArgs e)
        {

        }

        private void appdatabase_Click(object sender, EventArgs e)
        {

        }

        private void Button_Info_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button_Left_Click(object sender, EventArgs e)
        {
            this.axis_rotate_Z = this.axis_rotate_Z + 5f;
        }

        private void button_Right_Click(object sender, EventArgs e)
        {
            this.axis_rotate_Y = this.axis_rotate_Y + 5f;
        }

        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            SharpGL.OpenGL gl = this.openGLControl1.OpenGL;

            gl.Clear(SharpGL.OpenGL.GL_COLOR_BUFFER_BIT | SharpGL.OpenGL.GL_DEPTH_BUFFER_BIT);  // Очистка скрина

            gl.LoadIdentity();    // сброс

            gl.Translate(0.0f, 0.0f, -6.0f);  // переместить влево

            gl.Rotate(axis_rotate_X, 1.0f, 0.0f, 0.0f);

            gl.Rotate(axis_rotate_Y, 0.0f, 1.0f, 0.0f);

            gl.Rotate(axis_rotate_Z, 0.0f, 0.0f, 1.0f);

            gl.Begin(SharpGL.OpenGL.GL_TRIANGLES); // начать рисовать пирамиду

            gl.Color(1.0f, 0.0f, 0.0f);   //красный

            gl.Vertex(0.0f, 1.0f, 0.0f); // центр пирамиды

            gl.Color(0.0f, 1.0f, 0.0f); //Зеленый

            gl.Vertex(-1.0f, -1.0f, 1.0f);  // левая сторона пирамиды

            gl.Color(0.0f, 0.0f, 1.0f);  // Синий

            gl.Vertex(1.0f, -1.0f, 1.0f);  // права сторона пирамиды

            gl.Color(1.0f, 0.0f, 0.0f);   //красный

            gl.Vertex(0.0f, 1.0f, 0.0f); // центр пирамиды

            gl.Color(0.0f, 0.0f, 1.0f); //Зеленый

            gl.Vertex(1.0f, -1.0f, 1.0f);  // левая сторона пирамиды

            gl.Color(0.0f, 1.0f, 0.0f);  // Синий

            gl.Vertex(1.0f, -1.0f, -1.0f);  // права сторона пирамиды

            gl.Color(1.0f, 0.0f, 0.0f);   //красный

            gl.Vertex(0.0f, 1.0f, 0.0f); // центр пирамиды

            gl.Color(0.0f, 1.0f, 0.0f); //Зеленый

            gl.Vertex(1.0f, -1.0f, -1.0f);  // левая сторона пирамиды

            gl.Color(0.0f, 0.0f, 1.0f);  // Синий

            gl.Vertex(-1.0f, -1.0f, -1.0f);  // права сторона пирамиды

            gl.Color(1.0f, 0.0f, 0.0f);   //красный

            gl.Vertex(0.0f, 1.0f, 0.0f); // центр пирамиды

            gl.Color(0.0f, 0.0f, 1.0f); //Зеленый

            gl.Vertex(-1.0f, -1.0f, -1.0f);  // левая сторона пирамиды

            gl.Color(0.0f, 1.0f, 0.0f);  // Синий

            gl.Vertex(-1.0f, -1.0f, 1.0f);  // права сторона пирамиды

            gl.End();

            gl.LoadIdentity();
        }

        private void openGLControl1_Paint(object sender, PaintEventArgs e)
        {
            OpenGL gl = openGLControl1.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();
            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 1.0f, 0.0f);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(1.0f, 0.0f, 0.0f);
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(0.0f, 0.0f, 1.0f);
            gl.End();
        }
    }
}
