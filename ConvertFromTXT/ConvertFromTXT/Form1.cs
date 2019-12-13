using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertFromTXT
{
    public partial class Form1 : Form
    {
        StreamReader readPic;
        Bitmap bmp;
        Graphics graphics;
        SolidBrush brush;
        int colorRead, R, G, B;

        public Form1()
        {
            InitializeComponent();

            message();

            bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bmp);
            pictureBox.Image = bmp;

            brush = new SolidBrush(Color.Black);
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"D:\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxPath.Text = openFileDialog.FileName;
                    graphics.Clear(Color.Black);
                    pictureBox.Image = bmp;
                }
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                readPic = new StreamReader(textBoxPath.Text, System.Text.Encoding.Default);

                for (int y = 0; y < pictureBox.Height; y++)
                {
                    for (int x = 0; x < pictureBox.Width; x++)
                    {
                        colorRead = Convert.ToInt32(readPic.ReadLine());
                        R = ((colorRead & 0xF800) >> 8);
                        G = ((colorRead & 0x07E0) >> 3);
                        B = ((colorRead & 0x001F) << 3);
                        brush.Color = Color.FromArgb(R, G, B);
                        graphics.FillRectangle(brush, x, y, 1, 1);
                    }
                }
                readPic.Close();
                pictureBox.Image = bmp;
            }
            catch (Exception)
            {
                pictureBox.Image = Properties.Resources._404error;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = textBoxPath.Text;
                saveFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image.Save(saveFileDialog.FileName);
                }
            }
        }

        void message()
        {
            toolTip.SetToolTip(this.openFileButton, "Open file");
            toolTip.SetToolTip(this.buttonConvert, "Convert");
            toolTip.SetToolTip(this.buttonSave, "Save");
        }
    }
}
