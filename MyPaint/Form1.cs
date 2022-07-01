using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        Bitmap bmp = new Bitmap(1024, 768);
        Pen pen = new Pen(Color.Black, 5);
        bool isDrawing = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
            }
            else
            {
                isDrawing = true;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                Graphics graph = Graphics.FromImage(bmp);
                graph.DrawEllipse(pen, e.X, e.Y, 3, 1);
                pictureBox.Image = bmp;
            }
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Green;
        }

        private void purpleButton_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Purple;
        }

        private void limeButton_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Lime;
        }

        private void blackButton_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
        }

        private void whiteButton_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Jpeg Image|*.jpg|Bitmap Image|*.bmp";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.pictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.pictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
            }
        }
    }
}
