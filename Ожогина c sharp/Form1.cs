using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;

namespace Ожогина_c_sharp
{
   
    public partial class Form1 : Form
    {
        bool b = true;
        static int count = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            button1.BackColor = colorDialog1.Color;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            button2.BackColor = colorDialog2.Color;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._1 as Bitmap;
            pictureBox6.Image = Properties.Resources._1 as Bitmap;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._2 as Bitmap;
            pictureBox6.Image = Properties.Resources._2 as Bitmap;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._3 as Bitmap;
            pictureBox6.Image = Properties.Resources._3 as Bitmap;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Color clr1 = colorDialog1.Color;
            Color clr2 = colorDialog2.Color;
            draw(clr1, clr2);
        }

        private void draw1(Color a, Color b)
        {
            Bitmap bmp = new Bitmap(pictureBox5.Width, pictureBox5.Height);
            Graphics g = Graphics.FromImage(bmp);
            Brush Br = new SolidBrush(a);
            Pen pen = new Pen(b);
            pen.Width = 5;
            Pen peni = new Pen(b);
            Pen pend = new Pen(Color.FromArgb(255, 0, 0, 255));
            peni.Width = 3;
            SolidBrush colorbruh = new SolidBrush(Color.Tomato);
            SolidBrush colorblueti = new SolidBrush(a);
            SolidBrush colorred = new SolidBrush(Color.Red);

            Point[] Piq ={
                new Point(350 , 115),
                new Point(350 , 135),
                new Point(410 , 130),
                                 };
            g.FillEllipse(colorblueti, 120, 160, 170, 50);
            g.FillEllipse(colorblueti, 145, 135, 120, 50);
            g.FillEllipse(colorblueti, 170, 120, 70, 50);
            g.DrawEllipse(pen, 120, 160, 170, 50);
            g.DrawEllipse(pen, 145, 135, 120, 50);
            g.DrawEllipse(pen, 170, 120, 70, 50);


            Point[] Pid ={
                new Point(230 , 115),
                new Point(300 , 160),
                new Point(150 , 180),
                new Point(170, 120),
                                 };

            pictureBox5.Image = bmp;
        }
        private void draw(Color a, Color b)
        {
            Bitmap bmp = new Bitmap(pictureBox5.Width, pictureBox5.Height);
            Graphics g = Graphics.FromImage(bmp);
            Brush Br = new SolidBrush(a);
            Pen pen = new Pen(b);
            pen.Width = 5;
            Pen peni = new Pen(b);
            peni.Width = 3;
            SolidBrush colorbruh = new SolidBrush(Color.Tomato);
            SolidBrush colorblueti = new SolidBrush(a);
            SolidBrush colorred = new SolidBrush(Color.Red);
            Point[] Pid ={
                new Point(230 , 120),
                new Point(300 , 60),
                new Point(150 , 80),
                new Point(170, 125),
                                 };


            Point[] Piq ={
                new Point(350 , 115),
                new Point(350 , 135),
                new Point(410 , 130),
                                 };

            g.FillEllipse(colorblueti, 120, 160, 170, 50);
            g.FillEllipse(colorblueti, 145, 135, 120, 50);
            g.FillEllipse(colorblueti, 170, 120, 70, 50);
            g.FillEllipse(colorblueti, 250, 150, 70, 40); ////  тело

            pictureBox5.Image = bmp;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
          
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._7 as Bitmap;
            pictureBox6.Image = Properties.Resources._7 as Bitmap;
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._5 as Bitmap;
            pictureBox6.Image = Properties.Resources._5 as Bitmap;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b == true)
            {
                b = false;
                draw(colorDialog1.Color, colorDialog2.Color);
                
            }
            else
            {
                b = true;
                draw1(colorDialog1.Color, colorDialog2.Color);
            }
            
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }
    }
}
