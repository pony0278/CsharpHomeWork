using System;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Loan : Form
    {
        public Loan()
        {
            InitializeComponent();
        }

        private int month;
        private int allPay;

        private int CalculateMonthPayment()
        {
            if (!IsValidInput())
            {
                MessageBox.Show("請填寫所有欄位");
                return 0;
            }

            int budget;
            int due;
            double rate;
            int first;
            if (!int.TryParse(budget_txt.Text, out budget) || !int.TryParse(due_txt.Text, out due) ||
                !double.TryParse(rate_txt.Text, out rate) || !int.TryParse(first_txt.Text, out first))
            {
                MessageBox.Show("輸入格式不正確");
                return 0;
            }

            double myMoney = budget - first;
            double numerator = myMoney * rate * Math.Pow((1 + rate), due);
            double denominator = Math.Pow((1 + rate), due) - 1;
            int monthPayment = (int)(numerator / denominator);

            return monthPayment;
        }

        private int CalculateTotalPayment()
        {
            if (!IsValidInput())
            {
                MessageBox.Show("請填寫所有欄位");
                return 0;
            }

            int budget;
            int due;
            double rate;
            int first;
            if (!int.TryParse(budget_txt.Text, out budget) || !int.TryParse(due_txt.Text, out due) ||
                !double.TryParse(rate_txt.Text, out rate) || !int.TryParse(first_txt.Text, out first))
            {
                MessageBox.Show("輸入格式不正確");
                return 0;
            }

            double totalPayment = (budget - first) * (1 + rate * due);

            return (int)totalPayment;
        }

        private bool IsValidInput()
        {
            return !string.IsNullOrWhiteSpace(budget_txt.Text) &&
                !string.IsNullOrWhiteSpace(due_txt.Text) &&
                !string.IsNullOrWhiteSpace(rate_txt.Text) &&
                !string.IsNullOrWhiteSpace(first_txt.Text);
        }

        private void Month_btn_Click(object sender, EventArgs e)
        {
            month = CalculateMonthPayment();
            if (month > 0)
            {
                MessageBox.Show("月付額：" + month);
            }
        }

        private void allPay_btn_Click(object sender, EventArgs e)
        {
            allPay = CalculateTotalPayment();
            if (allPay > 0)
            {
                MessageBox.Show("總付款：" + allPay);
            }
        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
            {
                MessageBox.Show("請填寫所有欄位");
                return;
            }

            month = CalculateMonthPayment();
            allPay = CalculateTotalPayment();

            Loan_Report loan_report = new Loan_Report();
            loan_report.txtbox_one.Text = budget_txt.Text;
            loan_report.textBox2.Text = due_txt.Text;
            loan_report.textBox3.Text = rate_txt.Text;
            loan_report.textBox4.Text = month.ToString();
            loan_report.textBox5.Text = allPay.ToString();
            loan_report.Show();
        }
    }
}
