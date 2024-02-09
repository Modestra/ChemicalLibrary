using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RedOx.AppWFA.SharpGLEntities;
using RedOx.DataBase;
using SharpGL;
using SharpGL.SceneGraph.Quadrics;

namespace RedOx.AppWFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        //Экран
        private void openGLControl1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBaseConnect connect = new DataBaseConnect();
            listLogger.Items.Add(connect.errormessage);
        }
    }
}