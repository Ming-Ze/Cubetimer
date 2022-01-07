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

namespace CubeTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            L_scramble.Text = sc.Generate();
            L_scramble.Location = new Point((Width - L_scramble.Width) / 2, 50);
            L_time.Location = new Point((Width - L_time.Width) / 2, (Height - L_time.Height) / 2 - 100);
            //有關location的東西純粹是為了調整成績的位置
        }

        bool timing = false;
        bool keypress = false;
        private DateTime startTime;
        Scramble sc = new Scramble();
        public Button[,] B_orange = new Button[3, 3];
        public Button[,] B_green = new Button[3, 3];
        public Button[,] B_red = new Button[3, 3];
        public Button[,] B_blue = new Button[3, 3];
        public Button[,] B_white = new Button[3, 3];
        public Button[,] B_yellow = new Button[3, 3];
        public SaveFileDialog saveFileDialog1 = new SaveFileDialog();

        //RY 1228
        public double[] grade = new double[500];
        public string[] scramble = new string[500];
        public int index = 0;
        public double sum = 0.0;
        public double average = 0.0;
        public double best = 0.0;
        public double worst = 0.0;
        //RY 1228

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i<3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    B_orange[i, j] = new Button();
                    B_orange[i, j].SetBounds(460 + j * 30, 530 + i * 30, 30, 30);
                    B_orange[i, j].BackColor = Color.Orange;
                    B_orange[i, j].Enabled = false;
                    Controls.Add(B_orange[i, j]);

                    B_green[i, j] = new Button();
                    B_green[i, j].SetBounds(570 + j * 30, 530 + i * 30, 30, 30);
                    B_green[i, j].BackColor = Color.Green;
                    B_green[i, j].Enabled = false;
                    Controls.Add(B_green[i, j]);

                    B_red[i, j] = new Button();
                    B_red[i, j].SetBounds(680 + j * 30, 530 + i * 30, 30, 30);
                    B_red[i, j].BackColor = Color.Red;
                    B_red[i, j].Enabled = false;
                    Controls.Add(B_red[i, j]);

                    B_blue[i, j] = new Button();
                    B_blue[i, j].SetBounds(790 + j * 30, 530 + i * 30, 30, 30);
                    B_blue[i, j].BackColor = Color.Blue;
                    B_blue[i, j].Enabled = false;
                    Controls.Add(B_blue[i, j]);

                    B_white[i, j] = new Button();
                    B_white[i, j].SetBounds(570 + j * 30, 420 + i * 30, 30, 30);
                    B_white[i, j].BackColor = Color.White;
                    B_white[i, j].Enabled = false;
                    Controls.Add(B_white[i, j]);

                    B_yellow[i, j] = new Button();
                    B_yellow[i, j].SetBounds(570 + j * 30, 640 + i * 30, 30, 30);
                    B_yellow[i, j].BackColor = Color.Yellow;
                    B_yellow[i, j].Enabled = false;
                    Controls.Add(B_yellow[i, j]);
                }
            }
            ShowScramble();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = DateTime.Now - startTime;
            L_time.Text = timeElapsed.TotalSeconds.ToString("0.00");
            if(timeElapsed.Seconds >= 10)
            {
                L_time.Location = new Point((Width - L_time.Width) / 2, (Height - L_time.Height) / 2 - 100);
            }
            if(timeElapsed.Minutes >= 1)
            {
                L_time.Text = timeElapsed.Minutes.ToString() + ":" + timeElapsed.Seconds.ToString("00") + "." + (timeElapsed.Milliseconds / 10).ToString("00");
                L_time.Location = new Point((Width - L_time.Width) / 2, (Height - L_time.Height) / 2 - 100);
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            L_time.ForeColor = Color.Green;
            timer2.Stop();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space || keypress)        //因為有快捷鍵設定 這邊像網站上使用空白鍵
                return;
            if (timing)
                return;
            keypress = true;
            L_time.Text = "0.00";
            L_time.ForeColor = Color.Red;
            timer2.Start();
            L_time.Location = new Point((Width - L_time.Width) / 2, (Height - L_time.Height) / 2 - 100);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Space)
                return;
            if(L_time.ForeColor != Color.Green && !timing)
            {
                L_time.ForeColor = Color.Black;
                keypress = false;
                timer2.Stop();
                return;
            }

            L_time.ForeColor = Color.Black;
            keypress = false;

            if (!timing)
            {
                startTime = DateTime.Now;
                timer1.Start();
                timing = true;
            }
            else
            {
                timer1.Stop();
                timing = false;

                //RY1228
                RecordHistory();
                Statistics();
                index++;
                //RY1228

                SaveScores();//儲存成績所用(看你要不要做一個確認儲存成績的選項)
                L_scramble.Text = sc.Generate();
                L_scramble.Location = new Point((Width - L_scramble.Width) / 2, 50);
                Rebuild();
                ShowScramble();
            }        
        }

        /**
         * 儲存本次練習結果並傳到資料庫(CurrentGradeHolder可視為一次性短時資料暫存器)
         */
        public void SaveScores()
        {
            CurrentGradeHolder cgh = new CurrentGradeHolder();
            DatabaseConnect dc = new DatabaseConnect();

            if (Double.TryParse(L_time.Text, out double temp))
            {
                cgh.inCurrScore(Convert.ToDouble(L_time.Text));
            }
            else
            {
                String[] str = L_time.Text.Split(':');
                temp = int.Parse(str[0]) * 60 + Convert.ToDouble(str[1]);
                cgh.inCurrScore(Convert.ToDouble(temp));
            }

            cgh.inCurrScramble(L_scramble.Text);

            dc.UpdateGradesToDatabase();
        }

        private void B_guide_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            L_scramble.Focus();
        }

        private void B_change_Click(object sender, EventArgs e)
        {
            L_scramble.Text = sc.Generate();
            L_scramble.Location = new Point((Width - L_scramble.Width) / 2, 50);
            Rebuild();
            ShowScramble();
            L_scramble.Focus();
        }

        public void ShowScramble()
        {
            String[] str = L_scramble.Text.Split(' ');
            foreach(string c in str)
            {
                if (c == "U")
                    sc.Turn_U(B_white, B_orange, B_green, B_red, B_blue);
                else if (c == "U'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_U(B_white, B_orange, B_green, B_red, B_blue);
                else if (c == "U2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_U(B_white, B_orange, B_green, B_red, B_blue);
                else if(c == "D")
                    sc.Turn_D(B_yellow, B_orange, B_green, B_red, B_blue);
                else if(c == "D'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_D(B_yellow, B_orange, B_green, B_red, B_blue);
                else if (c == "D2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_D(B_yellow, B_orange, B_green, B_red, B_blue);
                else if(c == "R")
                    sc.Turn_R(B_red, B_green, B_white, B_blue, B_yellow);
                else if (c == "R'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_R(B_red, B_green, B_white, B_blue, B_yellow);
                else if (c == "R2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_R(B_red, B_green, B_white, B_blue, B_yellow);
                else if (c == "L")
                    sc.Turn_L(B_orange, B_green, B_white, B_blue, B_yellow);
                else if (c == "L'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_L(B_orange, B_green, B_white, B_blue, B_yellow);
                else if (c == "L2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_L(B_orange, B_green, B_white, B_blue, B_yellow);
                else if (c == "F")
                    sc.Turn_F(B_green, B_white, B_red, B_yellow, B_orange);
                else if (c == "F'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_F(B_green, B_white, B_red, B_yellow, B_orange);
                else if (c == "F2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_F(B_green, B_white, B_red, B_yellow, B_orange);
                else if (c == "B")
                    sc.Turn_B(B_blue, B_white, B_red, B_yellow, B_orange);
                else if (c == "B'")
                    for (int i = 0; i < 3; i++)
                        sc.Turn_B(B_blue, B_white, B_red, B_yellow, B_orange);
                else if (c == "B2")
                    for (int i = 0; i < 2; i++)
                        sc.Turn_B(B_blue, B_white, B_red, B_yellow, B_orange);
            }
        }

        public void Rebuild()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    B_orange[i, j].BackColor = Color.Orange;
                    B_green[i, j].BackColor = Color.Green;
                    B_red[i, j].BackColor = Color.Red;
                    B_blue[i, j].BackColor = Color.Blue;
                    B_white[i, j].BackColor = Color.White;
                    B_yellow[i, j].BackColor = Color.Yellow;
                }
            }
        }

        private void VisitLink()
        {
            System.Diagnostics.Process.Start("https://cstimer.net/");
        }

        private void B_show_Click(object sender, EventArgs e)
        {
            if(B_show.Text == "show")
            {
                B_show.Text = "hide";
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        B_orange[i, j].Visible = true;
                        B_green[i, j].Visible = true;
                        B_red[i, j].Visible = true;
                        B_blue[i, j].Visible = true;
                        B_white[i, j].Visible = true;
                        B_yellow[i, j].Visible = true;
                    }
                }
            }
            else
            {
                B_show.Text = "show";
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        B_orange[i, j].Visible = false;
                        B_green[i, j].Visible = false;
                        B_red[i, j].Visible = false;
                        B_blue[i, j].Visible = false;
                        B_white[i, j].Visible = false;
                        B_yellow[i, j].Visible = false;
                    }
                }
            }
            L_scramble.Focus();
        }
        //RY1228
        private void RecordHistory()
        {
            if(Double.TryParse(L_time.Text, out grade[index]))
            {
                grade[index] = Convert.ToDouble(L_time.Text);
            }
            else
            {
                String[] str = L_time.Text.Split(':');
                grade[index] = int.Parse(str[0]) * 60 + Convert.ToDouble(str[1]);
            }
            
            T_history.AppendText(grade[index].ToString("0.00") + "\r\n" + L_scramble.Text + "\r\n");
            scramble[index] = L_scramble.Text;
        }

        private void Statistics()
        {
            L_count_num.Text = (index + 1).ToString();

            if (index == 0)
            {
                average = grade[0];
                sum += grade[0];

                best = grade[0];
                L_best_num.Text = best.ToString("0.00");
                worst = grade[0];
                L_worst_num.Text = worst.ToString("0.00");
            }
            else
            {
                sum += grade[index];
                average = sum / (index + 1);    //從0開始算的話 要加1

                if (grade[index] <= best)
                {
                    best = grade[index];
                    L_best_num.Text = best.ToString("0.00");
                }
                if (grade[index] >= worst)
                {
                    worst = grade[index];
                    L_worst_num.Text = worst.ToString("0.00");
                }
            }

            if (index < 4)
            {
                L_ao5_num.Text = "--";
            }
            else
            {
                double temp_sum = 0;
                double temp_best = grade[index];
                double temp_worst = grade[index];

                for (int i=0; i<5; i++)
                {
                    temp_sum += grade[index - i];

                    if (grade[index - i] <= temp_best)
                        temp_best = grade[index - i];
                    if(grade[index - i] >= temp_worst)
                        temp_worst = grade[index - i];
                }

                L_ao5_num.Text = ((temp_sum - temp_best - temp_worst) / 3).ToString("0.00");
            }

            L_avg_num.Text = average.ToString("0.00");
        }

        //RY1228
        private void B_logout_Click(object sender, EventArgs e)
        {
            DatabaseConnect dc = new DatabaseConnect();
            dc.UpdateScoringTimes();

            LoginForm lf = new LoginForm();
            lf.Show();
            this.Hide();
        }                

        private void MingZesYouTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC9zcXnhk3BDrqNf6NjIym9A");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
            L_scramble.Focus();
        }

        private void CstimernetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
            L_scramble.Focus();
        }

        private void VideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://www.worldcubeassociation.org/regulations/translations/chinese-traditional/");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
            L_scramble.Focus();
        }       

        private void ShowHideToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (B_show.Text == "show")
            {
                B_show.Text = "hide";
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        B_orange[i, j].Visible = true;
                        B_green[i, j].Visible = true;
                        B_red[i, j].Visible = true;
                        B_blue[i, j].Visible = true;
                        B_white[i, j].Visible = true;
                        B_yellow[i, j].Visible = true;
                    }
                }
            }
            else
            {
                B_show.Text = "show";
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        B_orange[i, j].Visible = false;
                        B_green[i, j].Visible = false;
                        B_red[i, j].Visible = false;
                        B_blue[i, j].Visible = false;
                        B_white[i, j].Visible = false;
                        B_yellow[i, j].Visible = false;
                    }
                }
            }
            L_scramble.Focus();
        }

        private void ChangeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
            {
                L_average.Font = fnt.Font;
                L_best.Font = fnt.Font;
                L_worst.Font = fnt.Font;
                L_ao5.Font = fnt.Font;
                L_count.Font = fnt.Font;
                L_avg_num.Font = fnt.Font;
                L_best_num.Font = fnt.Font;
                L_worst_num.Font = fnt.Font;
                L_ao5_num.Font = fnt.Font;
                L_count_num.Font = fnt.Font;
                L_scramble.Font = fnt.Font;
                L_scramble.Location = new Point((Width - L_scramble.Width) / 2, 50);
                T_history.Font = fnt.Font;
                groupBox1.Font = fnt.Font;
            }
        }

        private void ForeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            cld.ShowDialog();
            T_history.BackColor = T_history.BackColor;
            T_history.ForeColor = cld.Color;
            groupBox1.ForeColor = cld.Color;
            L_scramble.ForeColor = cld.Color;
        }

        private void BackColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            cld.ShowDialog();
            L_time.BackColor = cld.Color;
            T_history.BackColor = cld.Color;
            groupBox1.BackColor = cld.Color;
            L_scramble.BackColor = cld.Color;
        }

        private void BackColorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();           
            if(cld.ShowDialog() != DialogResult.Cancel)
                this.BackColor = cld.Color;
        }

        private void ForeColorToolStripMenuItem1_Click(object sender, EventArgs e)  //按鈕前景
        {
            ColorDialog cld = new ColorDialog();
            if(cld.ShowDialog() != DialogResult.Cancel)
            {
                B_change.ForeColor = cld.Color;
                B_show.ForeColor = cld.Color;
            }
        }

        private void BackColorToolStripMenuItem1_Click(object sender, EventArgs e)  //按鈕背景
        {
            ColorDialog cld = new ColorDialog();
            if(cld.ShowDialog() != DialogResult.Cancel)
            {
                B_change.BackColor = cld.Color;
                B_show.BackColor = cld.Color;
            }
        }

        private void ButtonFontToolStripMenuItem_Click(object sender, EventArgs e)  //按鈕字型
        {
            FontDialog fnt = new FontDialog();
            if (fnt.ShowDialog() != DialogResult.Cancel)
            {
                B_change.Font = fnt.Font;
                B_show.Font = fnt.Font;
            }
        }

        private void CreditsToolStripMenuItem1_Click(object sender, EventArgs e)    //製作人員
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void VideoToolStripMenuItem1_Click(object sender, EventArgs e)      //影片說明
        {
            try
            {
                // RY,0104 Change Link to introducing video link
                System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC9zcXnhk3BDrqNf6NjIym9A");
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
            L_scramble.Focus();
        }

        private void TextToolStripMenuItem_Click(object sender, EventArgs e)        //文字說明
        {
            Form2 f2 = new Form2();
            f2.Show();
            L_scramble.Focus();
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)      //匯出成績
        {
            if (index == 0)
            {
                MessageBox.Show("目前無任何成績資料！");
                return;
            }

            saveFileDialog1.Filter = "Text File | *.txt";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string filePath = saveFileDialog1.FileName;
                StreamWriter sw = new StreamWriter(filePath);
                sw.WriteLine("count:" + index);

                for(int i=0; i<index; i++)
                {
                    if(grade[i].ToString("0.00") == L_best_num.Text || grade[i].ToString("0.00") == L_worst_num.Text)
                        sw.Write("(" + grade[i].ToString("0.00") + ") " + scramble[i] + "\n");
                    else
                        sw.Write(grade[i].ToString("0.00") + " " + scramble[i] + "\n");
                }

                sw.Close();
            }
        }
    }
}
