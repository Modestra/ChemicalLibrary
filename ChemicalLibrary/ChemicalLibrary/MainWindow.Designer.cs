namespace ChemicalLibrary
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PhysicalButtom = new System.Windows.Forms.Button();
            this.TextInputFormulas = new System.Windows.Forms.TextBox();
            this.InputFormulas = new System.Windows.Forms.Label();
            this.DebugButtom = new System.Windows.Forms.Button();
            this.InputFileLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChemElementTable = new System.Windows.Forms.DataGridView();
            this.DataBaseOn = new System.Windows.Forms.Button();
            this.InputCommandButton = new System.Windows.Forms.Button();
            this.atmText = new System.Windows.Forms.TextBox();
            this.nameElementText = new System.Windows.Forms.TextBox();
            this.elementText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Atomic_Name = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.NonOrganicGrid = new System.Windows.Forms.DataGridView();
            this.NonOrganicButton = new System.Windows.Forms.Button();
            this.TrackDataTables = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChemElementTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NonOrganicGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackDataTables)).BeginInit();
            this.SuspendLayout();
            // 
            // PhysicalButtom
            // 
            this.PhysicalButtom.BackColor = System.Drawing.Color.Turquoise;
            this.PhysicalButtom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.PhysicalButtom.Location = new System.Drawing.Point(657, 376);
            this.PhysicalButtom.Name = "PhysicalButtom";
            this.PhysicalButtom.Size = new System.Drawing.Size(131, 62);
            this.PhysicalButtom.TabIndex = 0;
            this.PhysicalButtom.Text = "Физ. свойства";
            this.PhysicalButtom.UseVisualStyleBackColor = false;
            this.PhysicalButtom.Click += new System.EventHandler(this.PhysicalButtom_Click);
            // 
            // TextInputFormulas
            // 
            this.TextInputFormulas.BackColor = System.Drawing.Color.CadetBlue;
            this.TextInputFormulas.Location = new System.Drawing.Point(12, 12);
            this.TextInputFormulas.Name = "TextInputFormulas";
            this.TextInputFormulas.Size = new System.Drawing.Size(187, 27);
            this.TextInputFormulas.TabIndex = 1;
            this.TextInputFormulas.TextChanged += new System.EventHandler(this.TextInputFormulas_TextChanged);
            // 
            // InputFormulas
            // 
            this.InputFormulas.AutoSize = true;
            this.InputFormulas.BackColor = System.Drawing.Color.DarkTurquoise;
            this.InputFormulas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InputFormulas.Location = new System.Drawing.Point(12, 42);
            this.InputFormulas.Name = "InputFormulas";
            this.InputFormulas.Size = new System.Drawing.Size(130, 20);
            this.InputFormulas.TabIndex = 2;
            this.InputFormulas.Text = "Число реагентов:";
            // 
            // DebugButtom
            // 
            this.DebugButtom.BackColor = System.Drawing.Color.Turquoise;
            this.DebugButtom.Location = new System.Drawing.Point(715, 32);
            this.DebugButtom.Name = "DebugButtom";
            this.DebugButtom.Size = new System.Drawing.Size(73, 52);
            this.DebugButtom.TabIndex = 3;
            this.DebugButtom.Text = "Запись";
            this.DebugButtom.UseVisualStyleBackColor = false;
            this.DebugButtom.Click += new System.EventHandler(this.DebugButtom_Click);
            // 
            // InputFileLabel
            // 
            this.InputFileLabel.AutoSize = true;
            this.InputFileLabel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.InputFileLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputFileLabel.Location = new System.Drawing.Point(583, 9);
            this.InputFileLabel.Name = "InputFileLabel";
            this.InputFileLabel.Size = new System.Drawing.Size(205, 20);
            this.InputFileLabel.TabIndex = 4;
            this.InputFileLabel.Text = "Файловая система работает";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChemElementTable
            // 
            this.ChemElementTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChemElementTable.Location = new System.Drawing.Point(3, 37);
            this.ChemElementTable.Name = "ChemElementTable";
            this.ChemElementTable.RowHeadersWidth = 51;
            this.ChemElementTable.RowTemplate.Height = 29;
            this.ChemElementTable.Size = new System.Drawing.Size(613, 251);
            this.ChemElementTable.TabIndex = 6;
            this.ChemElementTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChemElementTable_CellContentClick);
            // 
            // DataBaseOn
            // 
            this.DataBaseOn.BackColor = System.Drawing.Color.Turquoise;
            this.DataBaseOn.Location = new System.Drawing.Point(3, 3);
            this.DataBaseOn.Name = "DataBaseOn";
            this.DataBaseOn.Size = new System.Drawing.Size(94, 28);
            this.DataBaseOn.TabIndex = 7;
            this.DataBaseOn.Text = "Запуск";
            this.DataBaseOn.UseVisualStyleBackColor = false;
            this.DataBaseOn.Click += new System.EventHandler(this.DataBaseOn_Click);
            // 
            // InputCommandButton
            // 
            this.InputCommandButton.BackColor = System.Drawing.Color.Turquoise;
            this.InputCommandButton.Location = new System.Drawing.Point(304, 503);
            this.InputCommandButton.Name = "InputCommandButton";
            this.InputCommandButton.Size = new System.Drawing.Size(94, 29);
            this.InputCommandButton.TabIndex = 8;
            this.InputCommandButton.Text = "Ввести";
            this.InputCommandButton.UseVisualStyleBackColor = false;
            this.InputCommandButton.Click += new System.EventHandler(this.InputCommandButton_Click);
            // 
            // atmText
            // 
            this.atmText.BackColor = System.Drawing.Color.CadetBlue;
            this.atmText.Location = new System.Drawing.Point(213, 464);
            this.atmText.Name = "atmText";
            this.atmText.Size = new System.Drawing.Size(85, 27);
            this.atmText.TabIndex = 9;
            this.atmText.TextChanged += new System.EventHandler(this.atmText_TextChanged);
            // 
            // nameElementText
            // 
            this.nameElementText.BackColor = System.Drawing.Color.CadetBlue;
            this.nameElementText.Location = new System.Drawing.Point(99, 464);
            this.nameElementText.Name = "nameElementText";
            this.nameElementText.Size = new System.Drawing.Size(108, 27);
            this.nameElementText.TabIndex = 10;
            this.nameElementText.TextChanged += new System.EventHandler(this.nameElementText_TextChanged);
            // 
            // elementText
            // 
            this.elementText.BackColor = System.Drawing.Color.CadetBlue;
            this.elementText.Location = new System.Drawing.Point(16, 464);
            this.elementText.Name = "elementText";
            this.elementText.Size = new System.Drawing.Size(77, 27);
            this.elementText.TabIndex = 11;
            this.elementText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(17, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Вещество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(99, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Назв. вещ-ва";
            // 
            // Atomic_Name
            // 
            this.Atomic_Name.AutoSize = true;
            this.Atomic_Name.BackColor = System.Drawing.Color.DarkTurquoise;
            this.Atomic_Name.Location = new System.Drawing.Point(213, 441);
            this.Atomic_Name.Name = "Atomic_Name";
            this.Atomic_Name.Size = new System.Drawing.Size(85, 20);
            this.Atomic_Name.TabIndex = 14;
            this.Atomic_Name.Text = "моль. масс";
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.Turquoise;
            this.SelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.SelectButton.Location = new System.Drawing.Point(205, 10);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(94, 29);
            this.SelectButton.TabIndex = 15;
            this.SelectButton.Text = "Выбрать";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 328);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(631, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Хим. Элементы";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ChemElementTable, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.DataBaseOn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 291);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SteelBlue;
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Неорг. Вещества";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.73822F));
            this.tableLayoutPanel2.Controls.Add(this.NonOrganicGrid, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.NonOrganicButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(-4, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.70903F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.29097F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(639, 299);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // NonOrganicGrid
            // 
            this.NonOrganicGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NonOrganicGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NonOrganicGrid.Location = new System.Drawing.Point(3, 41);
            this.NonOrganicGrid.Name = "NonOrganicGrid";
            this.NonOrganicGrid.RowHeadersWidth = 51;
            this.NonOrganicGrid.RowTemplate.Height = 29;
            this.NonOrganicGrid.Size = new System.Drawing.Size(633, 255);
            this.NonOrganicGrid.TabIndex = 0;
            this.NonOrganicGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NonOrganicGrid_CellContentClick);
            // 
            // NonOrganicButton
            // 
            this.NonOrganicButton.BackColor = System.Drawing.Color.Turquoise;
            this.NonOrganicButton.Location = new System.Drawing.Point(3, 3);
            this.NonOrganicButton.Name = "NonOrganicButton";
            this.NonOrganicButton.Size = new System.Drawing.Size(116, 32);
            this.NonOrganicButton.TabIndex = 18;
            this.NonOrganicButton.Text = "Запуск";
            this.NonOrganicButton.UseVisualStyleBackColor = false;
            this.NonOrganicButton.Click += new System.EventHandler(this.NonOrganicButton_Click);
            // 
            // TrackDataTables
            // 
            this.TrackDataTables.Location = new System.Drawing.Point(12, 497);
            this.TrackDataTables.Maximum = 2;
            this.TrackDataTables.Name = "TrackDataTables";
            this.TrackDataTables.Size = new System.Drawing.Size(286, 56);
            this.TrackDataTables.TabIndex = 18;
            this.TrackDataTables.Value = 1;
            this.TrackDataTables.Scroll += new System.EventHandler(this.TrackDataTables_Scroll);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox1.Location = new System.Drawing.Point(304, 464);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 27);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox2.Location = new System.Drawing.Point(421, 464);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(113, 27);
            this.textBox2.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox3.Location = new System.Drawing.Point(540, 464);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(111, 27);
            this.textBox3.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Location = new System.Drawing.Point(304, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label5.Location = new System.Drawing.Point(421, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label6.Location = new System.Drawing.Point(540, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "label6";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.CadetBlue;
            this.textBox4.Location = new System.Drawing.Point(657, 464);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 27);
            this.textBox4.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label7.Location = new System.Drawing.Point(657, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "label7";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(794, 544);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TrackDataTables);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.elementText);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.Atomic_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameElementText);
            this.Controls.Add(this.atmText);
            this.Controls.Add(this.InputCommandButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputFileLabel);
            this.Controls.Add(this.DebugButtom);
            this.Controls.Add(this.InputFormulas);
            this.Controls.Add(this.TextInputFormulas);
            this.Controls.Add(this.PhysicalButtom);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChemElementTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NonOrganicGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackDataTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PhysicalButtom;
        private System.Windows.Forms.TextBox TextInputFormulas;
        private System.Windows.Forms.Label InputFormulas;
        private System.Windows.Forms.Button DebugButtom;
        private System.Windows.Forms.Label InputFileLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ChemElementTable;
        private System.Windows.Forms.Button DataBaseOn;
        private System.Windows.Forms.Button InputCommandButton;
        private System.Windows.Forms.TextBox atmText;
        private System.Windows.Forms.TextBox nameElementText;
        private System.Windows.Forms.TextBox elementText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Atomic_Name;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView NonOrganicGrid;
        private System.Windows.Forms.Button NonOrganicButton;
        private System.Windows.Forms.TrackBar TrackDataTables;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
    }
}
