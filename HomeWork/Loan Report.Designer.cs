namespace HomeWork
{
    partial class Loan_Report
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
            this.budget_report_lab = new System.Windows.Forms.Label();
            this.due_report_lab = new System.Windows.Forms.Label();
            this.rate_report_lab = new System.Windows.Forms.Label();
            this.month_report_lab = new System.Windows.Forms.Label();
            this.allpay_report_lab = new System.Windows.Forms.Label();
            this.txtbox_one = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // budget_report_lab
            // 
            this.budget_report_lab.AutoSize = true;
            this.budget_report_lab.Location = new System.Drawing.Point(57, 38);
            this.budget_report_lab.Name = "budget_report_lab";
            this.budget_report_lab.Size = new System.Drawing.Size(53, 12);
            this.budget_report_lab.TabIndex = 0;
            this.budget_report_lab.Text = "貸款金額";
            // 
            // due_report_lab
            // 
            this.due_report_lab.AutoSize = true;
            this.due_report_lab.Location = new System.Drawing.Point(59, 68);
            this.due_report_lab.Name = "due_report_lab";
            this.due_report_lab.Size = new System.Drawing.Size(49, 12);
            this.due_report_lab.TabIndex = 1;
            this.due_report_lab.Text = "期限(年)";
            // 
            // rate_report_lab
            // 
            this.rate_report_lab.AutoSize = true;
            this.rate_report_lab.Location = new System.Drawing.Point(59, 99);
            this.rate_report_lab.Name = "rate_report_lab";
            this.rate_report_lab.Size = new System.Drawing.Size(46, 12);
            this.rate_report_lab.TabIndex = 2;
            this.rate_report_lab.Text = "利率(%)";
            // 
            // month_report_lab
            // 
            this.month_report_lab.AutoSize = true;
            this.month_report_lab.Location = new System.Drawing.Point(59, 131);
            this.month_report_lab.Name = "month_report_lab";
            this.month_report_lab.Size = new System.Drawing.Size(41, 12);
            this.month_report_lab.TabIndex = 3;
            this.month_report_lab.Text = "月付額";
            // 
            // allpay_report_lab
            // 
            this.allpay_report_lab.AutoSize = true;
            this.allpay_report_lab.Location = new System.Drawing.Point(59, 162);
            this.allpay_report_lab.Name = "allpay_report_lab";
            this.allpay_report_lab.Size = new System.Drawing.Size(41, 12);
            this.allpay_report_lab.TabIndex = 4;
            this.allpay_report_lab.Text = "總付款";
            // 
            // txtbox_one
            // 
            this.txtbox_one.Location = new System.Drawing.Point(126, 28);
            this.txtbox_one.Name = "txtbox_one";
            this.txtbox_one.ReadOnly = true;
            this.txtbox_one.Size = new System.Drawing.Size(100, 22);
            this.txtbox_one.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(126, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(126, 96);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(126, 128);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(126, 156);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 5;
            // 
            // Loan_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 205);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtbox_one);
            this.Controls.Add(this.allpay_report_lab);
            this.Controls.Add(this.month_report_lab);
            this.Controls.Add(this.rate_report_lab);
            this.Controls.Add(this.due_report_lab);
            this.Controls.Add(this.budget_report_lab);
            this.Name = "Loan_Report";
            this.Text = "Loan_Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label budget_report_lab;
        private System.Windows.Forms.Label due_report_lab;
        private System.Windows.Forms.Label rate_report_lab;
        private System.Windows.Forms.Label month_report_lab;
        private System.Windows.Forms.Label allpay_report_lab;
        public System.Windows.Forms.TextBox txtbox_one;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox5;
    }
}