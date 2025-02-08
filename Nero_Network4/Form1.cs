using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nero_Network4
{
    public partial class Form1 : Form
    {
        static int lastSymbol;
        const int _width = 100;
        const int _height = 100;
        static int N = _width * _height;
        const int picNum = 4;
        int[][] sample = new int[picNum][];
        float[,] weights = new float[N, N];
        int untrainings = 0;
        public Form1()
        {
            InitializeComponent();
            label.Text = "";
            label1.Text = $"Разобучений = {untrainings}";
            for (int i = 0; i < picNum; i++)
            {
                Bitmap bm = (Bitmap)Image.FromFile($"{i}.png");
                sample[i] = new int[N];
                for (int j = 0; j < N; j++)
                {
                    sample[i][j] = bm.GetPixel(j % _width, j / _width) == Color.FromArgb(255, 0, 0, 0) ? 1 : -1;
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    if (i == j) weights[i, j] = 0;
                    else
                    {
                        weights[i, j] = 0;
                        for (int k = 0;  k < picNum;  k++)
                        {
                            weights[i, j] += sample[k][i] * sample[k][j];
                        }
                        weights[j, i] = weights[i, j];
                    }
                }
            }
        }
        private void bPic1_Click(object sender, EventArgs e)
        {
            lastSymbol = 1;
            pbSample.Image = Image.FromFile("0.png");
        }
        private void bPic2_Click(object sender, EventArgs e)
        {
            lastSymbol = 2;
            pbSample.Image = Image.FromFile("1.png");
        }
        private void bPic3_Click(object sender, EventArgs e)
        {
            lastSymbol = 3;
            pbSample.Image = Image.FromFile("2.png");
        }
        private void bPic4_Click(object sender, EventArgs e)
        {
            lastSymbol = 4;
            pbSample.Image = Image.FromFile("3.png");
        }

        private void bGive_Click(object sender, EventArgs e)
        {
            label.Text = "";
            int[] oldPicture = new int[N];
            int[] newPicture = new int[N];
            Bitmap bm = (Bitmap)pbSample.Image;
            bool end;

            for (int i = 0; i < N; i++)
            {
                oldPicture[i] = bm.GetPixel(i % _width, i / _width) == Color.FromArgb(255, 0, 0, 0) ? 1 : -1;
            }
            do
            {
                end = true;
                for (int i = 0; i < N; i++)
                {
                    float sum = 0;
                    for (int j = 0; j < N; j++)
                    {
                        sum += weights[i, j] * oldPicture[j];
                    }
                    if (sum < 0) newPicture[i] = -1;
                    else if (sum > 0) newPicture[i] = 1;
                    else newPicture[i] = oldPicture[i];
                    if (newPicture[i] != oldPicture[i]) end = false;
                }
                for (int i = 0; i < N; i++)
                {
                    oldPicture[i] = newPicture[i];
                }
            } while (!end);
            for (int i = 0; i < N; i++)
            {
                bm.SetPixel(i % _width, i / _width, newPicture[i] == 1 ? Color.FromArgb(255, 0, 0, 0) : Color.FromArgb(255, 255, 255, 255));
            }
            pbSample.Image = bm;
            label.Text = "Функционирование завершено";
        }

        private void bCorrupt_Click(object sender, EventArgs e)
        {
            Bitmap bm = (Bitmap)pbSample.Image;
            Random r = new Random();
            Point p;
            for (int i = 0; i < N * 0.5f; i++)
            {
                p = new Point(r.Next(0, _width), r.Next(0, _height));
                bm.SetPixel(p.X, p.Y, bm.GetPixel(p.X, p.Y) == Color.FromArgb(255, 255, 255, 255) ? Color.FromArgb(255, 0, 0, 0) : Color.FromArgb(255, 255, 255, 255));
            }
            pbSample.Image = bm;
        }

        private void bUntrain_Click(object sender, EventArgs e)
        {
            label.Text = "";
            float epsilon = 0.1f;
            Bitmap bm = (Bitmap)pbSample.Image;
            int[] picture = new int[N];
            for (int i = 0; i < N; i++)
            {
                picture[i] = bm.GetPixel(i % _width, i / _width) == Color.FromArgb(255, 0, 0, 0) ? 1 : -1;
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    if (i != j)
                    {
                        weights[i, j] -= epsilon * picture[i] * picture[j];
                        weights[j, i] = weights[i, j];
                    }
                }
            }
            if (lastSymbol == 1) bPic1_Click(sender, e);
            else if (lastSymbol == 2) bPic2_Click(sender, e);
            else if (lastSymbol == 3) bPic3_Click(sender, e);
            else bPic4_Click(sender, e);
            untrainings++;
            label.Text = "Разобучение завершено";
            label1.Text = $"Разобучений = {untrainings}";
        }

        private void bAuto_Click(object sender, EventArgs e)
        {
            bool retest;
            do
            {
                retest = false;
                bPic1_Click(sender, e);
                for (int k = 0; k < picNum; k++)
                {
                    bool end;
                    do
                    {
                        end = true;

                        int[] oldPicture = new int[N];
                        Bitmap bm = (Bitmap)pbSample.Image;
                        for (int i = 0; i < N; i++)
                        {
                            oldPicture[i] = bm.GetPixel(i % _width, i / _width) == Color.FromArgb(255, 0, 0, 0) ? 1 : -1;
                        }

                        for (int i = 0; i < 3; i++) bCorrupt_Click(sender, e);
                        bGive_Click(sender, e);

                        int[] newPicture = new int[N];
                        bm = (Bitmap)pbSample.Image;
                        for (int i = 0; i < N; i++)
                        {
                            newPicture[i] = bm.GetPixel(i % _width, i / _width) == Color.FromArgb(255, 0, 0, 0) ? 1 : -1;
                        }

                        for (int i = 0; i < N; i++)
                        {
                            if (newPicture[i] != oldPicture[i]) end = false;
                        }
                        if (!end)
                        {
                            bUntrain_Click(sender, e);
                            if (lastSymbol != 1)
                            {
                                retest = true;
                            }
                        }
                    } while (!end);
                    if (lastSymbol != 4)
                    {
                        if (lastSymbol == 1) bPic2_Click(sender, e);
                        else if (lastSymbol == 2) bPic3_Click(sender, e);
                        else if (lastSymbol == 3) bPic4_Click(sender, e);
                    }
                }
            } while (retest);
        }
    }
}
