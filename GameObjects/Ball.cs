using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    /// <summary>
    /// Класс опысывающий поведение мяча.
    /// Реализует паттерн Singleton.
    /// </summary>
    class Ball : IDisposable, System.Runtime.CompilerServices.INotifyCompletion
    {
        public static Label Label { get; set; }
        private static PictureHandler _pic;
        private static int _x, _y, _width, _height;
        private static Ball ball;
        private Ball() 
        {
            _pic = new PictureHandler(@"D:\code\ОП\ОП 2 семак\Доп2\PingPong\Pictures\Images\ballwe.png", Label);
            _x = Label.Location.X;
            _y = Label.Location.Y;
            _width = Label.Size.Width;
            _height = Label.Size.Height;
            Label.BackColor = Color.Transparent;
        }
        public static Ball PlayBall
        {
            get
            {
                if (ball != null) return ball;
                else
                {
                    ball = new Ball();
                    return ball;
                }
            }
        }
       
        public int X 
        { 
            get =>_x;
            set
            {
                if (value <= 50) _x = 50;
                else if (value >= 1456) _x = 1456;
                else _x = value;
            }
        }
        public int Y
        {
            get => _y;
            set
            {
                if (value <= 15) _y = 15;
                else if (value >= 819) _y = 819;
                else _y = value;
            }
        }
        public static int Height => _height;
        public static int Width => _width;

        public void Dispose()
        {
            ball = null;
        }

        public void OnCompleted(Action continuation)
        {
        }
        public Ball GetAwaiter() => PlayBall;
    }
}
