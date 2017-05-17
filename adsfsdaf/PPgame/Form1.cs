using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPgame
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        Blocks block1,block2;
        Ball ball;
        SolidBrush blockcolor;
        SolidBrush ballcolor;

        static bool gameExist=true;
        static int x1=30,x2=653,y1=50,y2=50,bx=300,by=200;
        static int v=2,u=2,score1=0,score2=0;
        

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            blockcolor = new SolidBrush(Color.Black);
            ballcolor = new SolidBrush(Color.Red);
            block1 = new Blocks(15, 50);
            block2 = new Blocks(668, 50);
            ball = new Ball(300, 200);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            label1.Text = score1.ToString();
            label2.Text = score2.ToString();
            label3.Text = score1.ToString();
            label4.Text = score2.ToString();
            if (gameExist)
            {
                bx = bx + v;
                by = by - u;
            }

            if (by <= 0 || by >= 405)
                u = u * -1;

            block1 = new Blocks(x1, y1);
            block2 = new Blocks(x2, y2);
            ball = new Ball(bx, by);

            if (bx <= x1 + 17 && by <= y1 + 50 && by >= y1 - 50)
                v = v * -1;
            else if(bx <= x1 + 17 && by > y1 + 50 && by < y1 - 50)
            {
                score2++;
                bx = 300;
                by = 200;
                v = 2;
                u = 2;
            }
            if (bx >= x2 - 17 && by <= y2 + 50 && by >= y2 - 50)
                v = v * -1;
            else if(bx >= x2 - 17 && by > y2 + 50 && by < y2 - 50)
            {
                score1++;
                bx = 300;
                by = 200;
                v = 2;
                u = 2;
            }
            if (score1 == 2)
            {
                label5.Text = "Player 1 WIN";
                gameExist = false;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }
            if (score2 == 2)
            {
                label5.Text = "Player 2 WIN";
                gameExist = false;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }



            if (gameExist)
            DrawAll();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up )
                y2 = y2 - 40;
            if (e.KeyCode == Keys.Down )
                y2 = y2 + 40;
            if (e.KeyCode == Keys.W )
                y1 = y1 - 40;
            if (e.KeyCode == Keys.S )
                y1 = y1 + 40;
        }

        public void DrawAll()
        {
            g.FillPath(blockcolor, block1.path1);
            g.FillPath(blockcolor, block2.path1);
            g.FillPath(ballcolor, ball.path2);
        }
    }
}
