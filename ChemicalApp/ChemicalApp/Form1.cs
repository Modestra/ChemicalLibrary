using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChemicalFormulas;
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
            try
            {
                int input = Convert.ToInt32(text.Text);
                ControllerFormulas controllForm = new ControllerFormulas();
                controllForm.NumberRule(input);
                if (input < 7 && input > 0) //Временная условность до создания блока исключений NumberException, нарушение DRY
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
                else if(input > 7 && input < 14)
                {
                    OxidIndex baseSub = new BaseSub();
                    baseSub.IndexHydrogen();
                    OxidIndexSub.Text = "Вещество основание";
                }
            }
            catch (NumberException ne)
            {
                FileReader reader = new FileReader();
                reader.AddTextInFile(ne.Message);
            }
        }
    }
}
