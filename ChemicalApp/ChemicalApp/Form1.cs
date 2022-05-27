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
using ChemicalFormulas;

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
            FileReader reader = new FileReader();
            reader.AddTextInFile("Text");
            debug.CreateDirectiory(path);            
            FileLabel.Text = "Файл создан";
        }
        private void FileLabel_Click(object sender, EventArgs e)
        {           
        }
        private void text_TextChanged(object sender, EventArgs e)
        {
        }
        private void OxidIndexSub_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(text.Text);
            if (input < 7)
            {
                OxidIndex oxSub = new OxidSub();
                oxSub.IndexHydrogen();
                OxidIndexSub.Text = "Вещество кислота";
            }
            else if (input == 7)
            {
                OxidIndex neitral = new NeitralSub();
                neitral.IndexHydrogen();
                OxidIndexSub.Text = "Вещество нейтральное";
            }
            else
            {
                OxidIndex baseSub = new BaseSub();
                baseSub.IndexHydrogen();
                OxidIndexSub.Text = "Вещество основание";
            }
        }
    }
}
