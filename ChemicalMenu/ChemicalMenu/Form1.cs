using System;
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
            Molecula mol = new Molecula(textBox1.Text);
            mol.SaveInJson(mol);
            Dictionary<string, int> ints = mol.TypeOfBound();
            foreach (var key in ints)
            {
                switch (key.Value)
                {
                    case 0:
                        listBox1.Items.Add($"{key.Key}: Ковалентная связь");
                        break;
                    case 1:
                        listBox1.Items.Add($"{key.Key}: Ионная связь");
                        break;
                }
            }
        }
    }
}
