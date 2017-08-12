using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;
using AxAPlayer3Lib;

namespace 视频播放器
{
    public partial class MyPlayer : Form
    {
        WebClient web = new WebClient();
        string titlename = "";
        public MyPlayer()
        {
            InitializeComponent();
        }
        private void MyPlayer_Load(object sender, EventArgs e)
        {
            axPlayer1.SetVolume(100);
            axPlayer1.SetCustomLogo(-1);

            soundsize.Size = new Size(100, 5);
            sound.Text = axPlayer1.GetVolume().ToString();
            pictureBox2.Location = new Point(setSound.Location.X + soundsize.Size.Width - pictureBox2.Width, setSound.Location.Y - 5);
        }

        private void OpenFile()
        {
            // axPlayer1.Open(@"G:\BaiduYunDownload\2016javascript+jquery视频\02-jQuery（3天）\day2\123基本选择器.avi");
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "视频文件|*.mp4;*.avi;*.rm;*.rmvb;*.flv;*.xr;*.wmv|所有文件|*.*";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        titlename = ofd.FileName;
                        axPlayer1.Open(titlename);
                        string[] fileName = titlename.Split('\\');
                        title.Text = fileName[fileName.Length-1];
                        play.Image = Properties.Resources.pause;
                        timerun.Enabled = true;
                        timer1.Enabled = true;
                    }
                    catch { MessageBox.Show("视频格式错误！"); }
                }
            }
        }
        public string SetTime(int t)
        {
            TimeSpan times = TimeSpan.FromMilliseconds(t);
            return times.Hours.ToString("00") + ":" +
            times.Minutes.ToString("00") + ":" +
            times.Seconds.ToString("00");
        }
        #region 按钮变化
        private void picclose_MouseMove(object sender, MouseEventArgs e)
        {
            picclose.Image = Properties.Resources.close_move;
        }

        private void picclose_MouseLeave(object sender, EventArgs e)
        {
            picclose.Image = Properties.Resources.close;
        }

        private void picclose_MouseDown(object sender, MouseEventArgs e)
        {
            picclose.Image = Properties.Resources.close;
        }

        private void play_MouseMove(object sender, MouseEventArgs e)
        {
            if (axPlayer1.GetState() == 3)
            {
                play.Image = Properties.Resources.play_move;
            }
            else if (axPlayer1.GetState() == 5)
            {
                play.Image = Properties.Resources.pause_move;
            }
            else
            {
                play.Image = Properties.Resources.play_move;
            }

        }

        private void play_MouseLeave(object sender, EventArgs e)
        {
            if (axPlayer1.GetState() == 3)
            {
                play.Image = Properties.Resources.play;
            }
            else if (axPlayer1.GetState() == 5)
            {
                play.Image = Properties.Resources.pause;
            }
            else
            {
                play.Image = Properties.Resources.play;
            }

        }

        private void play_MouseDown(object sender, MouseEventArgs e)
        {
            if (axPlayer1.GetState() == 3)
            {
                play.Image = Properties.Resources.play_down;
            }
            else if (axPlayer1.GetState() == 5)
            {
                play.Image = Properties.Resources.pause_down;
            }
            else
            {
                play.Image = Properties.Resources.play_down;
            }

        }

        private void stop_MouseMove(object sender, MouseEventArgs e)
        {
            stop.Image = Properties.Resources.stop_move;
        }

        private void stop_MouseLeave(object sender, EventArgs e)
        {
            stop.Image = Properties.Resources.stop;
        }

        private void stop_MouseDown(object sender, MouseEventArgs e)
        {
            stop.Image = Properties.Resources.stop;
        }

        private void sounds_MouseMove(object sender, MouseEventArgs e)
        {
            sounds.Image = Properties.Resources.sound_move;
        }

        private void sounds_MouseLeave(object sender, EventArgs e)
        {
            sounds.Image = Properties.Resources.sound;
        }

        private void sounds_MouseDown(object sender, MouseEventArgs e)
        {
            sounds.Image = Properties.Resources.sound_down;
        }
        private void max_MouseMove(object sender, MouseEventArgs e)
        {
            max.Image = Properties.Resources.max_move;
        }

        private void max_MouseLeave(object sender, EventArgs e)
        {
            max.Image = Properties.Resources.max;
        }

        private void max_MouseDown(object sender, MouseEventArgs e)
        {
            max.Image = Properties.Resources.max_down;
        }

        private void open_MouseMove(object sender, MouseEventArgs e)
        {
            open.Image = Properties.Resources.open_move;
        }

        private void open_MouseLeave(object sender, EventArgs e)
        {
            open.Image = Properties.Resources.open;
        }

        private void open_MouseDown(object sender, MouseEventArgs e)
        {
            open.Image = Properties.Resources.open_down;
        }

        private void list_MouseMove(object sender, MouseEventArgs e)
        {
            list.Image = Properties.Resources.list_move;
        }

        private void list_MouseLeave(object sender, EventArgs e)
        {
            list.Image = Properties.Resources.list;
        }

        private void list_MouseDown(object sender, MouseEventArgs e)
        {
            list.Image = Properties.Resources.list_down;
        }
        private void timerun_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            pictureBox1.Visible = true;
            pictureBox1.Location = new Point(panel2.Width + timerun.Location.X - 6, timerun.Location.Y - 3);
        }

        private void progess_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            pictureBox1.Visible = true;
            pictureBox1.Location = new Point(panel2.Width + timerun.Location.X -6, timerun.Location.Y - 3);
        }
        

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            pictureBox1.Visible = false;
        }
        private void timerun_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            pictureBox1.Visible = false;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            pictureBox1.Visible = false;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
            pictureBox1.Visible = true;
            pictureBox1.Location = new Point(panel2.Width + timerun.Location.X - 6, timerun.Location.Y - 3);
        }
        #endregion
        #region 拖动移动窗体
        private Point offset;//当前窗口坐标
        public void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = this.PointToScreen(e.Location);
            offset = new Point(cur.X - this.Left + title.Location.X, cur.Y - this.Top);
        }
        public void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;

            Point cur = MousePosition;
            this.Location = new Point(cur.X - offset.X, cur.Y - offset.Y);
        }
        #endregion

        private void open_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (axPlayer1.GetState() == 5)  //播放-暂停
            {
                axPlayer1.Pause();
                play.Image = Properties.Resources.pause;
                timer1.Enabled = false;
            }
            else
            {
                axPlayer1.Play();
                play.Image = Properties.Resources.play;
                timer1.Enabled = true;
            }
        }
        #region 播放时间
        int panleX;
        //获取当前进度
        double alltime;//全部时间
        double thistime;//当前时间
        double bfb;//百分比
        double thisX;
        //改变进度条长度
        double b;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axPlayer1.GetState() == 0) {
                play.Image = Properties.Resources.play;
                title.Text = "未找到播放文件";
                timerun.Enabled = false;
                timer1.Enabled = false;
            }
            time.Text = SetTime(axPlayer1.GetDuration());
            runtime.Text = SetTime(axPlayer1.GetPosition());
            getTime();

        }
        public void changeTime(double runingTime)
        {
            try
            {
                b = runingTime / 728;
                thistime = alltime * b;
                axPlayer1.SetPosition(Convert.ToInt32(thistime));
            }
            catch { }
        }
        public void getTime()
        {
            thistime = axPlayer1.GetPosition();
            alltime = axPlayer1.GetDuration();
            bfb = thistime / alltime;
            thisX = 728 * bfb;
            panel2.Size = new Size((int)thisX, 5);
            progess.Location = new Point((int)thisX, 0);
        }
        private void timerun_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            panel2.Size = new Size(e.Location.X, 5);
            panleX = e.Location.X;
            changeTime(panleX);
            progess.Location = pictureBox1.Location;
        }

        private void progess_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            panel2.Size = new Size(e.Location.X, 5);
            panleX = e.Location.X + progess.Location.X;
            changeTime(panleX);
            pictureBox1.Location = new Point(panel2.Size.Width + timerun.Location.X - 6, timerun.Location.Y - 3);
            progess.Location = pictureBox1.Location;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            panel2.Size = new Size(e.Location.X, 5);
            panleX = e.Location.X;
            changeTime(panleX);
            pictureBox1.Location = new Point(panel2.Size.Width + timerun.Location.X - 6, timerun.Location.Y - 3);
            progess.Location = pictureBox1.Location;
        }



        private void timerun_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            panel2.Size = new Size(e.Location.X, 5);
            panleX = e.Location.X;
            changeTime(panleX);
            pictureBox1.Location = new Point(panel2.Size.Width + timerun.Location.X - 6, timerun.Location.Y - 3);
            progess.Location = pictureBox1.Location;

        }
        #endregion
        #region SetVoice
        int voices;//音量
        public void setVoice(int voice)
        {
            axPlayer1.SetVolume(voice);
        }
        public void SetVoice(int local)
        {
            voices = local ;
            if (voices > 100) return;
            setVoice(voices);
            soundsize.Size = new Size(voices, 5);
            sound.Text = axPlayer1.GetVolume().ToString();
            pictureBox2.Location = new Point(setSound.Location.X + soundsize.Size.Width -pictureBox2.Width, setSound.Location.Y - 5);
        }
        private void setSound_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void setSound_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void setSound_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            SetVoice(e.Location.X);
        }

        private void setSound_MouseDown(object sender, MouseEventArgs e)
        {
            SetVoice(e.Location.X);
        }

        private void soundsize_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void soundsize_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void soundsize_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            SetVoice(e.Location.X);
        }

        private void soundsize_MouseDown(object sender, MouseEventArgs e)
        {
            SetVoice(e.Location.X);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons.Left != e.Button) return;
            SetVoice(e.Location.X+soundsize.Width);
        }
        #endregion

        private void stop_Click(object sender, EventArgs e)
        {
            axPlayer1.Close();
            reSet();
        }
        /// <summary>
        /// 初始化
        /// </summary>
        public void reSet()
        {
            play.Image = Properties.Resources.play;
            timerun.Enabled = false;
            timer1.Enabled = false;
            time.Text = runtime.Text = "00:00:00";
            panel2.Size = new Size(0, 0);
            progess.Location = new Point(-17, 0);
            title.Text = "播放列表为空";
        }
    }
}
