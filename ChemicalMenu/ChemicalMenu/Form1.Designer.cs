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
            this.button_Save = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.boundtitle = new System.Windows.Forms.Label();
            this.MoleculaScene = new SharpGL.SceneControl();
            this.Button_Info = new System.Windows.Forms.Button();
            this.button_Right = new System.Windows.Forms.Button();
            this.button_Left = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
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
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 128);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 84);
            this.listBox1.TabIndex = 10;
            // 
            // boundtitle
            // 
            this.boundtitle.AutoSize = true;
            this.boundtitle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boundtitle.Location = new System.Drawing.Point(8, 106);
            this.boundtitle.Name = "boundtitle";
            this.boundtitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boundtitle.Size = new System.Drawing.Size(112, 20);
            this.boundtitle.TabIndex = 14;
            this.boundtitle.Text = "Типы связей";
            // 
            // MoleculaScene
            // 
            this.MoleculaScene.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoleculaScene.DrawFPS = false;
            this.MoleculaScene.Location = new System.Drawing.Point(244, 9);
            this.MoleculaScene.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MoleculaScene.Name = "MoleculaScene";
            this.MoleculaScene.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.MoleculaScene.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.MoleculaScene.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.MoleculaScene.Size = new System.Drawing.Size(417, 429);
            this.MoleculaScene.TabIndex = 16;
            this.MoleculaScene.OpenGLDraw += new SharpGL.RenderEventHandler(this.Molecula_Scene_OpenGLDraw);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Left);
            this.Controls.Add(this.button_Right);
            this.Controls.Add(this.Button_Info);
            this.Controls.Add(this.MoleculaScene);
            this.Controls.Add(this.boundtitle);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_Save);
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
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label boundtitle;
        private SharpGL.SceneControl MoleculaScene;
        private System.Windows.Forms.Button Button_Info;
        private System.Windows.Forms.Button button_Right;
        private System.Windows.Forms.Button button_Left;
        private System.Windows.Forms.Button button_Load;
    }
}

