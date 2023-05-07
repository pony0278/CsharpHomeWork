namespace HomeWork
{
    partial class MyClac
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num1_txt = new System.Windows.Forms.TextBox();
            this.num2_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ans_txt = new System.Windows.Forms.TextBox();
            this.plus_btn = new System.Windows.Forms.Button();
            this.reduce_btn = new System.Windows.Forms.Button();
            this.cross_btn = new System.Windows.Forms.Button();
            this.division_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number 2";
            // 
            // num1_txt
            // 
            this.num1_txt.Location = new System.Drawing.Point(103, 26);
            this.num1_txt.Name = "num1_txt";
            this.num1_txt.Size = new System.Drawing.Size(100, 22);
            this.num1_txt.TabIndex = 2;
            // 
            // num2_txt
            // 
            this.num2_txt.Location = new System.Drawing.Point(103, 57);
            this.num2_txt.Name = "num2_txt";
            this.num2_txt.Size = new System.Drawing.Size(100, 22);
            this.num2_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "= = = = = = = = = = = = = = = = = = = = = = = = = = = = = =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ans ：";
            // 
            // ans_txt
            // 
            this.ans_txt.Location = new System.Drawing.Point(103, 114);
            this.ans_txt.Name = "ans_txt";
            this.ans_txt.Size = new System.Drawing.Size(100, 22);
            this.ans_txt.TabIndex = 6;
            // 
            // plus_btn
            // 
            this.plus_btn.Location = new System.Drawing.Point(301, 17);
            this.plus_btn.Name = "plus_btn";
            this.plus_btn.Size = new System.Drawing.Size(75, 23);
            this.plus_btn.TabIndex = 7;
            this.plus_btn.Text = "+";
            this.plus_btn.UseVisualStyleBackColor = true;
            this.plus_btn.Click += new System.EventHandler(this.plus_btn_Click);
            // 
            // reduce_btn
            // 
            this.reduce_btn.Location = new System.Drawing.Point(301, 49);
            this.reduce_btn.Name = "reduce_btn";
            this.reduce_btn.Size = new System.Drawing.Size(75, 23);
            this.reduce_btn.TabIndex = 8;
            this.reduce_btn.Text = "-";
            this.reduce_btn.UseVisualStyleBackColor = true;
            this.reduce_btn.Click += new System.EventHandler(this.reduce_btn_Click);
            // 
            // cross_btn
            // 
            this.cross_btn.Location = new System.Drawing.Point(301, 81);
            this.cross_btn.Name = "cross_btn";
            this.cross_btn.Size = new System.Drawing.Size(75, 23);
            this.cross_btn.TabIndex = 9;
            this.cross_btn.Text = "*";
            this.cross_btn.UseVisualStyleBackColor = true;
            this.cross_btn.Click += new System.EventHandler(this.cross_btn_Click);
            // 
            // division_btn
            // 
            this.division_btn.Location = new System.Drawing.Point(301, 114);
            this.division_btn.Name = "division_btn";
            this.division_btn.Size = new System.Drawing.Size(75, 23);
            this.division_btn.TabIndex = 10;
            this.division_btn.Text = "/";
            this.division_btn.UseVisualStyleBackColor = true;
            this.division_btn.Click += new System.EventHandler(this.division_btn_Click);
            // 
            // MyClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 150);
            this.Controls.Add(this.division_btn);
            this.Controls.Add(this.cross_btn);
            this.Controls.Add(this.reduce_btn);
            this.Controls.Add(this.plus_btn);
            this.Controls.Add(this.ans_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num2_txt);
            this.Controls.Add(this.num1_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MyClac";
            this.Text = "MyClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num1_txt;
        private System.Windows.Forms.TextBox num2_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ans_txt;
        private System.Windows.Forms.Button plus_btn;
        private System.Windows.Forms.Button reduce_btn;
        private System.Windows.Forms.Button cross_btn;
        private System.Windows.Forms.Button division_btn;
    }
}