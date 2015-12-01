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

namespace StarWarsObject
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Explosion(0,0,250);
        }

        public void Explosion(float x, float y, float pixels)
        {
            int itemSize = 100;
            float scale = pixels / itemSize; 
            Pen arcPen = new Pen(Color.White);
            Pen laserPen = new Pen(Color.LimeGreen);
            Pen laser2Pen = new Pen(Color.LimeGreen, 2);
            Pen laser3Pen = new Pen(Color.LimeGreen, 5);
            SolidBrush drawBrush = new SolidBrush(Color.White);

            g.DrawRectangle(arcPen, 0 + x, 0 + y, 100 * scale, 100 * scale);

            g.DrawLine(arcPen, 43 * scale + x, scale * 0 + y, scale * 43 + x , scale * 8 + y);
            g.DrawLine(arcPen, 57 * scale + x, 0 * scale + y, 57 * scale + x, 8 * scale + y);
            g.DrawLine(arcPen, 43 * scale + x, 8 * scale + y, 57 * scale + x, 8 * scale + y);

            g.DrawLine(laserPen, 94 * scale + x, 29 * scale + y, 65 * scale + x, 24 * scale + y);
            g.DrawLine(laserPen, 94 * scale + x, 29 * scale + y, 84 * scale + x, 24 * scale + y);
            g.DrawLine(laserPen, 94 * scale + x, 29 * scale + y, 65 * scale + x, 54 * scale + y);
            g.DrawLine(laserPen, 94 * scale + x, 29 * scale + y, 85 * scale + x, 54 * scale + y);

            g.DrawLine(laser2Pen, 94 * scale + x, 29 * scale + y, 76 * scale + x, 38 * scale + y);
            g.DrawLine(laser3Pen, 94 * scale + x, 29 * scale + y, 100 * scale + x, 26 * scale + y);
            g.DrawLine(laserPen, 94 * scale + x, 29 * scale + y, 60 * scale + x, 40 * scale + y);
            g.DrawLine(laserPen, 94 * scale + x, 29 * scale + y, 76 * scale + x, 20 * scale + y);
            g.DrawLine(laserPen, 94 * scale + x, 29 * scale + y, 76 * scale + x, 60 * scale + y);

            g.DrawArc(arcPen, 0 * scale + x, 0 * scale + y, 100 * scale , 100 * scale, 280, 340 );

            g.DrawEllipse(arcPen, 60 * scale + x, 20 * scale + y, 30 * scale, 40 * scale);
            g.DrawEllipse(arcPen, 75 * scale + x, 35 * scale + y, 3 * scale, 7 * scale);


        }
    }
}
