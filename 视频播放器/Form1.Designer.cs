namespace 视频播放器
{
    partial class MyPlayer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPlayer));
            this.axPlayer1 = new AxAPlayer3Lib.AxPlayer();
            this.timerun = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progess = new System.Windows.Forms.PictureBox();
            this.bottom = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.setSound = new System.Windows.Forms.Panel();
            this.soundsize = new System.Windows.Forms.Panel();
            this.list = new System.Windows.Forms.PictureBox();
            this.open = new System.Windows.Forms.PictureBox();
            this.sounds = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.PictureBox();
            this.time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.runtime = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.PictureBox();
            this.top = new System.Windows.Forms.Panel();
            this.max = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.picclose = new System.Windows.Forms.PictureBox();
            this.sound = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).BeginInit();
            this.timerun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progess)).BeginInit();
            this.bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.setSound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.open)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            this.top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).BeginInit();
            this.SuspendLayout();
            // 
            // axPlayer1
            // 
            this.axPlayer1.Enabled = true;
            this.axPlayer1.Location = new System.Drawing.Point(0, 23);
            this.axPlayer1.Name = "axPlayer1";
            this.axPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPlayer1.OcxState")));
            this.axPlayer1.Size = new System.Drawing.Size(787, 440);
            this.axPlayer1.TabIndex = 0;
            // 
            // timerun
            // 
            this.timerun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.timerun.Controls.Add(this.progess);
            this.timerun.Controls.Add(this.panel2);
            this.timerun.Enabled = false;
            this.timerun.Location = new System.Drawing.Point(39, 582);
            this.timerun.Name = "timerun";
            this.timerun.Size = new System.Drawing.Size(972, 5);
            this.timerun.TabIndex = 5;
            this.timerun.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timerun_MouseDown);
            this.timerun.MouseEnter += new System.EventHandler(this.timerun_MouseEnter);
            this.timerun.MouseLeave += new System.EventHandler(this.timerun_MouseLeave);
            this.timerun.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timerun_MouseMove);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(73)))), ((int)(((byte)(144)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 5);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::视频播放器.Properties.Resources.progress_move;
            this.pictureBox1.Location = new System.Drawing.Point(18, 577);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 12);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.progess_MouseMove);
            // 
            // progess
            // 
            this.progess.Image = global::视频播放器.Properties.Resources.progress;
            this.progess.Location = new System.Drawing.Point(-17, 0);
            this.progess.Name = "progess";
            this.progess.Size = new System.Drawing.Size(10, 5);
            this.progess.TabIndex = 6;
            this.progess.TabStop = false;
            this.progess.MouseEnter += new System.EventHandler(this.progess_MouseEnter);
            this.progess.MouseMove += new System.Windows.Forms.MouseEventHandler(this.progess_MouseMove);
            // 
            // bottom
            // 
            this.bottom.BackColor = System.Drawing.Color.Transparent;
            this.bottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottom.BackgroundImage")));
            this.bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bottom.Controls.Add(this.pictureBox2);
            this.bottom.Controls.Add(this.setSound);
            this.bottom.Controls.Add(this.list);
            this.bottom.Controls.Add(this.open);
            this.bottom.Controls.Add(this.sounds);
            this.bottom.Controls.Add(this.stop);
            this.bottom.Controls.Add(this.time);
            this.bottom.Controls.Add(this.label1);
            this.bottom.Controls.Add(this.runtime);
            this.bottom.Controls.Add(this.play);
            this.bottom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.bottom.Location = new System.Drawing.Point(0, 593);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(1050, 65);
            this.bottom.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::视频播放器.Properties.Resources.sound_progess;
            this.pictureBox2.Location = new System.Drawing.Point(683, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            // 
            // setSound
            // 
            this.setSound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(121)))));
            this.setSound.Controls.Add(this.soundsize);
            this.setSound.Location = new System.Drawing.Point(646, 33);
            this.setSound.Name = "setSound";
            this.setSound.Size = new System.Drawing.Size(118, 4);
            this.setSound.TabIndex = 8;
            this.setSound.MouseDown += new System.Windows.Forms.MouseEventHandler(this.setSound_MouseDown);
            this.setSound.MouseEnter += new System.EventHandler(this.setSound_MouseEnter);
            this.setSound.MouseLeave += new System.EventHandler(this.setSound_MouseLeave);
            this.setSound.MouseMove += new System.Windows.Forms.MouseEventHandler(this.setSound_MouseMove);
            // 
            // soundsize
            // 
            this.soundsize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(151)))), ((int)(((byte)(109)))));
            this.soundsize.Location = new System.Drawing.Point(0, 0);
            this.soundsize.Name = "soundsize";
            this.soundsize.Size = new System.Drawing.Size(47, 6);
            this.soundsize.TabIndex = 0;
            this.soundsize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.soundsize_MouseDown);
            this.soundsize.MouseEnter += new System.EventHandler(this.soundsize_MouseEnter);
            this.soundsize.MouseLeave += new System.EventHandler(this.soundsize_MouseLeave);
            this.soundsize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.soundsize_MouseMove);
            // 
            // list
            // 
            this.list.BackColor = System.Drawing.Color.Transparent;
            this.list.Image = global::视频播放器.Properties.Resources.list;
            this.list.Location = new System.Drawing.Point(993, 17);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(30, 30);
            this.list.TabIndex = 7;
            this.list.TabStop = false;
            this.list.MouseDown += new System.Windows.Forms.MouseEventHandler(this.list_MouseDown);
            this.list.MouseLeave += new System.EventHandler(this.list_MouseLeave);
            this.list.MouseMove += new System.Windows.Forms.MouseEventHandler(this.list_MouseMove);
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.Transparent;
            this.open.Image = global::视频播放器.Properties.Resources.open;
            this.open.Location = new System.Drawing.Point(961, 17);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(30, 30);
            this.open.TabIndex = 6;
            this.open.TabStop = false;
            this.open.Click += new System.EventHandler(this.open_Click);
            this.open.MouseDown += new System.Windows.Forms.MouseEventHandler(this.open_MouseDown);
            this.open.MouseLeave += new System.EventHandler(this.open_MouseLeave);
            this.open.MouseMove += new System.Windows.Forms.MouseEventHandler(this.open_MouseMove);
            // 
            // sounds
            // 
            this.sounds.BackColor = System.Drawing.Color.Transparent;
            this.sounds.Image = ((System.Drawing.Image)(resources.GetObject("sounds.Image")));
            this.sounds.Location = new System.Drawing.Point(599, 14);
            this.sounds.Name = "sounds";
            this.sounds.Size = new System.Drawing.Size(40, 38);
            this.sounds.TabIndex = 5;
            this.sounds.TabStop = false;
            this.sounds.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sounds_MouseDown);
            this.sounds.MouseLeave += new System.EventHandler(this.sounds_MouseLeave);
            this.sounds.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sounds_MouseMove);
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.Transparent;
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.Location = new System.Drawing.Point(412, 14);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(40, 38);
            this.stop.TabIndex = 4;
            this.stop.TabStop = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            this.stop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stop_MouseDown);
            this.stop.MouseLeave += new System.EventHandler(this.stop_MouseLeave);
            this.stop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.stop_MouseMove);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(112, 22);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(71, 15);
            this.time.TabIndex = 3;
            this.time.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "/";
            // 
            // runtime
            // 
            this.runtime.AutoSize = true;
            this.runtime.BackColor = System.Drawing.Color.Transparent;
            this.runtime.ForeColor = System.Drawing.Color.White;
            this.runtime.Location = new System.Drawing.Point(12, 22);
            this.runtime.Name = "runtime";
            this.runtime.Size = new System.Drawing.Size(71, 15);
            this.runtime.TabIndex = 1;
            this.runtime.Text = "00:00:00";
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.Image = global::视频播放器.Properties.Resources.play;
            this.play.Location = new System.Drawing.Point(490, 14);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(71, 38);
            this.play.TabIndex = 0;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            this.play.MouseDown += new System.Windows.Forms.MouseEventHandler(this.play_MouseDown);
            this.play.MouseLeave += new System.EventHandler(this.play_MouseLeave);
            this.play.MouseMove += new System.Windows.Forms.MouseEventHandler(this.play_MouseMove);
            // 
            // top
            // 
            this.top.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("top.BackgroundImage")));
            this.top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top.Controls.Add(this.max);
            this.top.Controls.Add(this.title);
            this.top.Controls.Add(this.name);
            this.top.Controls.Add(this.picclose);
            this.top.Location = new System.Drawing.Point(0, 0);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1050, 30);
            this.top.TabIndex = 1;
            // 
            // max
            // 
            this.max.BackColor = System.Drawing.Color.Transparent;
            this.max.Dock = System.Windows.Forms.DockStyle.Right;
            this.max.ErrorImage = null;
            this.max.Image = global::视频播放器.Properties.Resources.max;
            this.max.Location = new System.Drawing.Point(972, 0);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(30, 30);
            this.max.TabIndex = 7;
            this.max.TabStop = false;
            this.max.MouseDown += new System.Windows.Forms.MouseEventHandler(this.max_MouseDown);
            this.max.MouseLeave += new System.EventHandler(this.max_MouseLeave);
            this.max.MouseMove += new System.Windows.Forms.MouseEventHandler(this.max_MouseMove);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(115, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(853, 30);
            this.title.TabIndex = 6;
            this.title.Text = "播放列表为空";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(27, 7);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(82, 15);
            this.name.TabIndex = 1;
            this.name.Text = "视频播放器";
            // 
            // picclose
            // 
            this.picclose.BackColor = System.Drawing.Color.Transparent;
            this.picclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.picclose.ErrorImage = null;
            this.picclose.Image = ((System.Drawing.Image)(resources.GetObject("picclose.Image")));
            this.picclose.Location = new System.Drawing.Point(1002, 0);
            this.picclose.Name = "picclose";
            this.picclose.Size = new System.Drawing.Size(48, 30);
            this.picclose.TabIndex = 0;
            this.picclose.TabStop = false;
            this.picclose.Click += new System.EventHandler(this.picclose_Click);
            this.picclose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picclose_MouseDown);
            this.picclose.MouseLeave += new System.EventHandler(this.picclose_MouseLeave);
            this.picclose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picclose_MouseMove);
            // 
            // sound
            // 
            this.sound.AutoSize = true;
            this.sound.ForeColor = System.Drawing.Color.Transparent;
            this.sound.Location = new System.Drawing.Point(12, 49);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(47, 15);
            this.sound.TabIndex = 10;
            this.sound.Text = "sound";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(843, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 543);
            this.panel1.TabIndex = 11;
            this.panel1.Visible = false;
            // 
            // MyPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1050, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sound);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timerun);
            this.Controls.Add(this.bottom);
            this.Controls.Add(this.top);
            this.Controls.Add(this.axPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MyPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axPlayer1)).EndInit();
            this.timerun.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progess)).EndInit();
            this.bottom.ResumeLayout(false);
            this.bottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.setSound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.open)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            this.top.ResumeLayout(false);
            this.top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picclose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAPlayer3Lib.AxPlayer axPlayer1;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Panel bottom;
        private System.Windows.Forms.PictureBox picclose;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox stop;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label runtime;
        private System.Windows.Forms.PictureBox sounds;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox max;
        private System.Windows.Forms.PictureBox open;
        private System.Windows.Forms.PictureBox list;
        private System.Windows.Forms.Panel timerun;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox progess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel setSound;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel soundsize;
        private System.Windows.Forms.Label sound;
        private System.Windows.Forms.Panel panel1;
    }
}

