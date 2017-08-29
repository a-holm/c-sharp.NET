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

namespace SimplePaintingApp2
{
    public partial class Form1 : Form
    {
        private bool PencilDown;
        private Graphics context;
        private ArrayList listOfPoints;
        private Bitmap img;
        public Form1()
        {
            InitializeComponent();
            listOfPoints = new ArrayList();
            img = new Bitmap(this.Width, this.Height);
            context = Graphics.FromImage(img);

            hScrollBar1.Visible = false;
        }

        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.ForeColor = dlg.Color;
            }
        }

        private void thicknessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hScrollBar1.Visible = true;
        }

        private void Save(Control c, string file)
        {
            Graphics g = c.CreateGraphics();
            Bitmap picture = new Bitmap(c.Width, c.Height);
            c.DrawToBitmap(picture, new Rectangle(c.ClientRectangle.X, c.ClientRectangle.Y, c.Width, c.Height));
            picture.Save(file);
            picture.Dispose();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save(this, "picture.jpg");
            MessageBox.Show("Image was saved.");
        }

        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = new Point(-1, -1);
                listOfPoints.Add(p);
                PencilDown = false;
                label1.Text = "Mouse Up";
                Invalidate();
            }
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point p = new Point(e.X, e.Y);
                listOfPoints.Add(p);
                Pen paint_brush = new Pen(this.ForeColor);
                paint_brush.Width = hScrollBar1.Value;

                if (PencilDown)
                {
                    context.DrawLine(paint_brush, (Point)listOfPoints[listOfPoints.Count - 2], (Point)listOfPoints[listOfPoints.Count - 1]);
                    label1.Text = "Mouse Move";
                    Invalidate();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PencilDown = true;
                Point p = new Point(e.X, e.Y);
                listOfPoints.Add(p);
                label1.Text = "Mouse Down";
                Invalidate();
            }
        }

        

        
    }
}
