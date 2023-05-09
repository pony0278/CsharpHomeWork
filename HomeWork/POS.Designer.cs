namespace HomeWork
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wine_btn = new System.Windows.Forms.Button();
            this.winsky_btn = new System.Windows.Forms.Button();
            this.tequlia_btn = new System.Windows.Forms.Button();
            this.beer_btn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.totalPrice_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.creditCard_btn = new System.Windows.Forms.Button();
            this.Cash_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.orderMessageLabel = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.wine_btn);
            this.groupBox1.Controls.Add(this.winsky_btn);
            this.groupBox1.Controls.Add(this.tequlia_btn);
            this.groupBox1.Controls.Add(this.beer_btn);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // wine_btn
            // 
            this.wine_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wine_btn.BackgroundImage")));
            this.wine_btn.Location = new System.Drawing.Point(120, 130);
            this.wine_btn.Name = "wine_btn";
            this.wine_btn.Size = new System.Drawing.Size(108, 95);
            this.wine_btn.TabIndex = 0;
            this.wine_btn.UseVisualStyleBackColor = true;
            this.wine_btn.Click += new System.EventHandler(this.wine_btn_Click);
            // 
            // winsky_btn
            // 
            this.winsky_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("winsky_btn.BackgroundImage")));
            this.winsky_btn.Location = new System.Drawing.Point(6, 129);
            this.winsky_btn.Name = "winsky_btn";
            this.winsky_btn.Size = new System.Drawing.Size(108, 95);
            this.winsky_btn.TabIndex = 0;
            this.winsky_btn.UseVisualStyleBackColor = true;
            this.winsky_btn.Click += new System.EventHandler(this.winsky_btn_Click);
            // 
            // tequlia_btn
            // 
            this.tequlia_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tequlia_btn.BackgroundImage")));
            this.tequlia_btn.Location = new System.Drawing.Point(120, 18);
            this.tequlia_btn.Name = "tequlia_btn";
            this.tequlia_btn.Size = new System.Drawing.Size(108, 97);
            this.tequlia_btn.TabIndex = 0;
            this.tequlia_btn.UseVisualStyleBackColor = true;
            this.tequlia_btn.Click += new System.EventHandler(this.tequlia_btn_Click);
            // 
            // beer_btn
            // 
            this.beer_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("beer_btn.BackgroundImage")));
            this.beer_btn.Location = new System.Drawing.Point(6, 17);
            this.beer_btn.Name = "beer_btn";
            this.beer_btn.Size = new System.Drawing.Size(108, 97);
            this.beer_btn.TabIndex = 0;
            this.beer_btn.UseVisualStyleBackColor = true;
            this.beer_btn.Click += new System.EventHandler(this.beer_btn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalPrice_txt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(280, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // totalPrice_txt
            // 
            this.totalPrice_txt.Location = new System.Drawing.Point(10, 25);
            this.totalPrice_txt.Name = "totalPrice_txt";
            this.totalPrice_txt.ReadOnly = true;
            this.totalPrice_txt.Size = new System.Drawing.Size(184, 22);
            this.totalPrice_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(7, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "總金額Total Price";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.creditCard_btn);
            this.groupBox3.Controls.Add(this.Cash_btn);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(280, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "信用卡享9折";
            // 
            // creditCard_btn
            // 
            this.creditCard_btn.Location = new System.Drawing.Point(125, 29);
            this.creditCard_btn.Name = "creditCard_btn";
            this.creditCard_btn.Size = new System.Drawing.Size(75, 23);
            this.creditCard_btn.TabIndex = 4;
            this.creditCard_btn.Text = "信用卡";
            this.creditCard_btn.UseVisualStyleBackColor = true;
            this.creditCard_btn.Click += new System.EventHandler(this.creditCard_btn_Click);
            // 
            // Cash_btn
            // 
            this.Cash_btn.Location = new System.Drawing.Point(10, 28);
            this.Cash_btn.Name = "Cash_btn";
            this.Cash_btn.Size = new System.Drawing.Size(75, 23);
            this.Cash_btn.TabIndex = 3;
            this.Cash_btn.Text = "現金";
            this.Cash_btn.UseVisualStyleBackColor = true;
            this.Cash_btn.Click += new System.EventHandler(this.Cash_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "付款方式";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.orderMessageLabel);
            this.groupBox4.Controls.Add(this.clear_btn);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(486, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 256);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // orderMessageLabel
            // 
            this.orderMessageLabel.AutoSize = true;
            this.orderMessageLabel.Location = new System.Drawing.Point(8, 53);
            this.orderMessageLabel.Name = "orderMessageLabel";
            this.orderMessageLabel.Size = new System.Drawing.Size(53, 12);
            this.orderMessageLabel.TabIndex = 4;
            this.orderMessageLabel.Text = "尚未點餐";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(119, 218);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 2;
            this.clear_btn.Text = "清除按鈕";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "購物清單List";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 294);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "POS";
            this.Text = "POS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button wine_btn;
        private System.Windows.Forms.Button winsky_btn;
        private System.Windows.Forms.Button tequlia_btn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox totalPrice_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button creditCard_btn;
        private System.Windows.Forms.Button Cash_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button beer_btn;
        private System.Windows.Forms.Label orderMessageLabel;
    }
}