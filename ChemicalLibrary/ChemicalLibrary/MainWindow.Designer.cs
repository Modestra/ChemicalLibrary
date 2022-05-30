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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InputFileLabel);
            this.Controls.Add(this.DebugButtom);
            this.Controls.Add(this.InputFormulas);
            this.Controls.Add(this.TextInputFormulas);
            this.Controls.Add(this.PhysicalButtom);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PhysicalButtom;
        private System.Windows.Forms.TextBox TextInputFormulas;
        private System.Windows.Forms.Label InputFormulas;
        private System.Windows.Forms.Button DebugButtom;
        private System.Windows.Forms.Label InputFileLabel;
    }
}
