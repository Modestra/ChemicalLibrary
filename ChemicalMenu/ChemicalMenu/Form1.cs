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
using Newtonsoft.Json;
using System.IO;

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
            Quantum quantum = new Quantum(mol);
            using (FileStream fs = new FileStream(@"C:\Users\Пользователь\OneDrive\Рабочий стол\user.json", FileMode.OpenOrCreate))
            {
                fs.Close();
                string json = JsonConvert.SerializeObject(mol, Formatting.Indented);
                File.AppendAllText(@"C:\Users\Пользователь\OneDrive\Рабочий стол\user.json", json);
            }
            Dictionary<string, int> ints = mol.TypeOfBound();
            foreach (var key in ints)
            {
                switch (key.Value)
                {
                    case -1:
                        listBox1.Items.Add($"{key.Key}: Ионная связь"); 
                        break;
                    case 0:
                        listBox1.Items.Add($"{key.Key}: Металлическая связь");
                        break;
                    case 1:
                        listBox1.Items.Add($"{key.Key}: Ковалентная связь");
                        break;
                }
            }
        }
    }
}
