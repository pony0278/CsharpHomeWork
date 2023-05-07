namespace HomeWork
{
    partial class Loan
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
            this.budget_lab = new System.Windows.Forms.Label();
            this.due_lab = new System.Windows.Forms.Label();
            this.rate_lab = new System.Windows.Forms.Label();
            this.first_lab = new System.Windows.Forms.Label();
            this.budget_txt = new System.Windows.Forms.TextBox();
            this.due_txt = new System.Windows.Forms.TextBox();
            this.rate_txt = new System.Windows.Forms.TextBox();
            this.first_txt = new System.Windows.Forms.TextBox();
            this.Month_btn = new System.Windows.Forms.Button();
            this.allPay_btn = new System.Windows.Forms.Button();
            this.report_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // budget_lab
            // 
            this.budget_lab.AutoSize = true;
            this.budget_lab.Location = new System.Drawing.Point(58, 39);
            this.budget_lab.Name = "budget_lab";
            this.budget_lab.Size = new System.Drawing.Size(53, 12);
            this.budget_lab.TabIndex = 0;
            this.budget_lab.Text = "貸款金額";
            // 
            // due_lab
            // 
            this.due_lab.AutoSize = true;
            this.due_lab.Location = new System.Drawing.Point(58, 63);
            this.due_lab.Name = "due_lab";
            this.due_lab.Size = new System.Drawing.Size(49, 12);
            this.due_lab.TabIndex = 1;
            this.due_lab.Text = "期限(年)";
            // 
            // rate_lab
            // 
            this.rate_lab.AutoSize = true;
            this.rate_lab.Location = new System.Drawing.Point(58, 88);
            this.rate_lab.Name = "rate_lab";
            this.rate_lab.Size = new System.Drawing.Size(46, 12);
            this.rate_lab.TabIndex = 2;
            this.rate_lab.Text = "利率(%)";
            // 
            // first_lab
            // 
            this.first_lab.AutoSize = true;
            this.first_lab.Location = new System.Drawing.Point(58, 115);
            this.first_lab.Name = "first_lab";
            this.first_lab.Size = new System.Drawing.Size(41, 12);
            this.first_lab.TabIndex = 3;
            this.first_lab.Text = "頭期款";
            // 
            // budget_txt
            // 
            this.budget_txt.Location = new System.Drawing.Point(135, 29);
            this.budget_txt.Name = "budget_txt";
            this.budget_txt.Size = new System.Drawing.Size(100, 22);
            this.budget_txt.TabIndex = 4;
            // 
            // due_txt
            // 
            this.due_txt.Location = new System.Drawing.Point(135, 58);
            this.due_txt.Name = "due_txt";
            this.due_txt.Size = new System.Drawing.Size(100, 22);
            this.due_txt.TabIndex = 5;
            // 
            // rate_txt
            // 
            this.rate_txt.Location = new System.Drawing.Point(135, 86);
            this.rate_txt.Name = "rate_txt";
            this.rate_txt.Size = new System.Drawing.Size(100, 22);
            this.rate_txt.TabIndex = 6;
            // 
            // first_txt
            // 
            this.first_txt.Location = new System.Drawing.Point(135, 114);
            this.first_txt.Name = "first_txt";
            this.first_txt.Size = new System.Drawing.Size(100, 22);
            this.first_txt.TabIndex = 7;
            // 
            // Month_btn
            // 
            this.Month_btn.Location = new System.Drawing.Point(12, 153);
            this.Month_btn.Name = "Month_btn";
            this.Month_btn.Size = new System.Drawing.Size(75, 23);
            this.Month_btn.TabIndex = 8;
            this.Month_btn.Text = "月付";
            this.Month_btn.UseVisualStyleBackColor = true;
            this.Month_btn.Click += new System.EventHandler(this.Month_btn_Click);
            // 
            // allPay_btn
            // 
            this.allPay_btn.Location = new System.Drawing.Point(107, 153);
            this.allPay_btn.Name = "allPay_btn";
            this.allPay_btn.Size = new System.Drawing.Size(75, 23);
            this.allPay_btn.TabIndex = 9;
            this.allPay_btn.Text = "總付款";
            this.allPay_btn.UseVisualStyleBackColor = true;
            this.allPay_btn.Click += new System.EventHandler(this.allPay_btn_Click);
            // 
            // report_btn
            // 
            this.report_btn.Location = new System.Drawing.Point(199, 153);
            this.report_btn.Name = "report_btn";
            this.report_btn.Size = new System.Drawing.Size(75, 23);
            this.report_btn.TabIndex = 10;
            this.report_btn.Text = "report";
            this.report_btn.UseVisualStyleBackColor = true;
            this.report_btn.Click += new System.EventHandler(this.report_btn_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 197);
            this.Controls.Add(this.report_btn);
            this.Controls.Add(this.allPay_btn);
            this.Controls.Add(this.Month_btn);
            this.Controls.Add(this.first_txt);
            this.Controls.Add(this.rate_txt);
            this.Controls.Add(this.due_txt);
            this.Controls.Add(this.budget_txt);
            this.Controls.Add(this.first_lab);
            this.Controls.Add(this.rate_lab);
            this.Controls.Add(this.due_lab);
            this.Controls.Add(this.budget_lab);
            this.Name = "Loan";
            this.Text = "Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label budget_lab;
        private System.Windows.Forms.Label due_lab;
        private System.Windows.Forms.Label rate_lab;
        private System.Windows.Forms.Label first_lab;
        private System.Windows.Forms.TextBox budget_txt;
        private System.Windows.Forms.TextBox due_txt;
        private System.Windows.Forms.TextBox rate_txt;
        private System.Windows.Forms.TextBox first_txt;
        private System.Windows.Forms.Button Month_btn;
        private System.Windows.Forms.Button allPay_btn;
        private System.Windows.Forms.Button report_btn;
    }
}