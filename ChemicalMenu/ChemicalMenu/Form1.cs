﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnviromentCore;
using ChemicalFormula;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace ChemicalMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        private void button1_Click(object sender, EventArgs e)
        {
            Enviroment env = new Enviroment(textBox1.Text, $@"C:\Users\Пользователь\OneDrive\Рабочий стол\Проектный менеджмент\test\");
        }
    }
}
