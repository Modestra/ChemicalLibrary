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

namespace ChemicalLibrary
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void TextInputFormulas_TextChanged(object sender, EventArgs e)
        {
            string[] text = TextInputFormulas.Text.Split(new char[]{'+'},StringSplitOptions.RemoveEmptyEntries);
            InputFormulas.Text = "Число реагентов: "+ Convert.ToInt16(text.Length);
            ControllerFormulas contrForm = new ControllerFormulas();
            contrForm.ReagentsList(text);
        }

        private void DebugButtom_Click(object sender, EventArgs e)
        {

        }

        private void PhysicalButtom_Click(object sender, EventArgs e)
        {
            PhysicalWindow pb = new PhysicalWindow();
            pb.Show();
        }
    }
}
