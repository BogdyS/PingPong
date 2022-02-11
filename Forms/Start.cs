using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
        }

        private void slowbutton_Click(object sender, EventArgs e)
        {
            Hide();
            new PlayBoard(4).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void quickbutton_Click(object sender, EventArgs e)
        {
            Hide();
            new PlayBoard(20).Show();
        }
    }
}
