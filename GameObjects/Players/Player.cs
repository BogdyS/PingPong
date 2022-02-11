using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PingPong
{
    public abstract class Player : System.Runtime.CompilerServices.INotifyCompletion
    {
        public int Score { get; set; }
        private PlayBoard _form;
        private int _y;
        private Label myLabel;
        public Player(Label racket, PlayBoard form)
        {
            Score = 0;
            _form = form;
            myLabel = racket;
            X = racket.Location.X;
            _y = racket.Location.Y;
        }
        public int X { get; private set; }
        public int Y
        {
            get => _y;
            set
            {
                int move = value;
                if (move > myLabel.Location.Y) move += 170;
                if (CheckBounds(move))
                {
                    _y = value;
                }
                else
                {
                    if (move > myLabel.Location.Y)
                    {
                        _y = _form.ButtomLimit - myLabel.Size.Height;
                    }
                    else
                    {
                        _y = _form.UpperLimit;
                    }
                }
                myLabel.Location = new Point(X, _y);
            }
        }
        private bool CheckBounds(int newCords)
        {
            if (myLabel.Location.Y < newCords) // движение вниз
            {
                if (newCords > _form.ButtomLimit) return false;
            }
            else // движение вверх
            {
                if (newCords < _form.UpperLimit) return false;
            }
            return true;
        }

        public void OnCompleted(Action continuation)
        {
        }
        public Player GetAwaiter() => this;
    }
}
