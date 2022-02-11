using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    class PictureHandler
    {
        private Bitmap _CurrentSprite; //для работы с изображениями, определяемыми данными пикселей.
        public PictureHandler(string filename, Label label)
        {
            _CurrentSprite = new Bitmap(filename);
            if (label != null)
            {
                label.Image = _CurrentSprite;
                label.BackColor = Color.Transparent;
            }
        }
        public Bitmap Picture => _CurrentSprite;
    }
}
