using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DrawYourself
{
    public partial class Form1 : Form
    {
        Pen myPen = new Pen(Color.Black, 1);
        Graphics g = null;
        Graphics gnew = null;
        bool draw = false;
        Point start = new Point(0, 0);
        Point end = new Point(0, 0);
        List<List<Point>> pathList = new List<List<Point>>();
        int strokes = 0;
        string name_of_doodle;
        //Point[] path;
        public Form1()
        {
            InitializeComponent();
            g = canvas.CreateGraphics();
            gnew = frame.CreateGraphics();
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                draw = true;
                start = e.Location;
                pathList.Add(new List<Point> { start });
                g.FillRectangle(Brushes.Black, start.X, start.Y, 1, 1);
                strokes++;
            }
            
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw == true)
            {
                // get positions and draw on canvas
                end = e.Location;
                g.DrawLine(myPen, start, end);
                start = end;
                // also update the array according to the no of strokes
                pathList[strokes-1].Add(end);
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name_of_doodle = textBox1.Text;
            textBox2.Text = name_of_doodle;
            canvas.Refresh();
            frame.Refresh();
            for (int i=0; i<strokes; i++)
            {
                if (pathList[i].Count == 1)
                {
                    gnew.FillRectangle(Brushes.Black, pathList[i][0].X, pathList[i][0].Y, 1, 1);
                }
                for (int j=1; j<pathList[i].Count; j++ )
                {
                    gnew.DrawLine(myPen, pathList[i][j - 1],pathList[i][j]);
                    Thread.Sleep(10);
                }
                Thread.Sleep(50);

                //simply show the drawing
                /*path = pathList[i].ToArray();
                gnew.DrawLines(myPen, path);*/
            }
            pathList.Clear();
            strokes = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
            frame.Refresh();
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
