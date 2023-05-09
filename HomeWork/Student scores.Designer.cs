namespace HomeWork
{
    partial class Student_scores
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
            this.name_txt = new System.Windows.Forms.TextBox();
            this.math_txt = new System.Windows.Forms.TextBox();
            this.chinese_txt = new System.Windows.Forms.TextBox();
            this.english_txt = new System.Windows.Forms.TextBox();
            this.Name_lab = new System.Windows.Forms.Label();
            this.chinese_lab = new System.Windows.Forms.Label();
            this.math_lab = new System.Windows.Forms.Label();
            this.english_lab = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.showSave_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MinMax_lab = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showScore_lab = new System.Windows.Forms.Label();
            this.MinMax_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(78, 38);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 22);
            this.name_txt.TabIndex = 0;
            // 
            // math_txt
            // 
            this.math_txt.Location = new System.Drawing.Point(78, 120);
            this.math_txt.Name = "math_txt";
            this.math_txt.Size = new System.Drawing.Size(100, 22);
            this.math_txt.TabIndex = 2;
            // 
            // chinese_txt
            // 
            this.chinese_txt.Location = new System.Drawing.Point(78, 78);
            this.chinese_txt.Name = "chinese_txt";
            this.chinese_txt.Size = new System.Drawing.Size(100, 22);
            this.chinese_txt.TabIndex = 3;
            // 
            // english_txt
            // 
            this.english_txt.Location = new System.Drawing.Point(78, 159);
            this.english_txt.Name = "english_txt";
            this.english_txt.Size = new System.Drawing.Size(100, 22);
            this.english_txt.TabIndex = 4;
            // 
            // Name_lab
            // 
            this.Name_lab.AutoSize = true;
            this.Name_lab.Location = new System.Drawing.Point(26, 41);
            this.Name_lab.Name = "Name_lab";
            this.Name_lab.Size = new System.Drawing.Size(41, 12);
            this.Name_lab.TabIndex = 5;
            this.Name_lab.Text = "姓名：";
            // 
            // chinese_lab
            // 
            this.chinese_lab.AutoSize = true;
            this.chinese_lab.Location = new System.Drawing.Point(26, 81);
            this.chinese_lab.Name = "chinese_lab";
            this.chinese_lab.Size = new System.Drawing.Size(41, 12);
            this.chinese_lab.TabIndex = 6;
            this.chinese_lab.Text = "國文：";
            // 
            // math_lab
            // 
            this.math_lab.AutoSize = true;
            this.math_lab.Location = new System.Drawing.Point(26, 120);
            this.math_lab.Name = "math_lab";
            this.math_lab.Size = new System.Drawing.Size(41, 12);
            this.math_lab.TabIndex = 7;
            this.math_lab.Text = "數學：";
            // 
            // english_lab
            // 
            this.english_lab.AutoSize = true;
            this.english_lab.Location = new System.Drawing.Point(26, 162);
            this.english_lab.Name = "english_lab";
            this.english_lab.Size = new System.Drawing.Size(41, 12);
            this.english_lab.TabIndex = 8;
            this.english_lab.Text = "英文：";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(28, 214);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 9;
            this.save_btn.Text = "儲存";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // showSave_btn
            // 
            this.showSave_btn.Location = new System.Drawing.Point(118, 214);
            this.showSave_btn.Name = "showSave_btn";
            this.showSave_btn.Size = new System.Drawing.Size(75, 23);
            this.showSave_btn.TabIndex = 10;
            this.showSave_btn.Text = "顯示儲存";
            this.showSave_btn.UseVisualStyleBackColor = true;
            this.showSave_btn.Click += new System.EventHandler(this.showSave_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(215, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 321);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MinMax_lab);
            this.groupBox3.Location = new System.Drawing.Point(7, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 131);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // MinMax_lab
            // 
            this.MinMax_lab.AutoSize = true;
            this.MinMax_lab.Location = new System.Drawing.Point(7, 22);
            this.MinMax_lab.Name = "MinMax_lab";
            this.MinMax_lab.Size = new System.Drawing.Size(0, 12);
            this.MinMax_lab.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showScore_lab);
            this.groupBox2.Location = new System.Drawing.Point(7, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 157);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // showScore_lab
            // 
            this.showScore_lab.AutoSize = true;
            this.showScore_lab.Location = new System.Drawing.Point(7, 22);
            this.showScore_lab.Name = "showScore_lab";
            this.showScore_lab.Size = new System.Drawing.Size(0, 12);
            this.showScore_lab.TabIndex = 0;
            // 
            // MinMax_btn
            // 
            this.MinMax_btn.Location = new System.Drawing.Point(428, 364);
            this.MinMax_btn.Name = "MinMax_btn";
            this.MinMax_btn.Size = new System.Drawing.Size(103, 33);
            this.MinMax_btn.TabIndex = 12;
            this.MinMax_btn.Text = "最高分/最低分";
            this.MinMax_btn.UseVisualStyleBackColor = true;
            this.MinMax_btn.Click += new System.EventHandler(this.MinMax_btn_Click);
            // 
            // Student_scores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 412);
            this.Controls.Add(this.MinMax_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showSave_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.english_lab);
            this.Controls.Add(this.math_lab);
            this.Controls.Add(this.chinese_lab);
            this.Controls.Add(this.Name_lab);
            this.Controls.Add(this.english_txt);
            this.Controls.Add(this.chinese_txt);
            this.Controls.Add(this.math_txt);
            this.Controls.Add(this.name_txt);
            this.Name = "Student_scores";
            this.Text = "Student_scores";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox math_txt;
        private System.Windows.Forms.TextBox chinese_txt;
        private System.Windows.Forms.TextBox english_txt;
        private System.Windows.Forms.Label Name_lab;
        private System.Windows.Forms.Label chinese_lab;
        private System.Windows.Forms.Label math_lab;
        private System.Windows.Forms.Label english_lab;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button showSave_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label showScore_lab;
        private System.Windows.Forms.Button MinMax_btn;
        private System.Windows.Forms.Label MinMax_lab;
    }
}