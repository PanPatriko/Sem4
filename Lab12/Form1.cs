using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Point3DS> StructList = new List<Point3DS>();
        List<Point3DC> ClassList = new List<Point3DC>();
        Random rand = new Random();
        ErrorProvider errprov = new ErrorProvider();

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(!double.TryParse(textBoxX.Text,out double x))
            {
                errprov.SetError(textBoxX, "Niepoprawna wartość");
            }
            else if (!double.TryParse(textBoxY.Text, out double y))
            {
                errprov.SetError(textBoxY, "Niepoprawna wartość");
            }
            else if (!double.TryParse(textBoxZ.Text, out double z))
            {
                errprov.SetError(textBoxZ, "Niepoprawna wartość");
            }
            else
            {
                errprov.Clear();
                if (radioButtonStruct.Checked)
                {
                    Point3DS p = new Point3DS(x, y, z);
                    StructList.Add(p);
                }
                else
                {
                    Point3DC p = new Point3DC(x, y, z);
                    ClassList.Add(p);
                }
            }
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (!int.TryParse(textBoxFrom.Text, out int a))
                {
                    errprov.SetError(textBoxFrom, "Niepoprawna wartość");
                }
                else if (!int.TryParse(textBoxTo.Text, out int b))
                {
                    errprov.SetError(textBoxTo, "Niepoprawna wartość");
                }
                else if (a > b || a < 0 || b < 0)
                {
                    errprov.SetError(checkBox1, "Niepoprawny zakres");
                }
                else
                {
                    errprov.Clear();
                    listBoxStruct.Items.Clear();
                    listBoxClass.Items.Clear();
                    if (a < StructList.Count && b <= StructList.Count)
                    {
                        for (int i = a; i < b; i++)
                        {
                            listBoxStruct.Items.Add(StructList[i]);
                        }
                    }
                    if (a < ClassList.Count && b <= ClassList.Count)
                    {
                        for (int i = a; i < b; i++)
                        {
                            listBoxClass.Items.Add(ClassList[i]);
                        }
                    }
                }
            }
            else
            {
                listBoxStruct.Items.Clear();
                foreach (var p in StructList)
                {
                    listBoxStruct.Items.Add(p);
                }
                listBoxClass.Items.Clear();
                foreach (var p in ClassList)
                {
                    listBoxClass.Items.Add(p);
                }
            }

        }

        private void ButtonFill_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxN.Text, out int n))
            {
                errprov.SetError(textBoxN, "Niepoprawna wartość");
            }
            else
            {
                errprov.Clear();
                listBoxClass.Items.Clear();
                listBoxStruct.Items.Clear();
                StructList.Clear();
                ClassList.Clear();
                double x, y, z;
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                for (int i=0;i<n;i++)
                {
                    x = Math.Round(rand.NextDouble(),6);
                    y = Math.Round(rand.NextDouble(),6);
                    z = Math.Round(rand.NextDouble(),6);
                    Point3DS p = new Point3DS(x, y, z);
                    StructList.Add(p);
                }
                stopWatch.Stop();
                labelSTime.Text = "Struktura "+ stopWatch.Elapsed;
                GC.Collect();
                stopWatch.Restart();
                for (int i = 0; i < n; i++)
                {
                    x = Math.Round(rand.NextDouble(), 6);
                    y = Math.Round(rand.NextDouble(), 6);
                    z = Math.Round(rand.NextDouble(), 6);
                    Point3DC p = new Point3DC(x, y, z);
                    ClassList.Add(p);
                }
                stopWatch.Stop();
                labelCTime.Text = "Klasa      "+ stopWatch.Elapsed;
                GC.Collect();
            }
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            IEnumerable<Point3DC> sortedPoints = from point in ClassList
                                                 orderby point.X, point.Y, point.Z
                                                 select point;
            ClassList = sortedPoints.ToList();
            stopWatch.Stop();
            labelCTime.Text = "Klasa      " + stopWatch.Elapsed;
            stopWatch.Restart();
            IEnumerable<Point3DS> sortedPoints2 = from point in StructList
                                                 orderby point.X, point.Y, point.Z
                                                 select point;
            StructList = sortedPoints2.ToList();
            stopWatch.Stop();
            labelSTime.Text = "Struktura " + stopWatch.Elapsed;
        }
    }
    public struct Point3DS
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3DS(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
        public override string ToString()
        {
            return "X:" + X.ToString() + " Y:" + Y.ToString() + " Z:" + Z.ToString();
        }
    }
    public class Point3DC
    {
        public  double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3DC(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }
        public override string ToString()
        {
            return "X:" + X.ToString() + " Y:" + Y.ToString() + " Z:" + Z.ToString();
        }
    }
}
