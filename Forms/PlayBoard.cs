using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace PingPong
{
    public partial class PlayBoard : Form
    {
        public int startspeed;
        public Player player1, player2;
        public readonly int FPS = 200;
        private Controller controller;
        public PlayBoard(int startspeed)
        {
            this.startspeed = startspeed;
            InitializeComponent();
            player1 = new UserPlayer(RRacket, this);
            player2 = new UserPlayer(GRacket, this);
            controller = Controller.GetController;
            Ball.Label = this.ball;
            Ball objball = Ball.PlayBall;
            System.Windows.Forms.Cursor.Hide();
            timer.Interval = 10;
            timer.Enabled = true;
            controller.Init(this);
        }

        public int UpperLimit => UpWall.Location.Y + UpWall.Size.Height;
        public int ButtomLimit => DownWall.Location.Y;



        private async void timer_Tick(object sender, EventArgs e)
        {
            Task t1 = (Task.Run(() =>
            {
                Invoke((MethodInvoker)delegate { controller.ControlLeftPlayer(player1); });
            }
            ));
            Task t2 = (Task.Run(() =>
            {
                Invoke((MethodInvoker)delegate { controller.ControlRightPlayer(player2); });
            }));

            Task t3 = (Task.Run(() =>
            {
                Invoke((MethodInvoker)delegate { controller.ControlBall(this); });
            }));
            await Task.WhenAll(new[] { t1, t2, t3 });
        }

        public void Restart()
        {
            rightscore.Text = player1.Score.ToString();
            leftscore.Text = player2.Score.ToString();
            if ((player1.Score == 5) || (player2.Score == 5))
            {
                GOLabel.Visible = true;
                Exiter.Enabled = true;
            }
            else
            {
                controller.startballspeedX = startspeed;
                controller.startballspeedY = startspeed;
                restarter.Enabled = true;
                controller.Init(this);
                Ball.Label.Location = new Point(753, 417);
                Ball.PlayBall.X = 753;
                Ball.PlayBall.Y = 417;
                player1.Y = 347;
                player2.Y = 347;
            }

        }
        public System.Windows.Forms.Timer Timer => this.timer;
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;  
                return handleParam;
            }
        }
        public int LeftRacket => player1.Y;
        public int RightRacket => player2.Y;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void restarter_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Space)) RestartGame();
        }

        private void RestartGame()
        {

            restarter.Enabled = false;
            timer.Enabled = true;
        }
    

        private void Exiter_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Escape))
            {
                Form form = Application.OpenForms[0];
                System.Windows.Forms.Cursor.Show();
                form.Show();
                Ball.PlayBall.Dispose();
                Dispose();
            }
        }

        public bool GameIsRunning
        {
            get => timer.Enabled;
            set { timer.Enabled = value; }
        }
    }
}
