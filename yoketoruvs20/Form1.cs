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

        const string PrayerText = "(´・ω・`)";
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

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vkey);
        
        public Form1()
        {
            InitializeComponent();
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
                    break;

                case State.Game:
                    titlelabel.Visible = false;
                    startbutton.Visible = false;
                    copyrightlabel.Visible = false;
                    highscorelabel.Visible = false;
                    break;

                case State.Gameover:
                    gameoverlabel.Visible = true;
                    titlebutton.Visible = true;
                    break;

                case State.Clear:
                    crearlabel.Visible = true;
                    titlebutton.Visible = true;
                    highscorelabel.Visible = true;
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
