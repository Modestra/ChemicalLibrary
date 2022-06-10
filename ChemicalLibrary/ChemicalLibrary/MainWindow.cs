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
        private SqlConnection chemDB = null;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            chemDB = new SqlConnection(ConfigurationManager.ConnectionStrings["ChemData"].ConnectionString);
            chemDB.Open();
            if (chemDB.State == ConnectionState.Open)
            {
                MessageBox.Show("Подключение совершено");
            }
        }

        private void TextInputFormulas_TextChanged(object sender, EventArgs e)
        {
            string[] text = TextInputFormulas.Text.Split(new char[]{'+'},StringSplitOptions.RemoveEmptyEntries);
            InputFormulas.Text = "Число реагентов: "+ Convert.ToInt16(text.Length);
            ControllerFormulas contrForm = new ControllerFormulas();
            contrForm.ReagentsList(text);
            if (TextInputFormulas.Text != null)
            {
                try
                {
                    label1.Text = "Первый элемент: " + text[0];
                }
                catch
                {
                    label1.Text = "Элементов нет";
                }
            }
        }
        private void DebugButtom_Click(object sender, EventArgs e)
        {
            if (TextInputFormulas.Text != null)
            {
            }
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
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM ChemElementList", chemDB);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            ChemElementTable.DataSource = ds.Tables[0];
        }
    }
}
 