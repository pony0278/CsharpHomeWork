using System;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class InputDialogForm : Form
    {

        public InputDialogForm()
        {
            InitializeComponent();
        }

        public int GetGuessedNumber()
        {
            int guessedNumber;
            if (int.TryParse(txtInput.Text, out guessedNumber))
            {
                return guessedNumber;
            }
            else
            {
                MessageBox.Show("請輸入正確數字");
                return 0;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CheckGuessedNumber(GetGuessedNumber());
        }

        public void ShowResultMessage(string message)
        {
            MessageBox.Show(this, message, "提示");
        }

        private void CheckGuessedNumber(int guessedNumber)
        {
            int randomNumber = GuessNumberGame.randomNumber; 

            if (guessedNumber > randomNumber)
            {
                MessageBox.Show("猜的數字太大");
            }
            else if (guessedNumber < randomNumber)
            {
                MessageBox.Show("猜的數字太小");
            }
            else
            {
                MessageBox.Show("猜中了");
                Close();
            }
        }
    }
}
