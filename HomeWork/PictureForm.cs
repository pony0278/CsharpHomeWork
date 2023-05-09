using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class PictureForm : Form
    {
        public PictureForm()
        {
            InitializeComponent();
        }

        private void ShowImagesButton_Click(object sender, EventArgs e)
        {
            // 新視窗
            ImageForm imageForm = new ImageForm();

            // 設定縮圖
            int thumbnailSize = 200;

            // debug專案資料夾路徑
            string debugFolder = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // debug資料夾jpg.png檔案
            string[] imageFiles = Directory.GetFiles(debugFolder, "*.jpg");
            imageFiles = imageFiles.Concat(Directory.GetFiles(debugFolder, "*.png")).ToArray();

            // 計算瀏覽方式的列數和間隔
            int columns = (imageForm.Width - 20) / (thumbnailSize + 10);
            int spacing = (imageForm.Width - 20 - (columns * thumbnailSize)) / (columns + 1);

            // 顯示圖片
            int currentColumn = 0;
            int currentRow = 0;
            foreach (string imageFile in imageFiles)
            {
                // 加入圖片
                Image originalImage = Image.FromFile(imageFile);

                // 縮小圖片
                Image thumbnail = originalImage.GetThumbnailImage(thumbnailSize, thumbnailSize, null, IntPtr.Zero);

                // 使用PictureBox控制元件顯示縮圖
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = thumbnail;
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

                // 計算縮圖位置
                int left = spacing + (currentColumn * (thumbnailSize + spacing));
                int top = spacing + (currentRow * (thumbnailSize + spacing));

                // 設定PictureBox的位置
                pictureBox.Left = left;
                pictureBox.Top = top;

                // 將PictureBox控制元件加入視窗中
                imageForm.Controls.Add(pictureBox);

                // 更新列和行的計數器
                currentColumn++;
                if (currentColumn >= columns)
                {
                    currentColumn = 0;
                    currentRow++;
                }
            }

            // 要容納所有縮圖
            int numRows = (int)Math.Ceiling((double)imageFiles.Length / columns);
            int totalHeight = (thumbnailSize + spacing) * numRows + spacing;
            imageForm.Height = totalHeight;

            // 顯示
            imageForm.Show();
        }
    }

    public class Imageform : Form
    {
        public Imageform()
        {
            // 設定預設大小
            Text = "圖像窗口";
            Width = 800;
            Height = 600;
            AutoScroll = true;
        }
    }
}
    

