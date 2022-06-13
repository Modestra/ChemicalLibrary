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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Atomic_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChemElementTable)).BeginInit();
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
            this.ChemElementTable.Location = new System.Drawing.Point(12, 110);
            this.ChemElementTable.Name = "ChemElementTable";
            this.ChemElementTable.RowHeadersWidth = 51;
            this.ChemElementTable.RowTemplate.Height = 29;
            this.ChemElementTable.Size = new System.Drawing.Size(639, 328);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(397, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 27);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(283, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(108, 27);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(209, 75);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(68, 27);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Atomic_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.InputCommandButton);
            this.Controls.Add(this.DataBaseOn);
            this.Controls.Add(this.ChemElementTable);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Atomic_Name;
    }
}
