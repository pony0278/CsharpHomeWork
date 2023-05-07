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
    public partial class Student_scores : Form
    {
        private string savedText;
        private int[] savedTexts = new int[3];

        public Student_scores()
        {
            InitializeComponent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                savedText = name_txt.Text.Trim();
                savedTexts[0] = int.Parse(chinese_txt.Text);
                savedTexts[1] = int.Parse(math_txt.Text);
                savedTexts[2] = int.Parse(english_txt.Text);
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("請填寫所有欄位");
            }
        }

        private void showSave_btn_Click(object sender, EventArgs e)
        {
            showScore_lab.Text = $"姓名：{savedText}\n";
            showScore_lab.Text += $"國文：{savedTexts[0]}\n";
            showScore_lab.Text += $"數學：{savedTexts[1]}\n";
            showScore_lab.Text += $"英文：{savedTexts[2]}\n";
        }

        private void MinMax_btn_Click(object sender, EventArgs e)
        {
            int maxIndex = Array.IndexOf(savedTexts, savedTexts.Max()) + 1;
            int minIndex = Array.IndexOf(savedTexts, savedTexts.Min()) + 1;
            string maxSubject = GetSubjectString(maxIndex);
            string minSubject = GetSubjectString(minIndex);
            int maxScore = savedTexts.Max();
            int minScore = savedTexts.Min();

            MinMax_lab.Text = $"最高分的是：{maxSubject} {maxScore}分\n";
            MinMax_lab.Text += $"最低分的是：{minSubject} {minScore}分";
        }

        private bool IsValidInput()
        {
            bool isNameValid = !string.IsNullOrEmpty(name_txt.Text);
            bool isChineseValid = int.TryParse(chinese_txt.Text, out int chineseScore);
            bool isMathValid = int.TryParse(math_txt.Text, out int mathScore);
            bool isEnglishValid = int.TryParse(english_txt.Text, out int englishScore);

            return isNameValid && isChineseValid && isMathValid && isEnglishValid;
        }


        private void ClearInputFields()
        {
            name_txt.Text = "";
            chinese_txt.Text = "";
            math_txt.Text = "";
            english_txt.Text = "";
        }

        private string GetSubjectString(int subjectIndex)
        {
            switch (subjectIndex)
            {
                case 1:
                    return "國文";
                case 2:
                    return "數學";
                case 3:
                    return "英文";
                default:
                    return string.Empty;
            }
        }
    }
}

