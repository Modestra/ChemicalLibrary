﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChemicalFormula;



namespace ChemicalMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Molecula mol = new Molecula("LiHe");
            mol.mole = 27;
            Solution sol = new Solution(2400, mol);
        }

        private void ChemTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}