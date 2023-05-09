using System;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class GuessNumberGame : Form
    {
        public static int randomNumber { get; private set; }
        private InputDialogForm inputForm; 

        public GuessNumberGame()
        {
            InitializeComponent();
        }

        private void GuessNumberGame_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            inputForm = new InputDialogForm(); 
            inputForm.ShowDialog();
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("正確答案：" + randomNumber.ToString());
        }

    }
}
