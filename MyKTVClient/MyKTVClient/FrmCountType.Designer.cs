﻿namespace MyKTVClient
{
    partial class FrmCountType
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCountType));
            this.pnlShowMain = new System.Windows.Forms.Panel();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlSongList = new System.Windows.Forms.Panel();
            this.pnlServer = new System.Windows.Forms.Panel();
            this.pnlNextSong = new System.Windows.Forms.Panel();
            this.pnlLastSong = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.pnlPause = new System.Windows.Forms.Panel();
            this.lblPause = new System.Windows.Forms.Label();
            this.pnlDel = new System.Windows.Forms.Panel();
            this.pnlFace = new System.Windows.Forms.Panel();
            this.pnlsinger = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNextPlay = new System.Windows.Forms.Label();
            this.lblNowPlay = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlConnPhone = new System.Windows.Forms.Panel();
            this.lblLastPage = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCount1 = new System.Windows.Forms.Panel();
            this.lblCount2 = new System.Windows.Forms.Panel();
            this.lblCount3 = new System.Windows.Forms.Panel();
            this.lblCount6 = new System.Windows.Forms.Panel();
            this.lblCount5 = new System.Windows.Forms.Panel();
            this.lblCount4 = new System.Windows.Forms.Panel();
            this.lblCount9 = new System.Windows.Forms.Panel();
            this.lblCount8 = new System.Windows.Forms.Panel();
            this.lblCount7 = new System.Windows.Forms.Panel();
            this.lvSongList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.qrIP = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl();
            this.timBtnStatic = new System.Windows.Forms.Timer(this.components);
            this.pnlExit.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlPause.SuspendLayout();
            this.pnlsinger.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrIP)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlShowMain
            // 
            this.pnlShowMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlShowMain.Location = new System.Drawing.Point(29, 1);
            this.pnlShowMain.Name = "pnlShowMain";
            this.pnlShowMain.Size = new System.Drawing.Size(57, 91);
            this.pnlShowMain.TabIndex = 16;
            this.pnlShowMain.Click += new System.EventHandler(this.pnlShowMain_Click);
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.Color.Transparent;
            this.pnlExit.Controls.Add(this.label8);
            this.pnlExit.Location = new System.Drawing.Point(878, 1);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(90, 49);
            this.pnlExit.TabIndex = 11;
            this.pnlExit.Click += new System.EventHandler(this.pnlExit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(10, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "结账";
            // 
            // pnlSongList
            // 
            this.pnlSongList.BackColor = System.Drawing.Color.Transparent;
            this.pnlSongList.Location = new System.Drawing.Point(919, 0);
            this.pnlSongList.Name = "pnlSongList";
            this.pnlSongList.Size = new System.Drawing.Size(57, 92);
            this.pnlSongList.TabIndex = 12;
            this.pnlSongList.Click += new System.EventHandler(this.pnlSongList_Click);
            // 
            // pnlServer
            // 
            this.pnlServer.BackColor = System.Drawing.Color.Transparent;
            this.pnlServer.Location = new System.Drawing.Point(118, 0);
            this.pnlServer.Name = "pnlServer";
            this.pnlServer.Size = new System.Drawing.Size(57, 92);
            this.pnlServer.TabIndex = 15;
            this.pnlServer.Click += new System.EventHandler(this.pnlServer_Click);
            // 
            // pnlNextSong
            // 
            this.pnlNextSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlNextSong.Location = new System.Drawing.Point(199, 1);
            this.pnlNextSong.Name = "pnlNextSong";
            this.pnlNextSong.Size = new System.Drawing.Size(57, 91);
            this.pnlNextSong.TabIndex = 13;
            this.pnlNextSong.Click += new System.EventHandler(this.pnlNextSong_Click);
            // 
            // pnlLastSong
            // 
            this.pnlLastSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlLastSong.Location = new System.Drawing.Point(832, 588);
            this.pnlLastSong.Name = "pnlLastSong";
            this.pnlLastSong.Size = new System.Drawing.Size(57, 91);
            this.pnlLastSong.TabIndex = 14;
            this.pnlLastSong.Click += new System.EventHandler(this.pnlLastSong_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Controls.Add(this.pnlAdd);
            this.pnlBottom.Controls.Add(this.pnlPause);
            this.pnlBottom.Controls.Add(this.pnlDel);
            this.pnlBottom.Controls.Add(this.pnlFace);
            this.pnlBottom.Controls.Add(this.pnlsinger);
            this.pnlBottom.Controls.Add(this.label10);
            this.pnlBottom.Controls.Add(this.label9);
            this.pnlBottom.Controls.Add(this.label2);
            this.pnlBottom.Controls.Add(this.pnlShowMain);
            this.pnlBottom.Controls.Add(this.pnlSongList);
            this.pnlBottom.Controls.Add(this.pnlServer);
            this.pnlBottom.Controls.Add(this.pnlNextSong);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 587);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1092, 92);
            this.pnlBottom.TabIndex = 26;
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdd.Location = new System.Drawing.Point(379, 1);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(57, 91);
            this.pnlAdd.TabIndex = 14;
            this.pnlAdd.Click += new System.EventHandler(this.pnlAdd_Click);
            // 
            // pnlPause
            // 
            this.pnlPause.BackColor = System.Drawing.Color.Transparent;
            this.pnlPause.Controls.Add(this.lblPause);
            this.pnlPause.Location = new System.Drawing.Point(284, 1);
            this.pnlPause.Name = "pnlPause";
            this.pnlPause.Size = new System.Drawing.Size(57, 91);
            this.pnlPause.TabIndex = 56;
            this.pnlPause.Click += new System.EventHandler(this.pnlPause_Click);
            // 
            // lblPause
            // 
            this.lblPause.BackColor = System.Drawing.Color.Black;
            this.lblPause.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.lblPause.ForeColor = System.Drawing.Color.White;
            this.lblPause.Location = new System.Drawing.Point(5, 59);
            this.lblPause.Name = "lblPause";
            this.lblPause.Size = new System.Drawing.Size(51, 24);
            this.lblPause.TabIndex = 0;
            this.lblPause.Text = "暂停";
            // 
            // pnlDel
            // 
            this.pnlDel.BackColor = System.Drawing.Color.Transparent;
            this.pnlDel.Location = new System.Drawing.Point(662, 1);
            this.pnlDel.Name = "pnlDel";
            this.pnlDel.Size = new System.Drawing.Size(57, 91);
            this.pnlDel.TabIndex = 15;
            this.pnlDel.Click += new System.EventHandler(this.pnlDel_Click);
            // 
            // pnlFace
            // 
            this.pnlFace.BackColor = System.Drawing.Color.Transparent;
            this.pnlFace.Location = new System.Drawing.Point(1011, 0);
            this.pnlFace.Name = "pnlFace";
            this.pnlFace.Size = new System.Drawing.Size(57, 92);
            this.pnlFace.TabIndex = 25;
            this.pnlFace.Click += new System.EventHandler(this.pnlFace_Click);
            // 
            // pnlsinger
            // 
            this.pnlsinger.BackColor = System.Drawing.Color.Transparent;
            this.pnlsinger.Controls.Add(this.label3);
            this.pnlsinger.Location = new System.Drawing.Point(744, 1);
            this.pnlsinger.Name = "pnlsinger";
            this.pnlsinger.Size = new System.Drawing.Size(57, 91);
            this.pnlsinger.TabIndex = 21;
            this.pnlsinger.Click += new System.EventHandler(this.pnlsinger_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "原唱";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(974, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "气氛";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(895, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "灯光";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(97, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "音量";
            // 
            // lblNextPlay
            // 
            this.lblNextPlay.AutoSize = true;
            this.lblNextPlay.Font = new System.Drawing.Font("宋体", 16F);
            this.lblNextPlay.ForeColor = System.Drawing.Color.White;
            this.lblNextPlay.Location = new System.Drawing.Point(473, 15);
            this.lblNextPlay.Name = "lblNextPlay";
            this.lblNextPlay.Size = new System.Drawing.Size(142, 22);
            this.lblNextPlay.TabIndex = 1;
            this.lblNextPlay.Text = "您还没有点歌";
            // 
            // lblNowPlay
            // 
            this.lblNowPlay.AutoSize = true;
            this.lblNowPlay.Font = new System.Drawing.Font("宋体", 16F);
            this.lblNowPlay.ForeColor = System.Drawing.Color.White;
            this.lblNowPlay.Location = new System.Drawing.Point(149, 15);
            this.lblNowPlay.Name = "lblNowPlay";
            this.lblNowPlay.Size = new System.Drawing.Size(142, 22);
            this.lblNowPlay.TabIndex = 0;
            this.lblNowPlay.Text = "您还没有点歌";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.Controls.Add(this.pnlConnPhone);
            this.pnlTop.Controls.Add(this.lblLastPage);
            this.pnlTop.Controls.Add(this.lblNextPlay);
            this.pnlTop.Controls.Add(this.lblNowPlay);
            this.pnlTop.Controls.Add(this.pnlExit);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1092, 65);
            this.pnlTop.TabIndex = 25;
            // 
            // pnlConnPhone
            // 
            this.pnlConnPhone.Location = new System.Drawing.Point(753, 1);
            this.pnlConnPhone.Name = "pnlConnPhone";
            this.pnlConnPhone.Size = new System.Drawing.Size(119, 49);
            this.pnlConnPhone.TabIndex = 12;
            this.pnlConnPhone.Click += new System.EventHandler(this.pnlConnPhone_Click);
            // 
            // lblLastPage
            // 
            this.lblLastPage.Location = new System.Drawing.Point(984, 1);
            this.lblLastPage.Name = "lblLastPage";
            this.lblLastPage.Size = new System.Drawing.Size(89, 49);
            this.lblLastPage.TabIndex = 2;
            this.lblLastPage.Click += new System.EventHandler(this.lblLastPage_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(871, 461);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 125);
            this.panel2.TabIndex = 47;
            this.panel2.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(115, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 119);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 119);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCount1
            // 
            this.lblCount1.BackColor = System.Drawing.Color.Transparent;
            this.lblCount1.Location = new System.Drawing.Point(815, 115);
            this.lblCount1.Name = "lblCount1";
            this.lblCount1.Size = new System.Drawing.Size(62, 73);
            this.lblCount1.TabIndex = 48;
            this.lblCount1.Click += new System.EventHandler(this.lblCount1_Click);
            // 
            // lblCount2
            // 
            this.lblCount2.BackColor = System.Drawing.Color.Transparent;
            this.lblCount2.Location = new System.Drawing.Point(893, 115);
            this.lblCount2.Name = "lblCount2";
            this.lblCount2.Size = new System.Drawing.Size(62, 73);
            this.lblCount2.TabIndex = 49;
            this.lblCount2.Click += new System.EventHandler(this.lblCount2_Click);
            // 
            // lblCount3
            // 
            this.lblCount3.BackColor = System.Drawing.Color.Transparent;
            this.lblCount3.Location = new System.Drawing.Point(981, 115);
            this.lblCount3.Name = "lblCount3";
            this.lblCount3.Size = new System.Drawing.Size(62, 73);
            this.lblCount3.TabIndex = 50;
            this.lblCount3.Click += new System.EventHandler(this.lblCount3_Click);
            // 
            // lblCount6
            // 
            this.lblCount6.BackColor = System.Drawing.Color.Transparent;
            this.lblCount6.Location = new System.Drawing.Point(986, 236);
            this.lblCount6.Name = "lblCount6";
            this.lblCount6.Size = new System.Drawing.Size(62, 73);
            this.lblCount6.TabIndex = 53;
            this.lblCount6.Click += new System.EventHandler(this.lblCount6_Click);
            // 
            // lblCount5
            // 
            this.lblCount5.BackColor = System.Drawing.Color.Transparent;
            this.lblCount5.Location = new System.Drawing.Point(901, 236);
            this.lblCount5.Name = "lblCount5";
            this.lblCount5.Size = new System.Drawing.Size(62, 73);
            this.lblCount5.TabIndex = 52;
            this.lblCount5.Click += new System.EventHandler(this.lblCount5_Click);
            // 
            // lblCount4
            // 
            this.lblCount4.BackColor = System.Drawing.Color.Transparent;
            this.lblCount4.Location = new System.Drawing.Point(815, 236);
            this.lblCount4.Name = "lblCount4";
            this.lblCount4.Size = new System.Drawing.Size(62, 73);
            this.lblCount4.TabIndex = 51;
            this.lblCount4.Click += new System.EventHandler(this.lblCount4_Click);
            // 
            // lblCount9
            // 
            this.lblCount9.BackColor = System.Drawing.Color.Transparent;
            this.lblCount9.Location = new System.Drawing.Point(985, 346);
            this.lblCount9.Name = "lblCount9";
            this.lblCount9.Size = new System.Drawing.Size(62, 73);
            this.lblCount9.TabIndex = 53;
            this.lblCount9.Click += new System.EventHandler(this.lblCount9_Click);
            // 
            // lblCount8
            // 
            this.lblCount8.BackColor = System.Drawing.Color.Transparent;
            this.lblCount8.Location = new System.Drawing.Point(896, 346);
            this.lblCount8.Name = "lblCount8";
            this.lblCount8.Size = new System.Drawing.Size(62, 73);
            this.lblCount8.TabIndex = 52;
            this.lblCount8.Click += new System.EventHandler(this.lblCount8_Click);
            // 
            // lblCount7
            // 
            this.lblCount7.BackColor = System.Drawing.Color.Transparent;
            this.lblCount7.Location = new System.Drawing.Point(817, 346);
            this.lblCount7.Name = "lblCount7";
            this.lblCount7.Size = new System.Drawing.Size(62, 73);
            this.lblCount7.TabIndex = 51;
            this.lblCount7.Click += new System.EventHandler(this.lblCount7_Click);
            // 
            // lvSongList
            // 
            this.lvSongList.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvSongList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvSongList.BackgroundImage")));
            this.lvSongList.BackgroundImageTiled = true;
            this.lvSongList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSongList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvSongList.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvSongList.ForeColor = System.Drawing.Color.White;
            this.lvSongList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSongList.Location = new System.Drawing.Point(0, 66);
            this.lvSongList.Name = "lvSongList";
            this.lvSongList.Size = new System.Drawing.Size(694, 520);
            this.lvSongList.TabIndex = 54;
            this.lvSongList.UseCompatibleStateImageBehavior = false;
            this.lvSongList.View = System.Windows.Forms.View.Details;
            this.lvSongList.Click += new System.EventHandler(this.lvSongList_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 400;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 240;
            // 
            // qrIP
            // 
            this.qrIP.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qrIP.Image = ((System.Drawing.Image)(resources.GetObject("qrIP.Image")));
            this.qrIP.Location = new System.Drawing.Point(739, 56);
            this.qrIP.Name = "qrIP";
            this.qrIP.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.qrIP.Size = new System.Drawing.Size(150, 150);
            this.qrIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrIP.TabIndex = 55;
            this.qrIP.TabStop = false;
            this.qrIP.Text = "192.168.124.1:8998";
            this.qrIP.Visible = false;
            // 
            // timBtnStatic
            // 
            this.timBtnStatic.Enabled = true;
            this.timBtnStatic.Tick += new System.EventHandler(this.timBtnStatic_Tick);
            // 
            // FrmCountType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1092, 679);
            this.Controls.Add(this.qrIP);
            this.Controls.Add(this.lvSongList);
            this.Controls.Add(this.lblCount9);
            this.Controls.Add(this.lblCount6);
            this.Controls.Add(this.lblCount8);
            this.Controls.Add(this.lblCount3);
            this.Controls.Add(this.lblCount7);
            this.Controls.Add(this.lblCount5);
            this.Controls.Add(this.lblCount2);
            this.Controls.Add(this.lblCount4);
            this.Controls.Add(this.lblCount1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlLastSong);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCountType";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCountType";
            this.Load += new System.EventHandler(this.FrmCountType_Load);
            this.pnlExit.ResumeLayout(false);
            this.pnlExit.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlPause.ResumeLayout(false);
            this.pnlsinger.ResumeLayout(false);
            this.pnlsinger.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrIP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlShowMain;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.Panel pnlSongList;
        private System.Windows.Forms.Panel pnlServer;
        private System.Windows.Forms.Panel pnlNextSong;
        private System.Windows.Forms.Panel pnlLastSong;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblNextPlay;
        private System.Windows.Forms.Label lblNowPlay;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlsinger;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlFace;
        private System.Windows.Forms.Panel lblLastPage;
        private System.Windows.Forms.Panel lblCount1;
        private System.Windows.Forms.Panel lblCount2;
        private System.Windows.Forms.Panel lblCount3;
        private System.Windows.Forms.Panel lblCount6;
        private System.Windows.Forms.Panel lblCount5;
        private System.Windows.Forms.Panel lblCount4;
        private System.Windows.Forms.Panel lblCount9;
        private System.Windows.Forms.Panel lblCount8;
        private System.Windows.Forms.Panel lblCount7;
        private System.Windows.Forms.ListView lvSongList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Panel pnlDel;
        private System.Windows.Forms.Panel pnlConnPhone;
        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl qrIP;
        private System.Windows.Forms.Label lblPause;
        private System.Windows.Forms.Panel pnlPause;
        private System.Windows.Forms.Timer timBtnStatic;
    }
}