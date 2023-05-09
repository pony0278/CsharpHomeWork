namespace HomeWork
{
    partial class StudentScore2
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
            this.Name_lab = new System.Windows.Forms.Label();
            this.chinese_lab = new System.Windows.Forms.Label();
            this.english_lab = new System.Windows.Forms.Label();
            this.math_lab = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.chinese_txt = new System.Windows.Forms.TextBox();
            this.english_txt = new System.Windows.Forms.TextBox();
            this.math_txt = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.cal_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.remove_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.range1_txt = new System.Windows.Forms.TextBox();
            this.range2_txt = new System.Windows.Forms.TextBox();
            this.sreach_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_lab
            // 
            this.Name_lab.AutoSize = true;
            this.Name_lab.Location = new System.Drawing.Point(38, 17);
            this.Name_lab.Name = "Name_lab";
            this.Name_lab.Size = new System.Drawing.Size(41, 12);
            this.Name_lab.TabIndex = 0;
            this.Name_lab.Text = "姓名：";
            // 
            // chinese_lab
            // 
            this.chinese_lab.AutoSize = true;
            this.chinese_lab.Location = new System.Drawing.Point(38, 61);
            this.chinese_lab.Name = "chinese_lab";
            this.chinese_lab.Size = new System.Drawing.Size(41, 12);
            this.chinese_lab.TabIndex = 1;
            this.chinese_lab.Text = "國文：";
            // 
            // english_lab
            // 
            this.english_lab.AutoSize = true;
            this.english_lab.Location = new System.Drawing.Point(38, 106);
            this.english_lab.Name = "english_lab";
            this.english_lab.Size = new System.Drawing.Size(41, 12);
            this.english_lab.TabIndex = 2;
            this.english_lab.Text = "英文：";
            // 
            // math_lab
            // 
            this.math_lab.AutoSize = true;
            this.math_lab.Location = new System.Drawing.Point(38, 151);
            this.math_lab.Name = "math_lab";
            this.math_lab.Size = new System.Drawing.Size(41, 12);
            this.math_lab.TabIndex = 3;
            this.math_lab.Text = "數學：";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(77, 14);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(100, 22);
            this.name_txt.TabIndex = 4;
            // 
            // chinese_txt
            // 
            this.chinese_txt.Location = new System.Drawing.Point(77, 58);
            this.chinese_txt.Name = "chinese_txt";
            this.chinese_txt.Size = new System.Drawing.Size(100, 22);
            this.chinese_txt.TabIndex = 5;
            // 
            // english_txt
            // 
            this.english_txt.Location = new System.Drawing.Point(77, 103);
            this.english_txt.Name = "english_txt";
            this.english_txt.Size = new System.Drawing.Size(100, 22);
            this.english_txt.TabIndex = 6;
            // 
            // math_txt
            // 
            this.math_txt.Location = new System.Drawing.Point(77, 148);
            this.math_txt.Name = "math_txt";
            this.math_txt.Size = new System.Drawing.Size(100, 22);
            this.math_txt.TabIndex = 7;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(199, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(405, 301);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(199, 319);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(405, 93);
            this.listView2.TabIndex = 9;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // cal_btn
            // 
            this.cal_btn.Enabled = false;
            this.cal_btn.Location = new System.Drawing.Point(529, 418);
            this.cal_btn.Name = "cal_btn";
            this.cal_btn.Size = new System.Drawing.Size(75, 23);
            this.cal_btn.TabIndex = 10;
            this.cal_btn.Text = "各科統計";
            this.cal_btn.UseVisualStyleBackColor = true;
            this.cal_btn.Click += new System.EventHandler(this.cal_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(40, 190);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(137, 30);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "加入學生資料";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(40, 226);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(137, 30);
            this.insert_btn.TabIndex = 12;
            this.insert_btn.Text = "插入學生資料";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(40, 262);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(137, 30);
            this.remove_btn.TabIndex = 13;
            this.remove_btn.Text = "移除資料";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(40, 298);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clear_btn.Size = new System.Drawing.Size(137, 30);
            this.clear_btn.TabIndex = 14;
            this.clear_btn.Text = "清除所有資料";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 15;
            this.label5.Text = "搜尋國文成績範圍";
            // 
            // range1_txt
            // 
            this.range1_txt.Location = new System.Drawing.Point(40, 369);
            this.range1_txt.Name = "range1_txt";
            this.range1_txt.Size = new System.Drawing.Size(51, 22);
            this.range1_txt.TabIndex = 16;
            // 
            // range2_txt
            // 
            this.range2_txt.Location = new System.Drawing.Point(126, 369);
            this.range2_txt.Name = "range2_txt";
            this.range2_txt.Size = new System.Drawing.Size(51, 22);
            this.range2_txt.TabIndex = 17;
            // 
            // sreach_btn
            // 
            this.sreach_btn.Location = new System.Drawing.Point(40, 408);
            this.sreach_btn.Name = "sreach_btn";
            this.sreach_btn.Size = new System.Drawing.Size(137, 30);
            this.sreach_btn.TabIndex = 18;
            this.sreach_btn.Text = "搜尋";
            this.sreach_btn.UseVisualStyleBackColor = true;
            this.sreach_btn.Click += new System.EventHandler(this.sreach_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "—";
            // 
            // StudentScore2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(614, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sreach_btn);
            this.Controls.Add(this.range2_txt);
            this.Controls.Add(this.range1_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.cal_btn);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.math_txt);
            this.Controls.Add(this.english_txt);
            this.Controls.Add(this.chinese_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.math_lab);
            this.Controls.Add(this.english_lab);
            this.Controls.Add(this.chinese_lab);
            this.Controls.Add(this.Name_lab);
            this.Name = "StudentScore2";
            this.Text = "StudentScore2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_lab;
        private System.Windows.Forms.Label chinese_lab;
        private System.Windows.Forms.Label english_lab;
        private System.Windows.Forms.Label math_lab;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox chinese_txt;
        private System.Windows.Forms.TextBox english_txt;
        private System.Windows.Forms.TextBox math_txt;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button cal_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox range1_txt;
        private System.Windows.Forms.TextBox range2_txt;
        private System.Windows.Forms.Button sreach_btn;
        private System.Windows.Forms.Label label1;
    }
}