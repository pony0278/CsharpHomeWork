using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void Hello_btn_Click(object sender, EventArgs e)
        {
            DisplayGreeting("Hello!");
        }

        private void Hi_btn_Click(object sender, EventArgs e)
        {
            DisplayGreeting("Hii!");
        }

        private void DisplayGreeting(string greeting)
        {
            string chineseAskName = GetTrimmedText(chineseName_txt);
            string englishAskName = GetTrimmedText(EnglishName_txt);
            string askGender = GetTrimmedText(Gender_txt);
            string askZebar = GetTrimmedText(Zeber_txt);

            string message = string.Format("{0}我是{1}{4}英文名字是{2}{4}性別是{3}{4}星座是{5}",
                greeting, chineseAskName, englishAskName, askGender, Environment.NewLine, askZebar);

            MessageBox.Show(message);
        }

        private string GetTrimmedText(TextBox textBox)
        {
            return textBox.Text.Trim();
        }
    }
}
