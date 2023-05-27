namespace ChemicalMenu
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.boundtitle = new System.Windows.Forms.Label();
            this.MoleculaScene = new SharpGL.SceneControl();
            this.ButtonInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MoleculaScene)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Молекула (env_test)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(243, 35);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 148);
            this.listBox1.TabIndex = 10;
            // 
            // boundtitle
            // 
            this.boundtitle.AutoSize = true;
            this.boundtitle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boundtitle.Location = new System.Drawing.Point(243, 9);
            this.boundtitle.Name = "boundtitle";
            this.boundtitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boundtitle.Size = new System.Drawing.Size(112, 20);
            this.boundtitle.TabIndex = 14;
            this.boundtitle.Text = "Типы связей";
            // 
            // MoleculaScene
            // 
            this.MoleculaScene.DrawFPS = false;
            this.MoleculaScene.Location = new System.Drawing.Point(429, 35);
            this.MoleculaScene.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MoleculaScene.Name = "MoleculaScene";
            this.MoleculaScene.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.MoleculaScene.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.MoleculaScene.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.MoleculaScene.Size = new System.Drawing.Size(487, 402);
            this.MoleculaScene.TabIndex = 16;
            this.MoleculaScene.OpenGLDraw += new SharpGL.RenderEventHandler(this.MoleculaScene_OpenGLDraw);
            // 
            // ButtonInfo
            // 
            this.ButtonInfo.Location = new System.Drawing.Point(12, 378);
            this.ButtonInfo.Name = "ButtonInfo";
            this.ButtonInfo.Size = new System.Drawing.Size(60, 60);
            this.ButtonInfo.TabIndex = 17;
            this.ButtonInfo.UseVisualStyleBackColor = true;
            this.ButtonInfo.Click += new System.EventHandler(this.ButtonInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(929, 450);
            this.Controls.Add(this.ButtonInfo);
            this.Controls.Add(this.MoleculaScene);
            this.Controls.Add(this.boundtitle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MoleculaScene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label boundtitle;
        private SharpGL.SceneControl MoleculaScene;
        private System.Windows.Forms.Button ButtonInfo;
    }
}

