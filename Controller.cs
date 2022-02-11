using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace PingPong
{
    /// <summary>
    /// Используется для контроля игровых объектов.
    /// Класс реализует паттерн Singleton.
    /// </summary>
    class Controller
    {
        static private Controller controller;

        private int racketspeed = 10;
        public int startballspeedX, startballspeedY;
        private Controller()
        {

        }

        static public Controller GetController
        {
            get
            {
                if (controller == null) controller = new Controller();
                return controller;
            }
        }

        public void ControlLeftPlayer(object oplayer)
        {
            Player player = (Player)oplayer;
            if (Keyboard.IsKeyDown(Key.W))
            {
                player.Y -= racketspeed;
            }
            else if (Keyboard.IsKeyDown(Key.S))
            {
                player.Y += racketspeed;
            }

        }
        public void ControlRightPlayer(object oplayer)
        {
            Player player = (Player)oplayer;
            if (Keyboard.IsKeyDown(Key.Down))
            {
                player.Y += racketspeed;
            }
            else if (Keyboard.IsKeyDown(Key.Up))
            {
                player.Y -= racketspeed;
            }
        }
        public void ControlBall(PlayBoard form)
        {
            Ball b = Ball.PlayBall;
            b.Y += startballspeedY;
            b.X += startballspeedX;
            Ball.Label.Location = new Point(b.X, b.Y);
            if ((b.Y == 15)|| (b.Y == 819)) startballspeedY *= -1;
            if ((b.X == 50)||(b.X == 1456))
            {
                if ((b.X == 50) && (form.LeftRacket <= b.Y) && (form.LeftRacket + 185 >= b.Y))
                {
                    if (startballspeedX > 0) startballspeedX += 1;
                    else startballspeedX -= 1;
                    if (startballspeedY > 0) startballspeedY += 1;
                    else startballspeedY -= 1;
                    startballspeedX *= -1;
                }
                else if ((b.X == 1456) &&(form.RightRacket <= b.Y) && (form.RightRacket + 185 >= b.Y))
                {
                    if (startballspeedX > 0) startballspeedX += 1;
                    else startballspeedX -= 1;
                    if (startballspeedY > 0) startballspeedY += 1;
                    else startballspeedY -= 1;
                    startballspeedX *= -1;
                }
                else
                {
                    form.GameIsRunning = false;
                    if (b.X == 50) form.player1.Score += 1;
                    else form.player2.Score += 1;
                    form.Restart();
                }
                if (Keyboard.IsKeyDown(Key.Escape) )form.Timer.Enabled = false;
            }
        }
        public void Init(PlayBoard form)
        {
            int startspeed = form.startspeed; 
            int rand = (new Random()).Next(1, 5);
            if (rand == 1) { startballspeedX = startspeed; startballspeedY = startspeed; }
            else if (rand == 2) { startballspeedX = -startspeed; startballspeedY = startspeed; }
            else if (rand == 3) { startballspeedX = -startspeed; startballspeedY = -startspeed; }
            else if (rand == 4) { startballspeedX = startspeed; startballspeedY = -startspeed; }
        }
    }
}
