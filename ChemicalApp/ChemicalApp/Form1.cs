using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DebugUtilites;

namespace ChemicalApp
{
    public partial class Form1 : Form
    {
        string path = @"C:\Users\Пользователь\OneDrive\Рабочий стол\ChemicalLibrary\debug.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonFile_Click(object sender, EventArgs e)
        {
            DebugFile debug = new DebugFile();
            debug.CreateDirectiory(path);
            debug.WriteDebugFile(path,"Файл создан");
        }

        private void FileLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
