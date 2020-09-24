using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace yoketoruvs20
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int PrayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PrayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        const int PrayerIndex = 0;
        const int EnemyIndex = PrayerIndex + PrayerMax;
        const int ItemIndex = EnemyIndex + EnemyMax;

        const string PrayerText = "(∵)";
        const string EnemyText = "◆";
        const string ItemText = "◎";

        static Random rand = new Random();

        enum State
        {
            None = -1,  //無効
            Title,      //タイトル
            Game,       //ゲーム
            Gameover,   //ゲームオーバー
            Clear,      //クリア
        }
        State currentState = State.None;
        State Nextstate = State.Title;

        const int SpeedMax = 10;
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];
        int itemCount;
        int timeCount;
        int highScore=0;

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vkey);
        
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < ChrMax; i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if(i==PrayerIndex)
                {
                    chrs[i].Text = PrayerText;
                }
                else if(i<ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                Controls.Add(chrs[i]);
                chrs[i].Font = Templabel.Font;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Nextstate != State.None)
            {
                initProc();
            }

            if (isDebug) 
            {
                if (GetAsyncKeyState((int)Keys.O) < 0)
                {
                    Nextstate = State.Gameover;
                }

                if (GetAsyncKeyState((int)Keys.C) < 0)
                {
                    Nextstate = State.Clear;
                }
            }

            if(currentState==State.Game)
            {
                UpdateGame();
            }
        }

        void UpdateGame()
        {
            Point mp = PointToClient(MousePosition);

            //mpがプレイヤーの中心になるように設定
            chrs[PrayerIndex].Left = mp.X - (chrs[PrayerIndex].Width / 2);
            chrs[PrayerIndex].Top = mp.Y - (chrs[PrayerIndex].Height / 2);
            //タイム増加
            timeCount--;
            for (int i = EnemyIndex; i < ChrMax; i++)
            {
                //キャラクターの移動
                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];
                //跳ね返り処理
                if (chrs[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (chrs[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (chrs[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (chrs[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
                //当たり判定
                if (mp.X > chrs[i].Left &&
                    mp.X < chrs[i].Right &&
                    mp.Y > chrs[i].Top &&
                    mp.Y < chrs[i].Bottom &&
                    chrs[i].Visible==true)
                {
                    //敵の場合
                    if (chrs[i].Text == EnemyText)
                    {
                        if (timeCount < 290)
                        Nextstate = State.Gameover;
                    }
                    //アイテムの場合
                    else
                    {
                        chrs[i].Visible = false;
                        vx[i] = 0;
                        itemCount--;
                    }
                }
            }
            starlabel.Text = "" + ItemText + ":" + itemCount;
            timelabel.Text = "TIME " + timeCount;
            if (itemCount <= 0)
            {
                Nextstate = State.Clear;
            }
            if(timeCount<=0)
            {
                Nextstate = State.Gameover;
            }
        }

        void initProc()
        {
            currentState = Nextstate;
            Nextstate = State.None;

            switch(currentState)
            {
                case State.Title:
                    titlelabel.Visible = true;
                    startbutton.Visible = true;
                    copyrightlabel.Visible = true;
                    highscorelabel.Visible = true;
                    gameoverlabel.Visible = false;
                    titlebutton.Visible = false;
                    crearlabel.Visible = false;
                    //キャラクターを非表示
                    for (int i = PrayerIndex; i < ChrMax; i++)
                    {
                        chrs[i].Visible = false;
                    }
                    break;

                case State.Game:
                    titlelabel.Visible = false;
                    startbutton.Visible = false;
                    copyrightlabel.Visible = false;
                    highscorelabel.Visible = false;

                    itemCount = ItemMax;
                    timeCount = 300;
                    for (int i = PrayerIndex; i < ChrMax; i++)
                    {
                        //キャラクターを表示
                        chrs[i].Visible = true;
                        //キャラクターの移動の乱数指定
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                    }
                    for (int i = EnemyIndex; i < ChrMax; i++)
                    {
                        //キャラクターの位置の乱数指定
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                    }
                    break;

                case State.Gameover:
                    gameoverlabel.Visible = true;
                    titlebutton.Visible = true;
                    break;

                case State.Clear:
                    if(highScore<timeCount)
                    {
                        highScore = timeCount;
                        highscorelabel.Text = "HighScore " + highScore;
                        highscorelabel.Visible = true;
                    }
                    crearlabel.Visible = true;
                    titlebutton.Visible = true;
                    break;
            }
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            Nextstate = State.Game;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nextstate = State.Title;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}
