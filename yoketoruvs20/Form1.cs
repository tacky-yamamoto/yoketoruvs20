using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yoketoruvs20
{
    public partial class Form1 : Form
    {
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
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            Nextstate = State.Game;
        }
    }
}
