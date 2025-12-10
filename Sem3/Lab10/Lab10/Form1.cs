using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;



namespace Lab10
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;

        }

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        private Vector GetPointInTriangle(Random rand, Vector a, Vector b, Vector c)
        {
            Vector ab = b - a;
            Vector ac = c - a;

            double r = rand.NextDouble();       //  % along ab
            double s = rand.NextDouble();       //  % along ac

            if (r + s >= 1d)
            {
                r = 1d - r;
                s = 1d - s;
            }

            //  Now add the two weighted vectors to a
            return a + ((ab * r) + (ac * s));
        }
        string path = "";
        Random rand = new Random();

        static int Bombs = 10;

        Vector[] bombArray1 = new Vector[Bombs];
        Vector[] bombArray2 = new Vector[Bombs];
        Vector[] bombArray3 = new Vector[Bombs];

        Color[] bombArratCol = new Color[Bombs];

        Vector vector1 = new Vector(0, 350);
        Vector vector2 = new Vector(250, 350);
        Vector vector3 = new Vector(125, 200);
        Vector vector4 = new Vector(0, 260);
        Vector vector5 = new Vector(250, 260);
        Vector vector6 = new Vector(125, 100);
        Vector vector7 = new Vector(25, 160);
        Vector vector8 = new Vector(225, 160);
        Vector vector9 = new Vector(125, 30);

        PointF point1 = new PointF(0, 350);
        PointF point2 = new PointF(250, 350);
        PointF point3 = new PointF(125, 200);
        PointF point4 = new PointF(0, 260);
        PointF point5 = new PointF(250, 260);
        PointF point6 = new PointF(125, 100);
        PointF point7 = new PointF(25, 160);
        PointF point8 = new PointF(225, 160);
        PointF point9 = new PointF(125, 30);
        PointF point10 = new PointF(125, 0);
        PointF point11 = new PointF(70, 80);
        PointF point12 = new PointF(125, 50);
        PointF point13 = new PointF(175, 80);
        PointF point14 = new PointF(60, 20);
        PointF point15 = new PointF(180, 20);

        Pen goldPen = new Pen(Color.Gold, 10);
        Pen silverPen = new Pen(Color.Silver, 10);
        Pen lightPen = new Pen(Color.Red, 4);
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics tree;
            tree = e.Graphics;

            PointF[] Triangle1 =
                 {
                     point1,
                     point2,
                     point3,
                 };
            PointF[] Triangle2 =
                 {
                     point4,
                     point5,
                     point6,
                 };
            PointF[] Triangle3 =
                {
                     point7,
                     point8,
                     point9,
                };
            PointF[] Ligths1 =
                {
                    point1,
                    point2,
                    point3,
                    point4,
                    point5,
                    point6,
                    point7,
                    point8,
                };
            PointF[] Lights2 =
    {
                    point2,
                    point1,
                    point3,
                    point5,
                    point4,
                    point6,
                    point8,
                    point7,
                };

            PointF[] Star1 =
                {
                    point10,
                    point11,
                    point12,
                    point13,
                };
            PointF[] Star2=
                {                
                    point15,
                    point14,
                    point12,
                };
            PointF[] GoldChain =
                {
                    point11,
                    point13,
                    point7,
                    point8,
                    point4,
                    point5,
                    point1,
                    point2,
                };
            PointF[] SilverChain =
    {
                    point13,
                    point11,
                    point8,
                    point7,
                    point5,
                    point4,
                    point2,
                    point1,
                    
                };

            Rectangle stem = new Rectangle(90, 350, 70, 50);
            Rectangle gift1 = new Rectangle(0,330,100 ,100 );
            Rectangle gift2 = new Rectangle(150,320,200,100);



            if (checkBoxTree.Checked == true)
            {     
                tree.FillPolygon(Brushes.Green, Triangle1);
                tree.FillPolygon(Brushes.Green, Triangle2);
                tree.FillPolygon(Brushes.Green, Triangle3);
                tree.FillRectangle(Brushes.Brown, stem);
                if (checkBoxChains.Checked == true)
                {
                    tree.DrawCurve(goldPen, GoldChain);
                    tree.DrawCurve(silverPen, SilverChain);
                }
                if (checkBoxLights.Checked == true)
                {
                    tree.DrawCurve(lightPen, Ligths1);
                    tree.DrawCurve(lightPen, Lights2);

                }
                if (checkBoxBombs.Checked == true)
                {

                    Brush newBrush;
                    for (int i = 0; i < Bombs; i++)
                    {
                        newBrush = new SolidBrush(bombArratCol[i]);
                        tree.FillPie(newBrush, (float)bombArray1[i].X, (float)bombArray1[i].Y, 25, 25, 0, 360);
                        tree.FillPie(newBrush, (float)bombArray2[i].X, (float)bombArray2[i].Y, 25, 25, 0, 360);
                        tree.FillPie(newBrush, (float)bombArray3[i].X, (float)bombArray3[i].Y, 25, 25, 0, 360);

                    }
                }
                if (checkBoxGifts.Checked == true)
                {
                    tree.FillRectangle(Brushes.Aquamarine, gift1);
                    tree.DrawLine(goldPen, 0, 370, 100, 370);
                    tree.DrawLine(goldPen, 50, 330, 50, 400);
                    tree.FillRectangle(Brushes.Red, gift2);
                    tree.DrawLine(silverPen, 150, 360, 250, 360);
                    tree.DrawLine(silverPen, 200, 320, 200, 400);
                }
                if (checkBoxStar.Checked == true)
                {
                    tree.FillPolygon(Brushes.DeepPink, Star1);
                    tree.FillPolygon(Brushes.DeepPink, Star2);
                }


            }
           
        }
        


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLights.Checked == true) timer1.Start();
            else timer1.Stop();
            panel1.Refresh();                      
        }

        private void checkBoxChains_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void checkBoxGifts_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void checkBoxStar_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void checkBoxBombs_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxBombs.Checked == true)
            {
                if(bombArray1!=null)
                {
                    for (int i = 0; i < Bombs; i++)
                    {
                        Vector newVector1 = GetPointInTriangle(rand, vector1, vector2, vector3);
                        Vector newVector2 = GetPointInTriangle(rand, vector4, vector5, vector6);
                        Vector newVector3 = GetPointInTriangle(rand, vector7, vector8, vector9);
                        bombArray1[i] = newVector1;
                        bombArray2[i] = newVector2;
                        bombArray3[i] = newVector3;
                        bombArratCol[i] = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                    }
                }

            }
            panel1.Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //  lightPen.Color = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            if (lightPen.Color == Color.Red) lightPen.Color = Color.Blue;
            else lightPen.Color = Color.Red;
            panel1.Refresh();
        }

        private void checkBoxMelody_CheckedChanged(object sender, EventArgs e)
        {
                if(checkBoxMelody.Checked == true)
                {
                 player.URL = "./jingle-bells-country.mp3";
                 player.controls.play();
            }
                else player.controls.stop();
        }
    }
}
