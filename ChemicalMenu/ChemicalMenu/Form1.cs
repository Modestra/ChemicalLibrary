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

namespace ChemicalMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//

        private void ChemTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
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

        private void MoleculaScene_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {

        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}
