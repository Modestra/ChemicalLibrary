namespace ChemicalMenu
{
    partial class Form2
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
            this.appname = new System.Windows.Forms.Label();
            this.appversion = new System.Windows.Forms.Label();
            this.apppath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // appname
            // 
            this.appname.AutoSize = true;
            this.appname.Location = new System.Drawing.Point(12, 9);
            this.appname.Name = "appname";
            this.appname.Size = new System.Drawing.Size(79, 16);
            this.appname.TabIndex = 0;
            this.appname.Text = "Название: ";
            // 
            // appversion
            // 
            this.appversion.AutoSize = true;
            this.appversion.Location = new System.Drawing.Point(12, 36);
            this.appversion.Name = "appversion";
            this.appversion.Size = new System.Drawing.Size(60, 16);
            this.appversion.TabIndex = 2;
            this.appversion.Text = "Версия: ";
            this.appversion.Click += new System.EventHandler(this.appversion_Click);
            // 
            // apppath
            // 
            this.apppath.AutoSize = true;
            this.apppath.Location = new System.Drawing.Point(12, 65);
            this.apppath.Name = "apppath";
            this.apppath.Size = new System.Drawing.Size(45, 16);
            this.apppath.TabIndex = 3;
            this.apppath.Text = "Путь: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Путь к алгоритмам: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 289);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apppath);
            this.Controls.Add(this.appversion);
            this.Controls.Add(this.appname);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.Form2_Layout);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appname;
        private System.Windows.Forms.Label appversion;
        private System.Windows.Forms.Label apppath;
        private System.Windows.Forms.Label label1;
    }
}