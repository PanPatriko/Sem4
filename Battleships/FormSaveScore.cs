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

namespace Battleships
{
    public partial class FormSaveScore : Form
    {
        int score;
        public FormSaveScore(int score)
        {
            InitializeComponent();
            this.score = score;
            label1.Text = "Wynik: " + score.ToString();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                FileStream fs;
                List<Score> scoresList = new List<Score>();
                int count = 0;
                if(File.Exists(Path.GetFileName("..\\Scores.txt")))
                {
                    fs = new FileStream(Path.GetFileName("..\\Scores.txt"), FileMode.Open);
                    BinaryReader br = new BinaryReader(fs);
                    count = br.ReadInt32();
                    for (int y = 0; y < count; y++)
                    {
                        Score s = new Score(br.ReadInt32(), br.ReadString());
                        scoresList.Add(s);
                    }
                    br.Dispose();
                    fs.Dispose();
                }
                count++;
                scoresList.Add(new Score(score, textBox1.Text));
                IEnumerable<Score> sortedScores = from s in scoresList
                                                  orderby s.score
                                                  select s;
                scoresList = sortedScores.ToList();
                scoresList.Reverse();
                fs = new FileStream(Path.GetFileName("..\\Scores.txt"), FileMode.Create);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(count);
                foreach(Score s in scoresList)
                {
                    bw.Write(s.score);
                    bw.Write(s.nickname);
                }
                bw.Dispose();
                fs.Dispose();
            }
            Dispose();
        }
    }
    public struct Score
    {
        public int score { get; set; }
        public string nickname { get; set; }

        public Score(int score,string nick)
        {
            this.score = score;
            nickname = nick;
        }
    }
}
