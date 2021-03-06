﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MyKTVClient.BLL;
using MyKTVClient.Model;

namespace MyKTVClient
{
    public partial class FrmMain : Form
    {
        #region 加载
        RoomManage roommanage = new RoomManage();
        public static PhoneConnTool phone = null;
        public static int roomId = 223;//房间编号
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 房间状态
        /// </summary>
        public void RoomState()
        {
            bool state = roommanage.GetRoomState(roomId);
            if (!state)
            {
                MessageBox.Show("包厢没有开启，请联系服务员", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        /// <summary>
        /// 加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblNowPlay_Load(object sender, EventArgs e)
        {
            RoomState();
        }
        #endregion
        #region 点歌
        /// <summary>
        /// 类型点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTypeSearch_Click(object sender, EventArgs e)
        {
            FrmSongType frmsonglist = new FrmSongType();
            FrmSongType.play = FrmMain.play;
            FrmSongType.phone = FrmMain.phone;
            frmsonglist.Show();
        }
        /// <summary>
        /// 字数点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlCountSearch_Click(object sender, EventArgs e)
        {
            FrmCountType frmcounttype = new FrmCountType();
            FrmCountType.play = FrmMain.play;
            FrmCountType.phone = FrmMain.phone;
            frmcounttype.Show();
        }
        /// <summary>
        /// 拼音点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlSpellSearch_Click(object sender, EventArgs e)
        {
            FrmSpell frmsonglist = new FrmSpell();
            frmsonglist.SearchType = "拼音";
            FrmSpell.play = FrmMain.play;
            FrmSpell.phone = FrmMain.phone;
            frmsonglist.Show();
        }
        /// <summary>
        /// 歌手点歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlSingerSearch_Click(object sender, EventArgs e)
        {
            FrmSingerType frmSinger = new FrmSingerType();
            FrmSingerType.play = FrmMain.play;
            FrmSingerType.phone = FrmMain.phone;
            frmSinger.Show();
        }
        /// <summary>
        /// 金曲排行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlRanklist_Click(object sender, EventArgs e)
        {
            FrmTopList frmsonglist = new FrmTopList();
            FrmTopList.play = FrmMain.play;
            FrmTopList.phone = FrmMain.phone;
            frmsonglist.Show();
        }
        #endregion
        #region 通用工具栏
        /// <summary>
        /// 连接手机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlConnPhone_Click(object sender, EventArgs e)
        {
            if(this.qrIP.Visible == false)
            {
                this.qrIP.Visible = true;
                this.qrIP.Text = phone.GetIPAddress();
            }
            else if (this.qrIP.Visible == true)
            {
                this.qrIP.Visible = false;
            }
        }
        /// <summary>
        /// 点餐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlFood_Click(object sender, EventArgs e)
        {
            FrmFood food = new FrmFood();
            FrmFood.play = FrmMain.play;
            FrmFood.phone = FrmMain.phone;
            food.Show();
        }
        /// <summary>
        /// 主页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlShowMain_Click(object sender, EventArgs e)
        {
            FrmMain frmmain = new FrmMain();
            this.Close();
            frmmain.Show();
        }
        /// <summary>
        /// 已点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlSongList_Click(object sender, EventArgs e)
        {
            FrmSongedList frmsonglist = new FrmSongedList();
            FrmSongedList.play = FrmMain.play;
            frmsonglist.SearchType = "已点";
            frmsonglist.Show();
        }
        /// <summary>
        /// 服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlServer_Click(object sender, EventArgs e)
        {
            bool result = roommanage.Server(FrmMain.roomId);
            if (result)
            {
                MessageBox.Show("服务发送成功", "服务", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("服务发送失败", "服务", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblLastPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 重唱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlLastSong_Click(object sender, EventArgs e)
        {
            PlayList.PlayAgain();
        }
        /// <summary>
        /// 切歌
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlNextSong_Click(object sender, EventArgs e)
        {
            bool result = PlayList.CutSong();
            if(!result)
            {
                MessageBox.Show("播放列表已播放完，请再点歌","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 退出结账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlExit_Click(object sender, EventArgs e)
        {
            DialogResult sure = MessageBox.Show("确定要呼叫服务员结账吗？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(sure == DialogResult.OK)
            {
                RoomManage roommanage = new RoomManage();
                string foodList = roommanage.GetFoodList(FrmMain.roomId);
                int payMoney = roommanage.GetFoodMoney(FrmMain.roomId);
                roommanage.OpenPayServer(FrmMain.roomId);
                DialogResult result = MessageBox.Show("您的餐单如下：\n" + foodList + "消费金额为：" + payMoney + "元。\n欢迎下次光临！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
        /// <summary>
        /// 刷新当前播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblNowPlay.Text = PlayList.GetPlayingSongName();
            this.lblNextPlay.Text = PlayList.GetNextSongName();
            if (PlayList.GetPlayingSongName() == string.Empty && this.lblNowPlay.Text.Equals("播放列表内没有歌曲"))
            {
                this.lblNowPlay.Text = "播放列表内没有歌曲";
            }
            if (PlayList.GetNextSongName() == string.Empty && this.lblNextPlay.Text.Equals("播放列表内没有歌曲"))
            {
                this.lblNextPlay.Text = "播放列表内没有歌曲";
            }
        }
        public static FrmPlaySong play = null;
        /// <summary>
        /// 原唱伴唱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlsinger_Click(object sender, EventArgs e)
        {
            if (FrmPlaySong.truck == 0)
            {
                play.wmp.SetConfig(403, "1");
                this.label3.Text = "伴唱";
                FrmPlaySong.truck = 1;
            }
            else if (FrmPlaySong.truck == 1)
            {
                play.wmp.SetConfig(403, "0");
                this.label3.Text = "原唱";
                FrmPlaySong.truck = 0;
            }
        }
        
        /// <summary>
        /// 气氛单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_Click(object sender, EventArgs e)
        {
            if(this.panel2.Visible == true)
            {
                this.panel2.Visible = false;
            }
            else
            {
                this.panel2.Visible = true;
            }
        }
        /// <summary>
        /// 玫瑰表情单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmSingerSearch singer = new FrmSingerSearch();
            play.SetFace(singer.GetAllURL() + @"\玫瑰.swf");
        }
        /// <summary>
        /// 好棒表情单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmSingerSearch singer = new FrmSingerSearch();
            play.SetFace(singer.GetAllURL() + @"\你好棒.swf");
        }
        /// <summary>
        /// 暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlPause_Click(object sender, EventArgs e)
        {
            if(this.lblPause.Text.Trim() == "播放")
            {
                play.Pause(0);
                this.lblPause.Text = "暂停";
            }
            else if (this.lblPause.Text.Trim() == "暂停")
            {
                play.Pause(1);
                this.lblPause.Text = "播放";
            }
        }
        /// <summary>
        /// 音量加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlAdd_Click(object sender, EventArgs e)
        {
            
            play.AddVolume();
        }
        /// <summary>
        /// 音量减
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlDel_Click(object sender, EventArgs e)
        {
            
           play.DelVolume();
        }
        #endregion

        private void timBtnStatic_Tick(object sender, EventArgs e)
        {
            if (FrmPlaySong.truck == 0)
            {
                this.label3.Text = "原唱";
            }
            else
            {
                this.label3.Text = "伴唱";
            }
            if (FrmPlaySong.pause == 0)
            {
                this.lblPause.Text = "暂停";
            }
            else
            {
                this.lblPause.Text = "播放";
            }
        }

    }
}
