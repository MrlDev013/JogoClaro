using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDeMover
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        int Pixel = 30;
        private void btn_Up_Click(object sender, EventArgs e)
        {
            if (pct_Player.Top - Pixel >= 0)
            {
                pct_Player.Top -= Pixel;
            }
        }

        private void btn_Left_Click(object sender, EventArgs e)
        {
            if (pct_Player.Left - Pixel >= 0)
            {
                pct_Player.Left -= Pixel;
            }   
        }

        private void btn_Right_Click(object sender, EventArgs e)
        {
            if (pct_Player.Right + Pixel <= 920)
            {
                pct_Player.Left += Pixel;
            } 
        }

        private void btn_Down_Click(object sender, EventArgs e)
        {
            if (pct_Player.Bottom + Pixel <= 560)
            {
                pct_Player.Top += Pixel;
            }
        }
    }
}
