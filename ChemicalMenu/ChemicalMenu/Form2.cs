using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChemicalMenu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string line;
            StreamReader reader = new StreamReader(@"C:\Users\Пользователь\OneDrive\Рабочий стол\Проектный менеджмент\Отладка\env_test\env_test.log");
            //Заполнитель для отладки (Переделать)
            while ((line = reader.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
            }
            reader.Close();
        }

        private void Form2_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
