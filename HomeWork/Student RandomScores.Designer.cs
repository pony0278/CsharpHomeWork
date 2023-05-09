namespace HomeWork
{
    partial class Student_RandomScores
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
            this.name_lab = new System.Windows.Forms.Label();
            this.chinese_lab = new System.Windows.Forms.Label();
            this.english_lab = new System.Windows.Forms.Label();
            this.math_lab = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.chinese_txt = new System.Windows.Forms.TextBox();
            this.english_txt = new System.Windows.Forms.TextBox();
            this.math_txt = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.random_btn = new System.Windows.Forms.Button();
            this.cal_btn = new System.Windows.Forms.Button();
            this.re_btn = new System.Windows.Forms.Button();
            this.random20_btn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // name_lab
            // 
            this.name_lab.AutoSize = true;
            this.name_lab.Location = new System.Drawing.Point(28, 13);
            this.name_lab.Name = "name_lab";
            this.name_lab.Size = new System.Drawing.Size(41, 12);
            this.name_lab.TabIndex = 0;
            this.name_lab.Text = "姓名：";
            // 
            // chinese_lab
            // 
            this.chinese_lab.AutoSize = true;
            this.chinese_lab.Location = new System.Drawing.Point(28, 48);
            this.chinese_lab.Name = "chinese_lab";
            this.chinese_lab.Size = new System.Drawing.Size(41, 12);
            this.chinese_lab.TabIndex = 1;
            this.chinese_lab.Text = "國文：";
            // 
            // english_lab
            // 
            this.english_lab.AutoSize = true;
            this.english_lab.Location = new System.Drawing.Point(28, 91);
            this.english_lab.Name = "english_lab";
            this.english_lab.Size = new System.Drawing.Size(41, 12);
            this.english_lab.TabIndex = 2;
            this.english_lab.Text = "英文：";
            // 
            // math_lab
            // 
            this.math_lab.AutoSize = true;
            this.math_lab.Location = new System.Drawing.Point(28, 129);
            this.math_lab.Name = "math_lab";
            this.math_lab.Size = new System.Drawing.Size(41, 12);
            this.math_lab.TabIndex = 3;
            this.math_lab.Text = "數學：";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(75, 10);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 22);
            this.name_txt.TabIndex = 4;
            // 
            // chinese_txt
            // 
            this.chinese_txt.Location = new System.Drawing.Point(75, 45);
            this.chinese_txt.Name = "chinese_txt";
            this.chinese_txt.Size = new System.Drawing.Size(100, 22);
            this.chinese_txt.TabIndex = 5;
            // 
            // english_txt
            // 
            this.english_txt.Location = new System.Drawing.Point(75, 88);
            this.english_txt.Name = "english_txt";
            this.english_txt.Size = new System.Drawing.Size(100, 22);
            this.english_txt.TabIndex = 6;
            // 
            // math_txt
            // 
            this.math_txt.Location = new System.Drawing.Point(75, 126);
            this.math_txt.Name = "math_txt";
            this.math_txt.Size = new System.Drawing.Size(100, 22);
            this.math_txt.TabIndex = 7;
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(62, 164);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(113, 23);
            this.add_btn.TabIndex = 8;
            this.add_btn.Text = "加入學生資料";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // random_btn
            // 
            this.random_btn.Location = new System.Drawing.Point(62, 194);
            this.random_btn.Name = "random_btn";
            this.random_btn.Size = new System.Drawing.Size(113, 23);
            this.random_btn.TabIndex = 9;
            this.random_btn.Text = "隨機儲存資料";
            this.random_btn.UseVisualStyleBackColor = true;
            this.random_btn.Click += new System.EventHandler(this.random_btn_Click);
            // 
            // cal_btn
            // 
            this.cal_btn.Enabled = false;
            this.cal_btn.Location = new System.Drawing.Point(62, 224);
            this.cal_btn.Name = "cal_btn";
            this.cal_btn.Size = new System.Drawing.Size(113, 23);
            this.cal_btn.TabIndex = 10;
            this.cal_btn.Text = "各科統計";
            this.cal_btn.UseVisualStyleBackColor = true;
            this.cal_btn.Click += new System.EventHandler(this.cal_btn_Click);
            // 
            // re_btn
            // 
            this.re_btn.Location = new System.Drawing.Point(62, 281);
            this.re_btn.Name = "re_btn";
            this.re_btn.Size = new System.Drawing.Size(113, 23);
            this.re_btn.TabIndex = 11;
            this.re_btn.Text = "重設所有資料";
            this.re_btn.UseVisualStyleBackColor = true;
            this.re_btn.Click += new System.EventHandler(this.re_btn_Click);
            // 
            // random20_btn
            // 
            this.random20_btn.Location = new System.Drawing.Point(62, 311);
            this.random20_btn.Name = "random20_btn";
            this.random20_btn.Size = new System.Drawing.Size(113, 23);
            this.random20_btn.TabIndex = 12;
            this.random20_btn.Text = "隨機加入20筆資料";
            this.random20_btn.UseVisualStyleBackColor = true;
            this.random20_btn.Click += new System.EventHandler(this.random20_btn_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(208, 10);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(404, 229);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(208, 245);
            this.listView2.Name = "listView2";
            this.listView2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listView2.Size = new System.Drawing.Size(404, 89);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // Student_RandomScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 349);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.random20_btn);
            this.Controls.Add(this.re_btn);
            this.Controls.Add(this.cal_btn);
            this.Controls.Add(this.random_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.math_txt);
            this.Controls.Add(this.english_txt);
            this.Controls.Add(this.chinese_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.math_lab);
            this.Controls.Add(this.english_lab);
            this.Controls.Add(this.chinese_lab);
            this.Controls.Add(this.name_lab);
            this.Name = "Student_RandomScores";
            this.Text = "Student_RandomScores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_lab;
        private System.Windows.Forms.Label chinese_lab;
        private System.Windows.Forms.Label english_lab;
        private System.Windows.Forms.Label math_lab;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox chinese_txt;
        private System.Windows.Forms.TextBox english_txt;
        private System.Windows.Forms.TextBox math_txt;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button random_btn;
        private System.Windows.Forms.Button cal_btn;
        private System.Windows.Forms.Button re_btn;
        private System.Windows.Forms.Button random20_btn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
    }


}