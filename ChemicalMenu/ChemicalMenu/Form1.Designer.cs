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
            this.Molecula_Title = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Bound_Title = new System.Windows.Forms.Label();
            this.Button_Info = new System.Windows.Forms.Button();
            this.button_Right = new System.Windows.Forms.Button();
            this.button_Left = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            this.openGLControl1 = new SharpGL.OpenGLControl();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
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
            // Molecula_Title
            // 
            this.Molecula_Title.AutoSize = true;
            this.Molecula_Title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Molecula_Title.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Molecula_Title.Location = new System.Drawing.Point(12, 9);
            this.Molecula_Title.Name = "Molecula_Title";
            this.Molecula_Title.Size = new System.Drawing.Size(193, 23);
            this.Molecula_Title.TabIndex = 1;
            this.Molecula_Title.Text = "Молекула (env_test)";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(12, 63);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(108, 40);
            this.button_Save.TabIndex = 9;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 84);
            this.listBox1.TabIndex = 10;
            // 
            // Bound_Title
            // 
            this.Bound_Title.AutoSize = true;
            this.Bound_Title.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bound_Title.Location = new System.Drawing.Point(8, 106);
            this.Bound_Title.Name = "Bound_Title";
            this.Bound_Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bound_Title.Size = new System.Drawing.Size(112, 20);
            this.Bound_Title.TabIndex = 14;
            this.Bound_Title.Text = "Типы связей";
            // 
            // Button_Info
            // 
            this.Button_Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_Info.FlatAppearance.BorderSize = 2;
            this.Button_Info.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_Info.Image = global::ChemicalMenu.Properties.Resources.settings;
            this.Button_Info.Location = new System.Drawing.Point(12, 378);
            this.Button_Info.Name = "Button_Info";
            this.Button_Info.Size = new System.Drawing.Size(60, 60);
            this.Button_Info.TabIndex = 17;
            this.Button_Info.UseVisualStyleBackColor = true;
            this.Button_Info.Click += new System.EventHandler(this.Button_Info_Click);
            // 
            // button_Right
            // 
            this.button_Right.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Right.Location = new System.Drawing.Point(177, 378);
            this.button_Right.Name = "button_Right";
            this.button_Right.Size = new System.Drawing.Size(60, 60);
            this.button_Right.TabIndex = 18;
            this.button_Right.Text = "Право";
            this.button_Right.UseVisualStyleBackColor = true;
            this.button_Right.Click += new System.EventHandler(this.button_Right_Click);
            // 
            // button_Left
            // 
            this.button_Left.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Left.Location = new System.Drawing.Point(111, 378);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(60, 60);
            this.button_Left.TabIndex = 19;
            this.button_Left.Text = "Лево";
            this.button_Left.UseVisualStyleBackColor = true;
            this.button_Left.Click += new System.EventHandler(this.button_Left_Click);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(126, 63);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(111, 40);
            this.button_Load.TabIndex = 20;
            this.button_Load.Text = "Загрузить";
            this.button_Load.UseVisualStyleBackColor = true;
            // 
            // openGLControl1
            // 
            this.openGLControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControl1.DrawFPS = false;
            this.openGLControl1.Location = new System.Drawing.Point(244, 13);
            this.openGLControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(417, 424);
            this.openGLControl1.TabIndex = 21;
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            this.openGLControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.openGLControl1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.openGLControl1);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Left);
            this.Controls.Add(this.button_Right);
            this.Controls.Add(this.Button_Info);
            this.Controls.Add(this.Bound_Title);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.Molecula_Title);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Molecula_Title;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Bound_Title;
        private System.Windows.Forms.Button Button_Info;
        private System.Windows.Forms.Button button_Right;
        private System.Windows.Forms.Button button_Left;
        private System.Windows.Forms.Button button_Load;
        private SharpGL.OpenGLControl openGLControl1;
    }
}

