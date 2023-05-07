using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HomeWork.StudentScore2;
using static System.Net.Mime.MediaTypeNames;

namespace HomeWork
{
    public partial class StudentScore2 : Form
    {

        private bool addBtn = false;
        private bool insertBtn = false;
        private List<int> NameCount = new List<int>();
        private List<int> chinese = new List<int>();
        private List<int> math = new List<int>();
        private List<int> english = new List<int>();

        public StudentScore2()
        {
            InitializeComponent();
            InitializeListView();
            InitializeListView2();
        }

        private List<Student> students = new List<Student>();

        private void InitializeListView()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.LabelEdit = false;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("姓名");
            listView1.Columns.Add("國文");
            listView1.Columns.Add("英文");
            listView1.Columns.Add("數學");
            listView1.Columns.Add("總分");
            listView1.Columns.Add("平均");
            listView1.Columns.Add("最低");
            listView1.Columns.Add("最高");
        }

        private void AddDataToListView(Student student)
        {
            int totalScore = student.ChineseScore + student.MathScore + student.EnglishScore;
            double averageScore = (double)totalScore / 3.0;
            int[] scores = new int[] { student.ChineseScore, student.MathScore, student.EnglishScore };
            int maxScore = scores.Max();
            int minScore = scores.Min();
            string maxSubject = GetSubjectByScore(maxScore, student);
            string minSubject = GetSubjectByScore(minScore, student);

            var item = new ListViewItem(new[]
            {
                student.Name, student.ChineseScore.ToString(),
                student.EnglishScore.ToString(), student.MathScore.ToString(),
                totalScore.ToString(), averageScore.ToString("F1"),
                $"{minSubject}{minScore}", $"{maxSubject}{maxScore}"
            });
            listView1.Items.Add(item);
        }

        private void AddDataToListView_Insert(Student student)
        {
            int totalScore = student.ChineseScore + student.MathScore + student.EnglishScore;
            double averageScore = (double)totalScore / 3.0;
            int[] scores = new int[] { student.ChineseScore, student.MathScore, student.EnglishScore };
            int maxScore = scores.Max();
            int minScore = scores.Min();
            string maxSubject = GetSubjectByScore(maxScore, student);
            string minSubject = GetSubjectByScore(minScore, student);

            var item = new ListViewItem(new[]
            {
                student.Name, student.ChineseScore.ToString(),
                student.EnglishScore.ToString(), student.MathScore.ToString(),
                totalScore.ToString(), averageScore.ToString("F1"),
                $"{minSubject}{minScore}", $"{maxSubject}{maxScore}"
            });
            listView1.Items.Insert(0, item);
        }

        private string GetSubjectByScore(int score, Student student)
        {
            if (score == student.ChineseScore)
                return "國文";
            else if (score == student.MathScore)
                return "數學";
            else
                return "英文";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
            {
                MessageBox.Show("請填寫所有欄位");
                return;
            }

            string name = name_txt.Text.Trim();
                int chineseScore = int.Parse(chinese_txt.Text.Trim());
                int mathScore = int.Parse(math_txt.Text.Trim());
                int englishScore = int.Parse(english_txt.Text.Trim());

                Student student = new Student(name, chineseScore, mathScore, englishScore);
                students.Add(student);

                AddDataToListView(student);

                ClearInputFields();

                addBtn = true;
                cal_btn.Enabled = true;
        }

        private bool IsValidInput()
        {
            // 檢查是否有任何欄位為空
            if (string.IsNullOrEmpty(name_txt.Text) ||
                string.IsNullOrEmpty(chinese_txt.Text) ||
                string.IsNullOrEmpty(math_txt.Text) ||
                string.IsNullOrEmpty(english_txt.Text))
            {
                return false;
            }

            // 檢查分數是否為有效數字
            int chineseScore, mathScore, englishScore;
            if (!int.TryParse(chinese_txt.Text, out chineseScore) ||
                !int.TryParse(math_txt.Text, out mathScore) ||
                !int.TryParse(english_txt.Text, out englishScore))
            {
                return false;
            }

            // 檢查分數是否在有效範圍內
            const int minScore = 0;
            const int maxScore = 100;
            if (chineseScore < minScore || chineseScore > maxScore ||
                mathScore < minScore || mathScore > maxScore ||
                englishScore < minScore || englishScore > maxScore)
            {
                return false;
            }

            return true;
        }

