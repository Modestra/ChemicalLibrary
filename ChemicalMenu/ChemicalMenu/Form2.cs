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
            appname.Text = appname.Text + Application.ProductName;
            appversion.Text = appversion.Text + Application.ProductVersion;
            apppath.Text = apppath.Text + AppDomain.CurrentDomain.BaseDirectory;
            appname.Text = appname.Text + Application.ProductName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void appversion_Click(object sender, EventArgs e)
        {

        }
    }
}
