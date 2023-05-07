namespace HomeWork
{
    partial class HelloForm
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
            this.Hi_btn = new System.Windows.Forms.Button();
            this.Hello_btn = new System.Windows.Forms.Button();
            this.EnglishName_txt = new System.Windows.Forms.TextBox();
            this.Gender_txt = new System.Windows.Forms.TextBox();
            this.Zeber_txt = new System.Windows.Forms.TextBox();
            this.chineseName_txt = new System.Windows.Forms.TextBox();
            this.Zeber_lab = new System.Windows.Forms.Label();
            this.Gender_lab = new System.Windows.Forms.Label();
            this.EnglishName_lab = new System.Windows.Forms.Label();
            this.Chinese_Name_lab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hi_btn
            // 
            this.Hi_btn.Location = new System.Drawing.Point(217, 188);
            this.Hi_btn.Name = "Hi_btn";
            this.Hi_btn.Size = new System.Drawing.Size(75, 23);
            this.Hi_btn.TabIndex = 19;
            this.Hi_btn.Text = "Say Hi";
            this.Hi_btn.UseVisualStyleBackColor = true;
            this.Hi_btn.Click += new System.EventHandler(this.Hi_btn_Click);
            // 
            // Hello_btn
            // 
            this.Hello_btn.Location = new System.Drawing.Point(57, 189);
            this.Hello_btn.Name = "Hello_btn";
            this.Hello_btn.Size = new System.Drawing.Size(75, 23);
            this.Hello_btn.TabIndex = 18;
            this.Hello_btn.Text = "Say Hello";
            this.Hello_btn.UseVisualStyleBackColor = true;
            this.Hello_btn.Click += new System.EventHandler(this.Hello_btn_Click);
            // 
            // EnglishName_txt
            // 
            this.EnglishName_txt.Location = new System.Drawing.Point(149, 59);
            this.EnglishName_txt.Name = "EnglishName_txt";
            this.EnglishName_txt.Size = new System.Drawing.Size(100, 22);
            this.EnglishName_txt.TabIndex = 17;
            // 
            // Gender_txt
            // 
            this.Gender_txt.Location = new System.Drawing.Point(149, 92);
            this.Gender_txt.Name = "Gender_txt";
            this.Gender_txt.Size = new System.Drawing.Size(100, 22);
            this.Gender_txt.TabIndex = 16;
            // 
            // Zeber_txt
            // 
            this.Zeber_txt.Location = new System.Drawing.Point(149, 123);
            this.Zeber_txt.Name = "Zeber_txt";
            this.Zeber_txt.Size = new System.Drawing.Size(100, 22);
            this.Zeber_txt.TabIndex = 15;
            // 
            // chineseName_txt
            // 
            this.chineseName_txt.Location = new System.Drawing.Point(149, 31);
            this.chineseName_txt.Name = "chineseName_txt";
            this.chineseName_txt.Size = new System.Drawing.Size(100, 22);
            this.chineseName_txt.TabIndex = 14;
            // 
            // Zeber_lab
            // 
            this.Zeber_lab.AutoSize = true;
            this.Zeber_lab.Location = new System.Drawing.Point(57, 126);
            this.Zeber_lab.Name = "Zeber_lab";
            this.Zeber_lab.Size = new System.Drawing.Size(29, 12);
            this.Zeber_lab.TabIndex = 13;
            this.Zeber_lab.Text = "星座";
            // 
            // Gender_lab
            // 
            this.Gender_lab.AutoSize = true;
            this.Gender_lab.Location = new System.Drawing.Point(55, 95);
            this.Gender_lab.Name = "Gender_lab";
            this.Gender_lab.Size = new System.Drawing.Size(29, 12);
            this.Gender_lab.TabIndex = 12;
            this.Gender_lab.Text = "性別";
            // 
            // EnglishName_lab
            // 
            this.EnglishName_lab.AutoSize = true;
            this.EnglishName_lab.Location = new System.Drawing.Point(55, 63);
            this.EnglishName_lab.Name = "EnglishName_lab";
            this.EnglishName_lab.Size = new System.Drawing.Size(70, 12);
            this.EnglishName_lab.TabIndex = 11;
            this.EnglishName_lab.Text = "English Name";
            // 
            // Chinese_Name_lab
            // 
            this.Chinese_Name_lab.AutoSize = true;
            this.Chinese_Name_lab.Location = new System.Drawing.Point(53, 31);
            this.Chinese_Name_lab.Name = "Chinese_Name_lab";
            this.Chinese_Name_lab.Size = new System.Drawing.Size(29, 12);
            this.Chinese_Name_lab.TabIndex = 10;
            this.Chinese_Name_lab.Text = "姓名";
            // 
            // HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 232);
            this.Controls.Add(this.Hi_btn);
            this.Controls.Add(this.Hello_btn);
            this.Controls.Add(this.EnglishName_txt);
            this.Controls.Add(this.Gender_txt);
            this.Controls.Add(this.Zeber_txt);
            this.Controls.Add(this.chineseName_txt);
            this.Controls.Add(this.Zeber_lab);
            this.Controls.Add(this.Gender_lab);
            this.Controls.Add(this.EnglishName_lab);
            this.Controls.Add(this.Chinese_Name_lab);
            this.Name = "HelloForm";
            this.Text = "HelloForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hi_btn;
        private System.Windows.Forms.Button Hello_btn;
        private System.Windows.Forms.TextBox EnglishName_txt;
        private System.Windows.Forms.TextBox Gender_txt;
        private System.Windows.Forms.TextBox Zeber_txt;
        private System.Windows.Forms.TextBox chineseName_txt;
        private System.Windows.Forms.Label Zeber_lab;
        private System.Windows.Forms.Label Gender_lab;
        private System.Windows.Forms.Label EnglishName_lab;
        private System.Windows.Forms.Label Chinese_Name_lab;
    }
}