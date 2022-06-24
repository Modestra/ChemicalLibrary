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
using System.Configuration;
using System.Data.SqlClient;
using DataBaseLibrary;

namespace ChemicalLibrary
{
    public partial class MainWindow : Form
    {
        public SqlConnection chemDB = null;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            chemDB = new SqlConnection(ConfigurationManager.ConnectionStrings["ChemData"].ConnectionString);
            chemDB.Open();
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
        private void label1_Click(object sender, EventArgs e)
        {         
        }
        private void ChemElementTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void DataBaseOn_Click(object sender, EventArgs e)
        {
            SelectAllTable(0);
        }

        private void InputCommandButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseInputElements dataBaseInput = new DataBaseInputElements();
                dataBaseInput.InputElement(elementText.Text, nameElementText.Text, Convert.ToDecimal(atmText.Text), chemDB);
            }
            finally
            {
                SelectAllTable(0);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameElementText_TextChanged(object sender, EventArgs e)
        {

        }

        private void atmText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            SqlDataAdapter data = new SqlDataAdapter($"SELECT Atomic_Number,Element FROM ChemElementList", chemDB);
            DataSet set = new DataSet();
            data.Fill(set);
            ChemElementTable.DataSource = set.Tables[0];
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        public void SelectAllTable(int numbertable)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM ChemElementList", chemDB);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            ChemElementTable.DataSource = ds.Tables[numbertable];
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 