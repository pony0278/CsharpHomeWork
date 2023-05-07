namespace HomeWork
{
    partial class PictureForm
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
            this.ShowImagesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowImagesButton
            // 
            this.ShowImagesButton.Location = new System.Drawing.Point(201, 105);
            this.ShowImagesButton.Name = "ShowImagesButton";
            this.ShowImagesButton.Size = new System.Drawing.Size(75, 23);
            this.ShowImagesButton.TabIndex = 0;
            this.ShowImagesButton.Text = "button1";
            this.ShowImagesButton.UseVisualStyleBackColor = true;
            this.ShowImagesButton.Click += new System.EventHandler(this.ShowImagesButton_Click);
            // 
            // PictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowImagesButton);
            this.Name = "PictureForm";
            this.Text = "PictureForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowImagesButton;
    }
}