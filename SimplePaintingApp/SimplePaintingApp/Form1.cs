using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SimplePaintingApp
{
    public partial class Form1 : Form
    {
        ArrayList listOfPoints;
        bool PencilDown;

        public Form1()
        {
            InitializeComponent();
            listOfPoints = new ArrayList();
            PencilDown = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            listOfPoints.Add(p);
            PencilDown = true;
            this.statusStrip1.Items[0].Text = "Mouse Down";
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            PencilDown = false;
            this.statusStrip1.Items[0].Text = "Mouse Up";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Point points = new Point(e.X, e.Y);
            Pen pencil = new Pen(Color.BlueViolet);

            if (PencilDown)
            {
                this.statusStrip1.Items[0].Text = "Mouse Move";
                if (listOfPoints.Count > 1)
                {
                    g.DrawLine(pencil, (Point)listOfPoints[listOfPoints.Count - 1], points);
                    listOfPoints.Add(points);
                }
            }
        }
    }
}
