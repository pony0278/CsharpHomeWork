using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Student_RandomScores : Form
    {
        private List<int> NameCount = new List<int>();
        private List<int> chinese = new List<int>();
        private List<int> math = new List<int>();
        private List<int> english = new List<int>();
        private bool reButtonClicked = false;


        public Student_RandomScores()
        {
            InitializeComponent();
            InitialListView();
            InitialListView2();
        }

        private void InitialListView()
        {
            // 設定 ListView 的樣式與欄位
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
            int NameCounts = NameCount.Count + 1;
            NameCount.Add(NameCounts);
            chinese.Add(chineseScore);
            math.Add(mathScore);
            english.Add(englishScore);

            // 計算總分、平均、最高分、最低分
            int totalScore = chineseScore + mathScore + englishScore;
            double averageScore = (double)totalScore / 3.0;
            int[] scores = new int[] { chineseScore, mathScore, englishScore };
            int maxScore = scores.Max();
            int minScore = scores.Min();
            string maxSubject = GetSubjectWithMaxScore(chineseScore, mathScore, englishScore, maxScore);
            string minSubject = GetSubjectWithMinScore(chineseScore, mathScore, englishScore, minScore);

            // 新增資料至 ListView
            var item = new ListViewItem(new[] { name, chineseScore.ToString(),
                englishScore.ToString(), mathScore.ToString(), totalScore.ToString(),
                averageScore.ToString("F1"), $"{minSubject}{minScore}", $"{maxSubject}{maxScore}" });
            listView1.Items.Add(item);
        }

        private void random_btn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int min = 0;
            int max = 100;
            int chineseScore = random.Next(min, max + 1);
            int mathScore = random.Next(min, max + 1);
            int englishScore = random.Next(min, max + 1);
            int NameCounts = NameCount.Count + 1;
            NameCount.Add(NameCounts);
            chinese.Add(chineseScore);
            math.Add(mathScore);
            english.Add(englishScore);


            // 計算總分、平均、最高分、最低分
            int totalScore = chineseScore + mathScore + englishScore;
            double averageScore = (double)totalScore / 3.0;
            int[] scores = new int[] { chineseScore, mathScore, englishScore };
            int maxScore = scores.Max();
            int minScore = scores.Min();
            string maxSubject = GetSubjectWithMaxScore(chineseScore, mathScore, englishScore, maxScore);
            string minSubject = GetSubjectWithMinScore(chineseScore, mathScore, englishScore, minScore);

            // 新增資料至 ListView
            var item = new ListViewItem(new[] { NameCounts.ToString(), chineseScore.ToString(),
            englishScore.ToString(), mathScore.ToString(), totalScore.ToString(),
            averageScore.ToString("F1"), $"{minSubject}{minScore}", $"{maxSubject}{maxScore}" });
            listView1.Items.Add(item);
        }

        private void cal_btn_Click(object sender, EventArgs e)
        {
            if (chinese.Count == 0 || math.Count == 0 || english.Count == 0)
            {
                MessageBox.Show("請先新增資料");
                return;
            }

            int chineseNum = chinese.Sum();
            int mathNum = math.Sum();
            int englishNum = english.Sum();
            double chineseAvg = chinese.Average();
            double mathAvg = math.Average();
            double englishAvg = english.Average();
            int chineseMax = chinese.Max();
            int mathMax = math.Max();
            int englishMax = english.Max();
            int chineseMin = chinese.Min();
            int mathMin = math.Min();
            int englishMin = english.Min();

            var total = new ListViewItem(new[] { $"總分 ", $"{chineseNum.ToString()}", $"{mathNum.ToString()}", $"{englishNum.ToString()}" });
            var Avg = new ListViewItem(new[] { $"平均 ", $"{chineseAvg:0.00}", $"{mathAvg:0.00}", $"{englishAvg:0.00}" });
            var MaxScores = new ListViewItem(new[] { $"最高分", $"{chineseMax.ToString()}", $"{mathMax.ToString()}", $"{englishMax.ToString()}" });
            var MinScores = new ListViewItem(new[] { $"最低分", $"{chineseMin.ToString()}", $"{mathMin.ToString()}", $"{englishMin.ToString()}" });
            listView2.Items.Add(total);
            listView2.Items.Add(Avg);
            listView2.Items.Add(MaxScores);
            listView2.Items.Add(MinScores);
            cal_btn.Enabled = false;
        }
        private void InitialListView2()
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

        private void re_btn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            NameCount.Clear();
            chinese.Clear();
            math.Clear();
            english.Clear();

            reButtonClicked = true;
            cal_btn.Enabled = true;
        }

        private void random20_btn_Click(object sender, EventArgs e)
        {
            Random random = new Random();


                for (int i = 0; i < 20; i++)
                {
                    int min = 0;
                    int max = 100;
                    int chineseScore = random.Next(min, max + 1);
                    int mathScore = random.Next(min, max + 1);
                    int englishScore = random.Next(min, max + 1);
                    int NameCounts = NameCount.Count + 1;
                    NameCount.Add(NameCounts);
                    chinese.Add(chineseScore);
                    math.Add(mathScore);
                    english.Add(englishScore);

                    int totalScore = chineseScore + mathScore + englishScore;
                    double averageScore = (double)totalScore / 3.0;
                    int[] scores = new int[] { chineseScore, mathScore, englishScore };
                    int maxScore = scores.Max();
                    int minScore = scores.Min();
                    string maxSubject = GetSubjectWithMaxScore(chineseScore, mathScore, englishScore, maxScore);
                    string minSubject = GetSubjectWithMinScore(chineseScore, mathScore, englishScore, minScore);

                    var item = new ListViewItem(new[] { NameCounts.ToString(), chineseScore.ToString(),
                englishScore.ToString(), mathScore.ToString(), totalScore.ToString(),
                averageScore.ToString("F1"), $"{minSubject}{minScore}", $"{maxSubject}{maxScore}" });
                    listView1.Items.Add(item);
                }
            
        }
        private string GetSubjectWithMaxScore(int chineseScore, int mathScore, int englishScore, int maxScore)
        {
            if (maxScore == chineseScore)
                return "國文";
            else if (maxScore == mathScore)
                return "數學";
            else
                return "英文";
        }
        private string GetSubjectWithMinScore(int chineseScore, int mathScore, int englishScore, int minScore)
        {
            if (minScore == chineseScore)
                return "國文";
            else if (minScore == mathScore)
                return "數學";
            else
                return "英文";
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

    }
}


