using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DrawYourself
{

    public partial class Form1 : Form
    {
        Pen myPen = new Pen(Color.Black, 1);
        Graphics g = null;
        Graphics gnew = null;
        bool draw = false;
        bool doodled = false;
        Point start = new Point(0, 0);
        Point end = new Point(0, 0);
        Shape pathList = new Shape();
        int strokes = 0;
        string name_of_doodle = "";
        //Point[] path;

        Dictionary<string, List<Shape>> doodles;

        public Form1()
        {
            InitializeComponent();
            g = canvas.CreateGraphics();
            gnew = frame.CreateGraphics();
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (doodled)
            {
                pathList.points.Clear();
                strokes = 0;
            }
            doodled = false;
            button1.Enabled = true;
            if (e.Button == MouseButtons.Left)
            {
                draw = true;
                start = e.Location;
                pathList.points.Add(new List<Point> { start });
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
                pathList.points[strokes-1].Add(end);
            }
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        //doodle button
        private void button1_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
            frame.Refresh();
            button1.Enabled = false;
            for (int i=0; i<strokes; i++)
            {
                if (pathList.points[i].Count == 1)
                {
                    gnew.FillRectangle(Brushes.Black, pathList.points[i][0].X, pathList.points[i][0].Y, 1, 1);
                }
                for (int j=1; j<pathList.points[i].Count; j++ )
                {
                    gnew.DrawLine(myPen, pathList.points[i][j - 1],pathList.points[i][j]);
                    Thread.Sleep(10);
                }
                Thread.Sleep(50);

                //simply show the drawing
                /*path = pathList.points[i].ToArray();
                gnew.DrawLines(myPen, path);*/
            }
            doodled = true;
        }

        //clear button
        private void button2_Click(object sender, EventArgs e)
        {
            canvas.Refresh();
            frame.Refresh();
            textBox1.Text = "";
            pathList.points.Clear();
            strokes = 0;
            doodled = false;
            button1.Enabled = false;
        }

        //save button
        private void button3_Click(object sender, EventArgs e)
        {
            if (!doodled)
            {
                //pop up window to show a message for doodling
                MessageBox.Show("Create Doodle First!");
            }
            else if (name_of_doodle.Length == 0)
            {
                //pop up window to show a message to provide a name
                MessageBox.Show("Give your doodle a name!");
            }
            else 
            {
                // Read the File!
                string path = Path.Combine(Environment.CurrentDirectory, @"doodles.json");
                string jsonFromFile;
                using (var reader = new StreamReader(path))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                doodles = JsonConvert.DeserializeObject<Dictionary<string, List<Shape>>>(jsonFromFile);
                if (doodles == null)
                {
                    doodles = new Dictionary<string, List<Shape>>();
                }

                //edit the doodle object
                var shape = new Shape(pathList);
                if (doodles.ContainsKey(name_of_doodle))
                {
                    doodles[name_of_doodle].Add(shape);
                }
                else
                {
                    doodles.Add(name_of_doodle, new List<Shape> { shape });
                }

                //save the json
                var jsonToWrite = JsonConvert.SerializeObject(doodles, Formatting.Indented);
                using (var writer = new StreamWriter(path))
                {
                    writer.Write(jsonToWrite);
                }
                frame.Refresh();

                //pop up window to show success!
                MessageBox.Show("Saved successfully!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name_of_doodle = textBox1.Text;
        }
    }

    public class Shape
    {
        public List<List<Point>> points = new List<List<Point>>();

        public Shape()
        {

        }

        public Shape(Shape ob)
        {
            this.points = ob.points;
        }
    }
}
