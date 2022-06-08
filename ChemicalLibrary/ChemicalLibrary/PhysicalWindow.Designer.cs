namespace ChemicalLibrary
{
    partial class PhysicalWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FlrstElementInput = new System.Windows.Forms.Label();
            this.buttonInputFEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlrstElementInput
            // 
            this.FlrstElementInput.AutoSize = true;
            this.FlrstElementInput.Location = new System.Drawing.Point(12, 9);
            this.FlrstElementInput.Name = "FlrstElementInput";
            this.FlrstElementInput.Size = new System.Drawing.Size(129, 20);
            this.FlrstElementInput.TabIndex = 0;
            this.FlrstElementInput.Text = "Первый элемент:";
            // 
            // buttonInputFEL
            // 
            this.buttonInputFEL.Location = new System.Drawing.Point(12, 32);
            this.buttonInputFEL.Name = "buttonInputFEL";
            this.buttonInputFEL.Size = new System.Drawing.Size(94, 29);
            this.buttonInputFEL.TabIndex = 1;
            this.buttonInputFEL.Text = "Ввести";
            this.buttonInputFEL.UseVisualStyleBackColor = true;
            this.buttonInputFEL.Click += new System.EventHandler(this.buttonInputFEL_Click);
            // 
            // PhysicalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonInputFEL);
            this.Controls.Add(this.FlrstElementInput);
            this.Name = "PhysicalWindow";
            this.Text = "PhysicalWindow";
            this.Load += new System.EventHandler(this.PhysicalWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FlrstElementInput;
        private System.Windows.Forms.Button buttonInputFEL;
    }
}