        private void ClearInputFields()
        {
            name_txt.Text = string.Empty;
            chinese_txt.Text = string.Empty;
            math_txt.Text = string.Empty;
            english_txt.Text = string.Empty;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (!IsValidInput())
            {
                MessageBox.Show("請填寫所有欄位");
                return;
            }
            string name = name_txt.Text.Trim();
                int chineseScore = int.Parse(chinese_txt.Text.Trim());
                int mathScore = int.Parse(math_txt.Text.Trim());
                int englishScore = int.Parse(english_txt.Text.Trim());

                Student student = new Student(name, chineseScore, mathScore, englishScore);
                students.Insert(0, student);

            AddDataToListView_Insert(student);

                ClearInputFields();
                insertBtn = true;
                cal_btn.Enabled = true;
        }

        private void sreach_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(range1_txt.Text) && string.IsNullOrEmpty(range2_txt.Text))
            {
                MessageBox.Show("請填寫搜尋欄位");
                return;
            }

            if (int.TryParse(range1_txt.Text, out int range1) && int.TryParse(range2_txt.Text, out int range2))
            {
                List<Student> filteredStudents = students.Where(student => student.ChineseScore >= range1 && student.ChineseScore <= range2).ToList();

                listView1.Items.Clear();
                foreach (Student student in filteredStudents)
                {
                    AddDataToListView(student);
                }
            }

        }

        private void cal_btn_Click(object sender, EventArgs e)
        {

            int chineseSum = students.Sum(student => student.ChineseScore);
            int mathSum = students.Sum(student => student.MathScore);
            int englishSum = students.Sum(student => student.EnglishScore);
            double chineseAvg = students.Average(student => student.ChineseScore);
            double mathAvg = students.Average(student => student.MathScore);
            double englishAvg = students.Average(student => student.EnglishScore);
            int chineseMax = students.Max(student => student.ChineseScore);
            int mathMax = students.Max(student => student.MathScore);
            int englishMax = students.Max(student => student.EnglishScore);
            int chineseMin = students.Min(student => student.ChineseScore);
            int mathMin = students.Min(student => student.MathScore);
            int englishMin = students.Min(student => student.EnglishScore);

            var total = new ListViewItem(new[] { "總分 ", chineseSum.ToString(), mathSum.ToString(), englishSum.ToString() });
            var avg = new ListViewItem(new[] { "平均 ", $"{chineseAvg:0.00}", $"{mathAvg:0.00}", $"{englishAvg:0.00}" });
            var maxScores = new ListViewItem(new[] { "最高分", $"{chineseMax}", $"{mathMax}", $"{englishMax}" });
            var minScores = new ListViewItem(new[] { "最低分", $"{chineseMin}", $"{mathMin}", $"{englishMin}" });

            listView2.Items.Clear();
            listView2.Items.Add(total);
            listView2.Items.Add(avg);
            listView2.Items.Add(maxScores);
            listView2.Items.Add(minScores);
            cal_btn.Enabled = false;
        }

        private void InitializeListView2()
        {
            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.LabelEdit = false;
            listView2.FullRowSelect = true;
            listView2.Columns.Add("");
            listView2.Columns.Add("");
            listView2.Columns.Add("");
            listView2.Columns.Add("");
        }

        public class Student
        {
            public string Name { get; set; }
            public int ChineseScore { get; set; }
            public int MathScore { get; set; }
            public int EnglishScore { get; set; }

            public Student(string name, int chineseScore, int mathScore, int englishScore)
            {
                Name = name;
                ChineseScore = chineseScore;
                MathScore = mathScore;
                EnglishScore = englishScore;
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            NameCount.Clear();
            chinese.Clear();
            math.Clear();
            english.Clear();

            cal_btn.Enabled = false;
            students = new List<Student>();
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.RemoveAt(0);
            }
        }
    }

}

