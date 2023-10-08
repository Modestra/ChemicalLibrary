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
            
        }

        private void button_Right_Click(object sender, EventArgs e)
        {
            this.axis_rotate_Y = this.axis_rotate_Y + 100f;
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
            this.axis_rotate_Y = this.axis_rotate_Y - 10f;
        }

        private void button_Right_Click(object sender, EventArgs e)
        {
            this.axis_rotate_Y = this.axis_rotate_Y + 10f;
        }

        private void openGLControl1_OpenGLDraw(object sender, RenderEventArgs args)
        {
            float[] pos = { 0f, 0f, 0f };
            float[] color = { 1.0f, 0, 0 };
            using(Cluster cluster = new Cluster(openGLControl1))
            {
                cluster.ClearBuffer();
                cluster.Rotate(0f, 0, this.axis_rotate_Y, 0);
                cluster.CreateCube(0.5f, pos, color);
            float[] pos = { 1.0f, 1.0f, 0f };
            float[] pos2 = { 1.0f, -1.0f, 0f };
            float[] color = { 1.0f, 0, 0 };
            float[] color2 = { 1.0f, 1.0f, 0 };
            using(Cluster cluster = new Cluster(openGLControl1))
            {
                cluster.ClearBuffer();
                cluster.CreateCube(1.0f, pos, color);
                cluster.CreateCube(3.0f, pos2, color2);
                cluster.Rotate(1.0f, axis_rotate_X, axis_rotate_Y, axis_rotate_Z);
                cluster.EndPaint();
            }
        }

        private void openGLControl1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    this.axis_rotate_Y = this.axis_rotate_Y - 10f; break;
                case Keys.D:
                    this.axis_rotate_Y = this.axis_rotate_Y + 10f; break;
                case Keys.W:
                    this.axis_rotate_X = this.axis_rotate_X + 10f; break;
                case Keys.S:
                    this.axis_rotate_X = this.axis_rotate_X - 10f; break;
                case Keys.Q:
                    this.axis_rotate_Z = this.axis_rotate_Z - 10f; break;
                case Keys.E:
                    this.axis_rotate_Z = this.axis_rotate_Z + 10f; break;
            }

        }
    }
}
