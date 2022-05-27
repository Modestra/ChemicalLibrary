namespace ChemicalApp
{
    partial class Form1
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
            this.ButtonFile = new System.Windows.Forms.Button();
            this.FileLabel = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.OxidIndexSub = new System.Windows.Forms.Label();
            this.OxidIndexButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonFile
            // 
            this.ButtonFile.Location = new System.Drawing.Point(649, 12);
            this.ButtonFile.Name = "ButtonFile";
            this.ButtonFile.Size = new System.Drawing.Size(139, 43);
            this.ButtonFile.TabIndex = 0;
            this.ButtonFile.Text = "Запись файла";
            this.ButtonFile.UseVisualStyleBackColor = true;
            this.ButtonFile.Click += new System.EventHandler(this.ButtonFile_Click);
            // 
            // FileLabel
            // 
            this.FileLabel.AutoSize = true;
            this.FileLabel.Location = new System.Drawing.Point(664, 58);
            this.FileLabel.Name = "FileLabel";
            this.FileLabel.Size = new System.Drawing.Size(50, 20);
            this.FileLabel.TabIndex = 1;
            this.FileLabel.Text = "label1";
            this.FileLabel.Click += new System.EventHandler(this.FileLabel_Click);
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(518, 20);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(125, 27);
            this.text.TabIndex = 2;
            this.text.TextChanged += new System.EventHandler(this.text_TextChanged);
            // 
            // OxidIndexSub
            // 
            this.OxidIndexSub.AutoSize = true;
            this.OxidIndexSub.Location = new System.Drawing.Point(518, 58);
            this.OxidIndexSub.Name = "OxidIndexSub";
            this.OxidIndexSub.Size = new System.Drawing.Size(104, 20);
            this.OxidIndexSub.TabIndex = 3;
            this.OxidIndexSub.Text = "Тип вещества";
            this.OxidIndexSub.Click += new System.EventHandler(this.OxidIndexSub_Click);
            // 
            // OxidIndexButton
            // 
            this.OxidIndexButton.Location = new System.Drawing.Point(418, 18);
            this.OxidIndexButton.Name = "OxidIndexButton";
            this.OxidIndexButton.Size = new System.Drawing.Size(94, 29);
            this.OxidIndexButton.TabIndex = 4;
            this.OxidIndexButton.Text = "Проверить";
            this.OxidIndexButton.UseVisualStyleBackColor = true;
            this.OxidIndexButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OxidIndexButton);
            this.Controls.Add(this.OxidIndexSub);
            this.Controls.Add(this.text);
            this.Controls.Add(this.FileLabel);
            this.Controls.Add(this.ButtonFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonFile;
        private System.Windows.Forms.Label FileLabel;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Label OxidIndexSub;
        private System.Windows.Forms.Button OxidIndexButton;
    }
}
