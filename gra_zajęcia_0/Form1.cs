using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gra_zajęcia_0
{
    public partial class Form1 : Form
    {
        game gm = new game(6, 100, 20);
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
            gm.draw(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gm.update();
            pictureBox1.Invalidate();
        }
    }
}
