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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ChemElementTable)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhysicalButtom
            // 
            this.PhysicalButtom.Location = new System.Drawing.Point(657, 376);
            this.PhysicalButtom.Name = "PhysicalButtom";
            this.PhysicalButtom.Size = new System.Drawing.Size(131, 62);
            this.PhysicalButtom.TabIndex = 0;
            this.PhysicalButtom.Text = "Физ. свойства";
            this.PhysicalButtom.UseVisualStyleBackColor = true;
            this.PhysicalButtom.Click += new System.EventHandler(this.PhysicalButtom_Click);
            // 
            // TextInputFormulas
            // 
            this.TextInputFormulas.Location = new System.Drawing.Point(12, 12);
            this.TextInputFormulas.Name = "TextInputFormulas";
            this.TextInputFormulas.Size = new System.Drawing.Size(187, 27);
            this.TextInputFormulas.TabIndex = 1;
            this.TextInputFormulas.TextChanged += new System.EventHandler(this.TextInputFormulas_TextChanged);
            // 
            // InputFormulas
            // 
            this.InputFormulas.AutoSize = true;
            this.InputFormulas.Location = new System.Drawing.Point(12, 42);
            this.InputFormulas.Name = "InputFormulas";
            this.InputFormulas.Size = new System.Drawing.Size(130, 20);
            this.InputFormulas.TabIndex = 2;
            this.InputFormulas.Text = "Число реагентов:";
            // 
            // DebugButtom
            // 
            this.DebugButtom.Location = new System.Drawing.Point(676, 10);
            this.DebugButtom.Name = "DebugButtom";
            this.DebugButtom.Size = new System.Drawing.Size(112, 52);
            this.DebugButtom.TabIndex = 3;
            this.DebugButtom.Text = "Запись";
            this.DebugButtom.UseVisualStyleBackColor = true;
            this.DebugButtom.Click += new System.EventHandler(this.DebugButtom_Click);
            // 
            // InputFileLabel
            // 
            this.InputFileLabel.AutoSize = true;
            this.InputFileLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InputFileLabel.Location = new System.Drawing.Point(676, 65);
            this.InputFileLabel.Name = "InputFileLabel";
            this.InputFileLabel.Size = new System.Drawing.Size(50, 20);
            this.InputFileLabel.TabIndex = 4;
            this.InputFileLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
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
            this.ChemElementTable.Location = new System.Drawing.Point(3, 20);
            this.ChemElementTable.Name = "ChemElementTable";
            this.ChemElementTable.RowHeadersWidth = 51;
            this.ChemElementTable.RowTemplate.Height = 29;
            this.ChemElementTable.Size = new System.Drawing.Size(613, 268);
            this.ChemElementTable.TabIndex = 6;
            this.ChemElementTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChemElementTable_CellContentClick);
            // 
            // DataBaseOn
            // 
            this.DataBaseOn.Location = new System.Drawing.Point(557, 75);
            this.DataBaseOn.Name = "DataBaseOn";
            this.DataBaseOn.Size = new System.Drawing.Size(94, 29);
            this.DataBaseOn.TabIndex = 7;
            this.DataBaseOn.Text = "Запуск";
            this.DataBaseOn.UseVisualStyleBackColor = true;
            this.DataBaseOn.Click += new System.EventHandler(this.DataBaseOn_Click);
            // 
            // InputCommandButton
            // 
            this.InputCommandButton.Location = new System.Drawing.Point(457, 75);
            this.InputCommandButton.Name = "InputCommandButton";
            this.InputCommandButton.Size = new System.Drawing.Size(94, 29);
            this.InputCommandButton.TabIndex = 8;
            this.InputCommandButton.Text = "Ввести";
            this.InputCommandButton.UseVisualStyleBackColor = true;
            this.InputCommandButton.Click += new System.EventHandler(this.InputCommandButton_Click);
            // 
            // atmText
            // 
            this.atmText.Location = new System.Drawing.Point(397, 75);
            this.atmText.Name = "atmText";
            this.atmText.Size = new System.Drawing.Size(42, 27);
            this.atmText.TabIndex = 9;
            this.atmText.TextChanged += new System.EventHandler(this.atmText_TextChanged);
            // 
            // nameElementText
            // 
            this.nameElementText.Location = new System.Drawing.Point(283, 75);
            this.nameElementText.Name = "nameElementText";
            this.nameElementText.Size = new System.Drawing.Size(108, 27);
            this.nameElementText.TabIndex = 10;
            this.nameElementText.TextChanged += new System.EventHandler(this.nameElementText_TextChanged);
            // 
            // elementText
            // 
            this.elementText.Location = new System.Drawing.Point(209, 75);
            this.elementText.Name = "elementText";
            this.elementText.Size = new System.Drawing.Size(68, 27);
            this.elementText.TabIndex = 11;
            this.elementText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Элемент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Имя элемента";
            // 
            // Atomic_Name
            // 
            this.Atomic_Name.AutoSize = true;
            this.Atomic_Name.Location = new System.Drawing.Point(397, 52);
            this.Atomic_Name.Name = "Atomic_Name";
            this.Atomic_Name.Size = new System.Drawing.Size(42, 20);
            this.Atomic_Name.TabIndex = 14;
            this.Atomic_Name.Text = "А.т.м";
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(205, 10);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(94, 29);
            this.SelectButton.TabIndex = 15;
            this.SelectButton.Text = "Выбрать";
            this.SelectButton.UseVisualStyleBackColor = true;
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
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(631, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ChemElementTable, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 274F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 291);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.Atomic_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.elementText);
            this.Controls.Add(this.nameElementText);
            this.Controls.Add(this.atmText);
            this.Controls.Add(this.InputCommandButton);
            this.Controls.Add(this.DataBaseOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputFileLabel);
            this.Controls.Add(this.DebugButtom);
            this.Controls.Add(this.InputFormulas);
            this.Controls.Add(this.TextInputFormulas);
            this.Controls.Add(this.PhysicalButtom);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChemElementTable)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
    }
}
