using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Saper
{
    public partial class FormGra : Form
    {
        public FormGra()
        {
            InitializeComponent();
            createBoard();
            timer1.Interval = 1000;
        }

        Color color;
        Random rand = new Random();
        Stream tick = Properties.Resources.Tick;
        Stream bomb = Properties.Resources.Bomb;
        Button[,] btn_board;
        bool game = false;
        bool first = true;
        int width = 9;
        int height = 9;
        int mines = 10;
        bool[,] board;
        bool sound = true;
        int flagsCounter = 0;
        int goodflagsCounter = 0;
        int coveredSquares = 9*9;
        String difficult = "Easy";

        private void button1_Click(object sender, EventArgs e)
        {
            stopGame();
            if (first == true)
            {
                game = true;
                timer1.Start();
                first = false;
            }
            else
            {
                game = true;
                clearBoard();
                createBoard();
                timer1.Start();
            }

        }

        private void button_MouseClick(object sender,MouseEventArgs e)
        {
            if (game == true)
            {
                Button clicked_button = sender as Button;
                string[] split = clicked_button.Name.Split();
                int w = System.Convert.ToInt32(split[0]);
                int h = System.Convert.ToInt32(split[1]);

                if (e.Button == MouseButtons.Right)
                {
                    if (btn_board[w, h].Image == null)
                    {
                        if (board[w, h] == true) goodflagsCounter++;
                        flagsCounter++;
                        btn_board[w, h].Image = Properties.Resources.flag_16;
                    }
                    else
                    {
                        if (board[w, h] == true) goodflagsCounter--;
                        flagsCounter--;
                        btn_board[w, h].Image = null;
                    }
                }
                else if (e.Button == MouseButtons.Left && btn_board[w, h].Image==null)
                {
                    
                    if (board[w, h] == true)
                    {
                        stopGame();
                        if (sound == true)
                        {
                            SoundPlayer player = new SoundPlayer(bomb);
                            bomb.Position = 0;     // Manually rewind stream 
                            player.Play();
                        }
                        for (int hh = 0; hh < height; hh++)
                        {
                            for (int ww = 0; ww < width; ww++)
                            {
                                if (board[ww, hh] == true)
                                {
                                    btn_board[ww, hh].Image = Properties.Resources.bomb_icon;
                                }
                            }
                        }
                        MessageBox.Show("BUM!!!\r\nPrzegrałeś");
                    }
                    else
                    {
                        RemoveSquare(w, h);
                    }               
                }
            }

            if (goodflagsCounter==mines && goodflagsCounter==flagsCounter && mines == coveredSquares)
            {
                stopGame();
                MessageBox.Show("BRAWO!!!\r\nWygrałeś!");
                if (difficult != "Custom")
                {
                    FormZapiszWynik wynik = new FormZapiszWynik(difficult,Int32.Parse(labelTime.Text));
                    wynik.ShowDialog();
                }

            }

        }

        private void ustawieniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUstawienia ustawienia = new FormUstawienia();
            ustawienia.SettingsEvent += new EventHandler<SettingsEventArgs>(ustawienia_SettingsEvent);
            ustawienia.ShowDialog();
        }

        private void ustawienia_SettingsEvent(object sender,SettingsEventArgs e)
        {
            width = e.width;
            height = e.height;
            mines = e.mines;
            sound = e.sound;
            color = e.color;
            difficult = e.difficult;

            first = true;
            stopGame();
            clearBoard();
            createBoard();
        }

        private void wynikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWyniki wyniki = new FormWyniki();
            wyniki.ShowDialog();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(sound == true)
            {
                SoundPlayer player = new SoundPlayer(tick);
                tick.Position = 0;     // Manually rewind stream 
            //  player.Stream = null;    // Then we have to set stream to null 
            // player.Stream = s;  // And set it again, to force it to be loaded again... 
                player.Play();
            }
            labelTime.Text = (Int32.Parse(labelTime.Text) + 1).ToString();
        }

        ///METODY
        private Button createButton(int x, int y, int boardX, int boardY)
        {
            Button button = new Button();

            button.Text = "";
            button.Name = boardX.ToString() + " " + boardY.ToString();
            button.Size = new Size(25, 25);
            button.Location = new Point(x, y);
            Controls.AddRange(new Control[] { button, });
            button.MouseDown += new MouseEventHandler(button_MouseClick);
            button.BackColor = color;
            return button;
        }
        private void stopGame()
        {
            timer1.Stop();
            game = false;
            flagsCounter = 0;
            goodflagsCounter = 0;
            coveredSquares = width * height;
        }
        private void createBoard()
        {
            
            labelTime.Text = "0";
            board = new bool[width, height];
            btn_board = new Button[width, height];

            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    board[w, h] = false;
                    btn_board[w, h] = createButton((w + 25 * w), (h + 25 * h) + 60, w, h);
                }
            }

            int counter = 0;

            do
            {
                int h = rand.Next(0, height);
                int w = rand.Next(0, width);
                if (board[w, h] == false)
                {
                    board[w, h] = true;
                 //   btn_board[w, h].Text = "B";
                    counter++;
                }
            } while (counter != mines);

            Height = 28 * height + 80;
            Width = 28 * width;
        }
        private void clearBoard()
        {
            if (btn_board != null)
            {
                for (int w = 0; w < btn_board.GetLength(0); w++)
                {
                    for (int h = 0; h < btn_board.GetLength(1); h++)
                    {
                        if (Controls.Contains(btn_board[w, h]))
                        {
                            btn_board[w, h].MouseDown -= button_MouseClick;
                            Controls.Remove(btn_board[w, h]);
                        }

                    }
                }
            }

        }
        private void RemoveSquare(int w,int h)
        {
            int bombcounter = 0;
            if (btn_board[w, h].Enabled == false) return;
            if (btn_board[w, h].Image != null) return;
            {
                btn_board[w, h].Enabled = false;
                coveredSquares--; 
                btn_board[w, h].BackColor = Color.White;
                for (int i = -1;i<2;i++)
                {
                    for (int j = -1; j < 2; j++)
                    {
                        if ((h + i >= 0) && (h + i < height) && (w + j >= 0) && (w + j < width))
                        {
                            if (board[w + j, h + i] == true)
                            {
                                bombcounter++;
                            }
                        }
                    }
                }
                if(bombcounter==0)
                {
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            if ((h + i >= 0) && (h + i < height) && (w + j >= 0) && (w + j < width))
                            {
                                 if(board[w+j, h+i]==false)RemoveSquare(w + j, h + i);                                                                    
                            }
                        }

                    }
                }
                else btn_board[w, h].Text = bombcounter.ToString();
            }
        }  
    }
}
