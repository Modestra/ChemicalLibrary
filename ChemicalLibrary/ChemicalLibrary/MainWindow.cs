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
        FileWriter writer = new FileWriter();
        public SqlConnection chemDB = null;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            chemDB = new SqlConnection(ConfigurationManager.ConnectionStrings["ChemData"].ConnectionString);
            chemDB.Open(); //Открытие ChemDataBase
            
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
        private void DataBaseOn_Click(object sender, EventArgs e) //Запуск 1 таблицы
        {
            SelectAllTable("ChemElementList", ChemElementTable);
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
                SelectAllTable("ChemElementList", ChemElementTable);
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
        public void SelectAllTable(string tablename, DataGridView table)
        { //Запуск таблицы
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter($"SELECT * FROM {tablename}", chemDB);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                table.DataSource = ds.Tables[0];
            }
            catch
            {
                writer.AddTextInFile("Произошла ошибка при загрузке таблиц: Таблицы не существует или слишком большое значение");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void TrackDataTables_Scroll(object sender, EventArgs e)
        {
            /*if (TrackDataTables.Value == 0)
            {
                label2.Text = "";
                label3.Text = "";
                Atomic_Name.Text = "";
                label4.Text = "";
                label5.Text = "";
                label6.Text = "";
            }
            */
            switch (TrackDataTables.Value) 
            {
                case 0:
                    label2.Text = "Элемент"; label3.Text = "Назв. вещ-ва"; Atomic_Name.Text = "А.т.м"; label4.Text = "";
                    label5.Text = ""; label6.Text = ""; label7.Text = "";
                    break;
                case 1:
                    label2.Text = ""; label3.Text = ""; Atomic_Name.Text = ""; label4.Text = "";
                    label5.Text = ""; label6.Text = ""; label7.Text = "";
                    break;
                case 2:
                    label2.Text = ""; label3.Text = "";  Atomic_Name.Text = ""; label4.Text = "";
                    label5.Text = ""; label6.Text = ""; label7.Text = "";
                    break;
            }

        }

        private void NonOrganicButton_Click(object sender, EventArgs e)
        {
            SelectAllTable("NonOrganicTable", NonOrganicGrid);
        }

        private void NonOrganicGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
 