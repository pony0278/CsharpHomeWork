using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HomeWork.MyClass;

namespace HomeWork
{
    public partial class StartWindow : Form
    {
        private const int GripSize = 8;
        private bool isResizing = false;
        private Point gripOffset;
        private Form currentWindow;
        List<string> imageFiles = new List<string>();

        public StartWindow()
        {
            InitializeComponent();
        }



        private void Loan_Click(object sender, EventArgs e)
        {
            CloseCurrentWindow();
            Loan loan = new Loan();
            loan.TopLevel = false;
            loan.FormBorderStyle = FormBorderStyle.FixedSingle;
            loan.Size = new Size(300, 300);

            splitContainer6.Panel2.Controls.Add(loan);  

            int x = 0; 
            int y = 0; 
            loan.SetBounds(x, y, loan.Width, loan.Height); 

            loan.Show();
            currentWindow = loan;
        }

        private void HelloForm_Click(object sender, EventArgs e)
        {
            CloseCurrentWindow();
            HelloForm Hello = new HelloForm();
            Hello.TopLevel = false;
            Hello.FormBorderStyle = FormBorderStyle.FixedSingle;
            Hello.Size = new Size(330, 300);

            splitContainer6.Panel2.Controls.Add(Hello);

            int x = 0; 
            int y = 0; 
            Hello.SetBounds(x, y, Hello.Width, Hello.Height); 

            Hello.Show();
            currentWindow = Hello;
        }

        private void POS_Click(object sender, EventArgs e)
        {
            CloseCurrentWindow();
            POS POS = new POS();
            POS.TopLevel = false;
            POS.FormBorderStyle = FormBorderStyle.FixedSingle;
            POS.Size = new Size(750, 420);

            splitContainer6.Panel2.Controls.Add(POS);

            int x = 0;
            int y = 0;
            POS.SetBounds(x, y, POS.Width, POS.Height);

            POS.Show();
            currentWindow = POS;
        }

        private void StudentStructForm_Click(object sender, EventArgs e)
        {
            CloseCurrentWindow();
            Student_scores scores = new Student_scores();
            scores.TopLevel = false;
            scores.FormBorderStyle = FormBorderStyle.FixedSingle;
            scores.Size = new Size(630,480);

            splitContainer6.Panel2.Controls.Add(scores);

            int x = 0;
            int y = 0;
            scores.SetBounds(x, y, scores.Width, scores.Height);

            scores.Show();
            currentWindow = scores;
        }

        private void StudentsGrade_Click(object sender, EventArgs e)
        {
            CloseCurrentWindow();
            Student_RandomScores random = new Student_RandomScores();
            random.TopLevel = false;
            random.FormBorderStyle = FormBorderStyle.FixedSingle;
            random.Size = new Size(630, 480);

            splitContainer6.Panel2.Controls.Add(random);

            int x = 0;
            int y = 0;
            random.SetBounds(x, y, random.Width, random.Height);

            random.Show();
            currentWindow = random;
        }



        private void CloseCurrentWindow()
        {
            if (currentWindow != null)
            {
                currentWindow.Close();
                currentWindow.Dispose();
            }
        }

        private void StudentsGradeList_Click(object sender, EventArgs e)
        {
            CloseCurrentWindow();
            StudentScore2 score2 = new StudentScore2();
            score2.TopLevel = false;
            score2.FormBorderStyle = FormBorderStyle.FixedSingle;
            score2.Size = new Size(630, 630);

            splitContainer6.Panel2.Controls.Add(score2);

            int x = 0;
            int y = 0;
            score2.SetBounds(x, y, score2.Width, score2.Height);

            score2.Show();
            currentWindow = score2;
        }

        private void MyClac_Click(object sender, EventArgs e)
        {
            CloseCurrentWindow();
            MyClac myClac = new MyClac();
            myClac.TopLevel = false;
            myClac.FormBorderStyle = FormBorderStyle.FixedSingle;
            myClac.Size = new Size(400, 250);

            splitContainer6.Panel2.Controls.Add(myClac);

            int x = 0;
            int y = 0;
            myClac.SetBounds(x, y, myClac.Width, myClac.Height);

            myClac.Show();
            currentWindow = myClac;
        }

        private void XOGame_Click(object sender, EventArgs e)
        {
            CloseCurrentWindow();
            XOGAME xOGame = new XOGAME();
            xOGame.TopLevel = false;
            xOGame.FormBorderStyle = FormBorderStyle.FixedSingle;
            xOGame.Size = new Size(300, 350);

            splitContainer6.Panel2.Controls.Add(xOGame);

            int x = 0;
            int y = 0;
            xOGame.SetBounds(x, y, xOGame.Width, xOGame.Height);

            xOGame.Show();
            currentWindow = xOGame;
        }


        private void ScreenSaver_Click(object sender, EventArgs e)
        {
            CloseCurrentWindow();
            ScreenSaverForm ScreenSaver = new ScreenSaverForm();
            ScreenSaver.TopLevel = true;


            ScreenSaver.Show();
            currentWindow = ScreenSaver;
        }

        private void GuessNumber_Click(object sender, EventArgs e)
        {
            CloseCurrentWindow();
            GuessNumberGame GuessNumber = new GuessNumberGame();
            GuessNumber.TopLevel = false;
            GuessNumber.FormBorderStyle = FormBorderStyle.FixedSingle;
            GuessNumber.Size = new Size(450, 350);

            splitContainer6.Panel2.Controls.Add(GuessNumber);

            int x = 0;
            int y = 0;
            GuessNumber.SetBounds(x, y, GuessNumber.Width, GuessNumber.Height);

            GuessNumber.Show();
            currentWindow = GuessNumber;
        }

        private void ShowImagesButton_Click(object sender, EventArgs e)
        {
            // 新視窗
            ImageForm imageForm = new ImageForm();

            // 設定縮圖
            int thumbnailSize = 200;

            // 
            string debugFolder = Path.GetDirectoryName(Application.ExecutablePath);

            // 資料夾jpg.png檔案
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
            CloseCurrentWindow();
            imageForm.Show();
            Imageform image = new Imageform();
            image.TopLevel = false;
            image.FormBorderStyle = FormBorderStyle.FixedSingle;

            splitContainer6.Panel2.Controls.Add(image);

            int x = 0;
            int y = 0;
            image.SetBounds(x, y, image.Width, image.Height);

            currentWindow = image;
        }
    }

    public class ImageForm : Form
    {
        public ImageForm()
        {
            // 設定預設大小
            Text = "Pictues IN YOUR DESKTOP";
            Width = 1000;
            Height = 300;
            AutoScroll = true;
        }
    }
}
