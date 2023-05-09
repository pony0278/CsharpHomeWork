using System;
using System.Drawing;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class ScreenSaverForm : Form
    {
        private Timer timer;
        private Image movingImage;
        private string movingImagePath = "TINDER.jpg"; // 可以換圖
        private int imageWidth = 500;
        private int imageHeight = 500;
        private int imageSpeed = 5; // 移動速度
        private Point movingImagePosition; // 移動位置
        private bool reverseX; // X軸
        private bool reverseY; // Y軸
        private Timer mouseTimer;
        private bool isMouseMoved;


        public ScreenSaverForm()
        {
            InitializeComponent();
            mouseTimer = new Timer();
            //設定初始化
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            this.StartPosition = FormStartPosition.Manual;
            this.BackColor = Color.Black;
            this.MouseClick += ScreenSaverForm_MouseClick;

            // 移動圖片
            movingImage = ResizeImage(Properties.Resources.TINDER, imageWidth, imageHeight);
            movingImagePosition = new Point((this.Width - imageWidth) / 2, (this.Height - imageHeight) / 2);

            // 設定計時器
            timer = new Timer();
            timer.Interval = 30; 
            timer.Tick += Timer_Tick;
            timer.Start();
            mouseTimer.Interval = 8000; // 滑鼠延遲時間
            mouseTimer.Tick += MouseTimer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MoveImage();

            CheckBoundaryCollision();

            this.Invalidate();
        }

        private void MoveImage()
        {
           
            int deltaX = reverseX ? -imageSpeed : imageSpeed;
            int deltaY = reverseY ? -imageSpeed : imageSpeed;
            movingImagePosition.X += deltaX;
            movingImagePosition.Y += deltaY;
        }

        private void CheckBoundaryCollision()
        {
            // 檢查是否碰到邊界
            if (movingImagePosition.X <= 0 || movingImagePosition.X >= this.Width - imageWidth)
            {
                // 如果碰到邊界就往反方向移動
                reverseX = !reverseX;
            }
            if (movingImagePosition.Y <= 0 || movingImagePosition.Y >= this.Height - imageHeight)
            {
                // 如果碰到邊界就往反方向移動
                reverseY = !reverseY;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // 重新構圖
            e.Graphics.DrawImage(movingImage, movingImagePosition.X, movingImagePosition.Y, imageWidth, imageHeight);
        }

        private void ScreenSaverForm_MouseClick(object sender, MouseEventArgs e)
        {
            // 點擊回到桌面
            this.Close();
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            return new Bitmap(image, width, height);
        }

        private void MouseTimer_Tick(object sender, EventArgs e)
        {
            mouseTimer.Stop();
            if (isMouseMoved)
            {
                this.Close();
            }
        }

        private void ScreenSaverForm_MouseMove(object sender, MouseEventArgs e)
        {
            isMouseMoved = true;
            mouseTimer.Stop();
            mouseTimer.Start();
        }
    }
}
