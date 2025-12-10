using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleships
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int PlayerHitCount = 0;
        int PlayerMissCount = 0;
        int ComputerHitCount = 0;
        bool game = false;
        bool sound = true;
        WMPLib.WindowsMediaPlayer mediaPlayer = new WMPLib.WindowsMediaPlayer();
        Difficult difficult = Difficult.Easy;
        public enum Difficult
        {
            Easy=1, 
            Hard,
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Ship battleship = new Ship(Ship.Type.Battleship);
            Ship cruiser1 = new Ship(Ship.Type.Cruiser);
            Ship cruiser2 = new Ship(Ship.Type.Cruiser);
            Ship destroyer1 = new Ship(Ship.Type.Destroyer);
            Ship destroyer2 = new Ship(Ship.Type.Destroyer);
            Ship destroyer3 = new Ship(Ship.Type.Destroyer);
            Ship patrol1 = new Ship(Ship.Type.Submarine);
            Ship patrol2 = new Ship(Ship.Type.Submarine);
            Ship patrol3 = new Ship(Ship.Type.Submarine);
            Ship patrol4 = new Ship(Ship.Type.Submarine);

            Ship Cbattleship = new Ship(Ship.Type.Battleship);
            Ship Ccruiser1 = new Ship(Ship.Type.Cruiser);
            Ship Ccruiser2 = new Ship(Ship.Type.Cruiser);
            Ship Cdestroyer1 = new Ship(Ship.Type.Destroyer);
            Ship Cdestroyer2 = new Ship(Ship.Type.Destroyer);
            Ship Cdestroyer3 = new Ship(Ship.Type.Destroyer);
            Ship Cpatrol1 = new Ship(Ship.Type.Submarine);
            Ship Cpatrol2 = new Ship(Ship.Type.Submarine);
            Ship Cpatrol3 = new Ship(Ship.Type.Submarine);
            Ship Cpatrol4 = new Ship(Ship.Type.Submarine);
            CreatePlayerBoard(ref panelPlayer, ref bttn_PlayerBoard);
            CreateComputerBoard(ref panelComputer, ref bttn_ComputerBoard);
            CreateComputerCharBoard(ref char_ComputerBoard);
            bttn_Ships = new Button[] {bttnBattleship,bttnSubmarine1,bttnSubmarine2,
                                      bttnDestroyer1,bttnDestroyer2,bttnDestroyer3,
                                      bttnPatrol1,bttnPatrol2,bttnPatrol3,bttnPatrol4};
            PlayerShips = new Ship[] {battleship,cruiser1,cruiser2,
                                destroyer1,destroyer2,destroyer3,
                                patrol1,patrol2,patrol3,patrol4};
            ComputerShips = new Ship[] {Cbattleship,Ccruiser1,Ccruiser2,
                                Cdestroyer1,Cdestroyer2,Cdestroyer3,
                                Cpatrol1,Cpatrol2,Cpatrol3,Cpatrol4};
        }

        Ship[] PlayerShips;
        Ship[] ComputerShips;
        Button[,] bttn_PlayerBoard;
        Button[,] bttn_ComputerBoard;
        Button[] bttn_Ships;
        Button activeShip;
        char[,] char_ComputerBoard;

        Stream dice = Properties.Resources.Shake_Dice_SoundBible_com_1630587513;
        Stream bomb = Properties.Resources.Bomb_SoundBible_com_891110113;
        Stream splash = Properties.Resources.Video_Game_Splash_Ploor_699235037;
        Stream start = Properties.Resources._56778__rene__nuclear_alarm;
        Random rand = new Random();
        private void PlaySound(Stream s)
        {
            if(sound)
            {             
                    SoundPlayer player = new SoundPlayer(s);
                    s.Position = 0;
                    player.Play();              
            }
        }
        private void ButtonPlayerBoard_MouseHover(object sender, EventArgs e)
        {
            if(!game)
            {
                Button b = sender as Button;
                string[] split = b.Name.Split();
                int x = System.Convert.ToInt32(split[0]);
                int y = System.Convert.ToInt32(split[1]);
                if (b.BackColor == Color.RoyalBlue)
                {
                    for (int i = 0; i < bttn_Ships.Length; i++)
                    {
                        if (activeShip == bttn_Ships[i] && !PlayerShips[i].IsReady)
                        {
                            DrawShipGhost(x, y, PlayerShips[i], bttn_PlayerBoard);
                        }
                    }
                }
            }
        }
        private void ButtonPlayerBoard_MouseLeave(object sender, EventArgs e)
        {
            if(!game)
            {
                Button b = sender as Button;
                if (b.BackColor == Color.Green)
                {
                    RefreshBoard();
                }
            }
        }
        private void ButtonPlayerBoard_Click(object sender, EventArgs e)
        {
            if(!game)
            {
                Button b = sender as Button;
                string[] split = b.Name.Split();
                int x = System.Convert.ToInt32(split[0]);
                int y = System.Convert.ToInt32(split[1]);
                if (b.BackColor == Color.Green)
                {
                    for (int i = 0; i < bttn_Ships.Length; i++)
                    {
                        if (!PlayerShips[i].IsReady && activeShip == bttn_Ships[i])
                        {
                            DrawShipOnClick(x, y, PlayerShips[i], bttn_PlayerBoard);
                        }
                    }
                }
                else if (b.BackColor == Color.DimGray || b.BackColor == Color.Orange)
                {
                    for (int i = 0; i < bttn_Ships.Length; i++)
                    {
                        if (activeShip == bttn_Ships[i])
                        {
                            PlayerShips[i].IsReady = false;
                            RefreshBoard();
                        }
                    }
                }
            }
        }
        private void ButtonCompBoard_MouseHover(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.BackColor == Color.RoyalBlue)
            {
                b.BackColor = Color.Green;
            }
        }
        private void ButtonCompBoard_MouseLeave(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.BackColor == Color.Green)
            {
                b.BackColor = Color.RoyalBlue;            
            }
        }
        private void ButtonCompBoard_Click(object sender, EventArgs e)
        {
            if(game && Cursor != Cursors.No )
            {
                Button b = sender as Button;
                string[] split = b.Name.Split();
                int x = System.Convert.ToInt32(split[0]);
                int y = System.Convert.ToInt32(split[1]);

                    if (char_ComputerBoard[x, y] == '1')
                    {
                        Point p = new Point(x, y);

                            bttn_ComputerBoard[x, y].BackgroundImage = Properties.Resources.as_896_512;
                            bttn_ComputerBoard[x, y].BackgroundImageLayout = ImageLayout.Zoom;
                            PlaySound(bomb);
                            PlayerHitCount++;
                            richTextBox1.Select(richTextBox1.Text.Length, 0);
                            richTextBox1.SelectionColor = Color.Yellow;
                            richTextBox1.SelectedText = "\n" + ((char)(65 + y)).ToString() + (x + 1).ToString() + " Trafiony ";
                            for (int i = 0; i < ComputerShips.Length; i++)
                            {
                                for (int j = 0; j < ComputerShips[i].Coordinates.Length; j++)
                                {
                                    if (p == ComputerShips[i].Coordinates[j])
                                    {
                                        ComputerShips[i].Hit();
                                        if (!ComputerShips[i].IsAlive)
                                        {
                                            richTextBox1.SelectedText = " i zatopiony " + ComputerShips[i].type.TranslateToPL();
                                            switch (ComputerShips[i].position)
                                            {
                                                case Ship.Position.Vertical:
                                                    for (int k = -1; k < 2; k++)
                                                    {
                                                        for (int l = -1; l < (int)ComputerShips[i].type + 1; l++)
                                                        {
                                                            if (ComputerShips[i].StartPos.X + k < 10 && ComputerShips[i].StartPos.Y + l < 10
                                                                && ComputerShips[i].StartPos.X + k >= 0 && ComputerShips[i].StartPos.Y + l >= 0)
                                                            {
                                                                bttn_ComputerBoard[ComputerShips[i].StartPos.X + k, ComputerShips[i].StartPos.Y + l].Text = "X";
                                                                bttn_ComputerBoard[ComputerShips[i].StartPos.X + k, ComputerShips[i].StartPos.Y + l].Enabled = false;
                                                            }
                                                        }
                                                    }

                                                    break;
                                                case Ship.Position.Horizontal:
                                                    for (int k = -1; k < (int)ComputerShips[i].type + 1; k++)
                                                    {
                                                        for (int l = -1; l < 2; l++)
                                                        {
                                                            if (ComputerShips[i].StartPos.X + k < 10 && ComputerShips[i].StartPos.Y + l < 10
                                                                && ComputerShips[i].StartPos.X + k >= 0 && ComputerShips[i].StartPos.Y + l >= 0)
                                                            {
                                                                bttn_ComputerBoard[ComputerShips[i].StartPos.X + k, ComputerShips[i].StartPos.Y + l].Text = "X";
                                                                bttn_ComputerBoard[ComputerShips[i].StartPos.X + k, ComputerShips[i].StartPos.Y + l].Enabled = false;
                                                            }

                                                        }
                                                    }
                                                    break;
                                            }
                                            foreach (Point p2 in ComputerShips[i].Coordinates)
                                            {
                                                bttn_ComputerBoard[p2.X, p2.Y].Text = "";
                                            }
                                        }
                                    }
                                }
                            }
                        
                    }
                    else
                    {
                        bttn_ComputerBoard[x, y].Text = "X";
                        PlayerMissCount++;
                        richTextBox1.Select(richTextBox1.Text.Length, 0);
                        richTextBox1.SelectionColor = Color.Yellow;
                        richTextBox1.SelectedText = "\n" + ((char)(65 + y)).ToString() + (x + 1).ToString() + " Pudło ";
                        PlaySound(splash);
                        switch (difficult)
                        {
                            case Difficult.Easy:
                                Easy();
                                break;
                            case Difficult.Hard:
                                Hard();
                                break;
                        }
                }
                b.Enabled = false;
                if (PlayerHitCount == 20)
                {
                    //player win
                    richTextBox1.SelectedText = "\nWygrałeś\n";
                    Reset();
                    int score = ((20 - ComputerHitCount) * 10 - PlayerMissCount) * (int)difficult;
                    FormSaveScore saveScore = new FormSaveScore(score);
                    saveScore.ShowDialog();
                }
            }
        }
        private void BttnShip_Click(object sender, EventArgs e)
        {
            if(!game)
            {
                if (activeShip != null) activeShip.BackColor = Color.DimGray;
                if (activeShip != sender)
                {
                    RefreshBoard();
                    activeShip = sender as Button;
                    activeShip.BackColor = Color.Red;
                    timer1.Interval = 500;
                    timer1.Start();
                }
                else
                {
                    activeShip = null;
                    timer1.Stop();
                    RefreshBoard();
                }
            }
        }
        private void ButtonRotate_Click(object sender, EventArgs e)
        {
            if (activeShip != null && !game)
            {
                for (int i = 0; i < bttn_Ships.Length - 4; i++)
                {
                    if (activeShip == bttn_Ships[i] && !PlayerShips[i].IsReady)
                    {
                        if (PlayerShips[i].position == Ship.Position.Horizontal)
                        {
                            PlayerShips[i].position = Ship.Position.Vertical;
                        }
                        else PlayerShips[i].position = Ship.Position.Horizontal;
                    }
                }
            }
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (activeShip != null && !game)
            {
                for (int i = 0; i < bttn_Ships.Length; i++)
                {
                    if (activeShip == bttn_Ships[i])
                    {
                        PlayerShips[i].IsReady = false;
                        RefreshBoard();
                    }
                }
            }
        }

        private void ButtonRandomize_Click(object sender, EventArgs e)
        {
            if(!game)
            {
                PlaySound(dice);
                for (int i = 0; i < PlayerShips.Length; i++)
                {
                    PlayerShips[i].IsReady = false;
                }
                RefreshBoard();
                for (int i = 0; i < PlayerShips.Length; i++)
                {
                    DrawShipRand(PlayerShips[i], bttn_PlayerBoard);
                }
                RefreshBoard();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(!game)
            {
                for (int i = 0; i < bttn_Ships.Length; i++)
                {
                    if (activeShip == bttn_Ships[i] && PlayerShips[i].IsReady)
                    {
                        Blink(PlayerShips[i], bttn_PlayerBoard);
                    }
                }
            }
        }
        private void RefreshBoard()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    bttn_PlayerBoard[i, j].BackgroundImage = null;
                    bttn_PlayerBoard[i, j].BackColor = Color.RoyalBlue;
                    bttn_PlayerBoard[i, j].Text = "";
                }
            }
            foreach(Ship s in PlayerShips)
            {
                if (s.IsReady)
                {
                    DrawShip(s,bttn_PlayerBoard);
                }
            }
        }
        private void RefreshComputerBoard()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    bttn_ComputerBoard[i, j].Enabled = true;
                    bttn_ComputerBoard[i, j].BackColor = Color.RoyalBlue;
                    bttn_ComputerBoard[i, j].BackgroundImage = null;
                    bttn_ComputerBoard[i, j].Text = "";
                    char_ComputerBoard[i, j] = '3';
                }
            }
        }
        
        private void CreatePlayerBoard(ref Panel panel, ref Button [,] board)
        {
            board = new Button[10, 10];
            CreateButtonCoordinate(panel,0,0," ");
            for (int i = 1; i < 11; i++)
            {
                CreateButtonCoordinate(panel, (35 * i), (35 * 0),i.ToString());
                CreateButtonCoordinate(panel, (35 * 0), (35 * i),((char)(64+i)).ToString());
            }
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    board[x, y] = CreatePlayerBoardButton(panel,(35 * (x+1)),(35 * (y+1)), x, y);
                }
            }
        }
        private void CreateComputerBoard(ref Panel panel, ref Button[,] board)
        {
            board = new Button[10, 10];
            CreateButtonCoordinate(panel, 0, 0, " ");
            for (int i = 1; i < 11; i++)
            {
                CreateButtonCoordinate(panel, (35 * i), (35 * 0), i.ToString());
                CreateButtonCoordinate(panel, (35 * 0), (35 * i), ((char)(64 + i)).ToString());
            }
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    board[x, y] = CreateCompBoardButton(panel, (35 * (x + 1)), (35 * (y + 1)), x, y);
                }
            }
        }
        private void CreateComputerCharBoard(ref char[,] board)
        {
            board = new char[10, 10];
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    board[x, y] = '3';
                }
            }
        }
        private Button CreatePlayerBoardButton(Panel panel,int x, int y, int boardX, int boardY)
        {
            Button button = new Button();
            button.FlatStyle = FlatStyle.Popup;
            button.Text = "";
            button.Name = boardX.ToString() + " " + boardY.ToString();
            button.Size = new Size(35, 35);
            button.Location = new Point(x, y);
            button.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.Click += new System.EventHandler(ButtonPlayerBoard_Click);
            button.MouseLeave += new System.EventHandler(ButtonPlayerBoard_MouseLeave);
            button.MouseHover += new System.EventHandler(ButtonPlayerBoard_MouseHover);
            button.BackColor = Color.RoyalBlue;
            panel.Controls.Add(button);
            return button;
        }
        private Button CreateCompBoardButton(Panel panel, int x, int y, int boardX, int boardY)
        {
            Button button = new Button();
            button.FlatStyle = FlatStyle.Popup;
            button.Text = "";
            button.Name = boardX.ToString() + " " + boardY.ToString();
            button.Size = new Size(35, 35);
            button.Location = new Point(x, y);
            button.Cursor = Cursors.Cross;
            button.Font = new System.Drawing.Font("Lucida Handwriting", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.Click += new System.EventHandler(ButtonCompBoard_Click);
            button.MouseLeave += new System.EventHandler(ButtonCompBoard_MouseLeave);
            button.MouseHover += new System.EventHandler(ButtonCompBoard_MouseHover);
            button.BackColor = Color.RoyalBlue;
            panel.Controls.Add(button);
            return button;
        }
        private Button CreateButtonCoordinate(Panel panel, int x, int y,string text)
        {
            Button button = new Button();
            button.FlatStyle = FlatStyle.Popup;
            button.Text = text;
            button.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.Size = new Size(35, 35);
            button.Location = new Point(x, y);
            button.BackColor = Color.WhiteSmoke;
            button.Enabled = false;
            panel.Controls.Add(button);
            return button;
        }
        private void DrawShipGhost(int x,int y,Ship ship,Button [,] board)
        {
            bool freeField=true;
            switch (ship.position)
            {
                case Ship.Position.Vertical:
                    if (x < 10 && y <= 10-(int)ship.type)
                    {
                        for (int i = 0; i < (int)ship.type; i++)
                        {
                            if (y + i < 10
                                && y + i >= 0)
                            {
                                if (board[x, y + i].BackColor == Color.DarkRed) freeField = false;
                            }
                        }
                        if (freeField)
                        {
                            for (int i = -1; i < 2; i++)
                            {
                                for (int j = -1; j < 1 + (int)ship.type; j++)
                                {
                                    if (x + i < 10 && y + j < 10
                                        && x + i >= 0 && y + j >= 0)
                                    {
                                        if (board[x + i, y + j].BackColor == Color.DarkRed) ;
                                        else board[x + i, y + j].BackColor = Color.Red;
                                    }
                                }
                            }
                            for (int i = y; i < y + (int)ship.type; i++)
                            {
                                board[x, i].BackColor = Color.Green;
                            }
                        }
                    }
                    break;
                case Ship.Position.Horizontal:
                    if (x <= 10 - (int)ship.type && y < 10 )
                    {
                        for (int i = 0; i < (int)ship.type; i++)
                        {
                            if (x + i < 10
                                && x + i >= 0)
                            {
                                if (board[x + i, y].BackColor == Color.DarkRed) freeField = false;
                            }
                        }
                        if (freeField)
                        {
                            for (int i = -1; i < (int)ship.type+1; i++)
                            {
                                for (int j = -1; j < 2; j++)
                                {
                                    if (x + i < 10 && y + j < 10
                                        && x + i >= 0 && y + j >= 0)
                                    {
                                        if (board[x + i, y + j].BackColor == Color.DarkRed) ;
                                        else board[x + i, y + j].BackColor = Color.Red;
                                    }
                                }
                            }
                            for (int i = x; i < x + (int)ship.type; i++)
                            {
                                board[i, y].BackColor = Color.Green;
                            }
                        }
                    }
                    break;
            }
        }
        private void DrawShipOnClick(int x, int y, Ship ship, Button[,] board)
        {
            switch (ship.position)
            {
                case Ship.Position.Vertical:
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < (int)ship.type+1; j++)
                        {
                            if (x + i < 10 && y + j < 10
                                && x + i >= 0 && y + j >= 0)
                            {
                                board[x + i, y + j].BackColor = Color.DarkRed;
                            }
                        }
                    }
                    ship.StartPos = new Point(x, y);
                    foreach(Point p in ship.Coordinates)
                    {
                        board[p.X, p.Y].BackColor = Color.DimGray;
                    }
                    ship.IsReady = true;
                    break;
                case Ship.Position.Horizontal:
                    for (int i = -1; i < (int)ship.type + 1; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            if (x + i < 10 && y + j < 10
                                && x + i >= 0 && y + j >= 0)
                            {
                                board[x + i, y + j].BackColor = Color.DarkRed;
                            }
                        }
                    }
                    ship.StartPos = new Point(x, y);
                    foreach (Point p in ship.Coordinates)
                    {
                        board[p.X, p.Y].BackColor = Color.DimGray;
                    }
                    ship.IsReady = true;
                    break;
            }
        }
        private void DrawShipRand(Ship ship,Button [,] board)
        {
            int x=0, y=0;
            bool freeField = true;
            bool End = false;
            do
            {
                ship.position = (Ship.Position)rand.Next(0, 2);
                switch (ship.position)
                {
                    case Ship.Position.Vertical:

                        x = rand.Next(0, 10);
                        y = rand.Next(0, 11 - (int)ship.type);

                        for (int i = 0; i < (int)ship.type; i++)
                        {
                            if (y + i < 10 && y + i >= 0)
                            {
                                if (board[x, y + i].BackColor == Color.DarkRed ||
                                    board[x, y + i].BackColor == Color.DimGray)
                                {
                                    freeField = false;
                                    break;
                                }
                                else freeField = true;
                            }
                        }
                        if (freeField) End = true;

                        break;
                    case Ship.Position.Horizontal:

                        y = rand.Next(0, 10);
                        x = rand.Next(0, 11 - (int)ship.type);

                        for (int i = 0; i < (int)ship.type; i++)
                        {
                            if (x + i < 10 && x + i >= 0)
                            {
                                if (board[x + i, y].BackColor == Color.DarkRed ||
                                    board[x + i, y].BackColor == Color.DimGray)
                                {
                                    freeField = false;
                                    break;
                                }
                                else freeField = true;
                            }
                        }
                        if (freeField) End = true;

                        break;
                }
            }while(!End);
            ship.StartPos = new Point(x, y);

            DrawShip(ship,board);
        }
        private void DrawCharShipRand(Ship ship,ref char [,] board)
        {
            int x = 0, y = 0;
            bool freeField = true;
            bool End = false;
            do
            {
                ship.position = (Ship.Position)rand.Next(0, 2);
                switch (ship.position)
                {
                    case Ship.Position.Vertical:

                        x = rand.Next(0, 10);
                        y = rand.Next(0, 11 - (int)ship.type);

                        for (int i = 0; i < (int)ship.type; i++)
                        {
                            if (y + i < 10 && y + i >= 0)
                            {
                                if (board[x, y + i] == '2' ||
                                    board[x, y + i] == '1')
                                {
                                    freeField = false;
                                    break;
                                }
                                else freeField = true;
                            }
                        }
                        if (freeField) End = true;

                        break;
                    case Ship.Position.Horizontal:

                        y = rand.Next(0, 10);
                        x = rand.Next(0, 11 - (int)ship.type);

                        for (int i = 0; i < (int)ship.type; i++)
                        {
                            if (x + i < 10 && x + i >= 0)
                            {
                                if (board[x + i, y] == '2' ||
                                    board[x + i, y] == '1')
                                {
                                    freeField = false;
                                    break;
                                }
                                else freeField = true;
                            }
                        }
                        if (freeField) End = true;

                        break;
                }
            } while (!End);
            ship.StartPos = new Point(x, y);
            DrawCharShip(ship, ref board);
        }
        private void DrawCharShip(Ship ship, ref char[,] board)
        {
            Point p = ship.StartPos;
            int x = p.X;
            int y = p.Y;
            switch (ship.position)
            {
                case Ship.Position.Vertical:
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < (int)ship.type + 1; j++)
                        {
                            if (x + i < 10 && y + j < 10
                                && x + i >= 0 && y + j >= 0)
                            {
                                board[x + i, y + j] = '2';
                            }
                        }
                    }
                    foreach (Point p2 in ship.Coordinates)
                    {
                        board[p2.X, p2.Y]= '1';
                    }
                    ship.IsReady = true;
                    break;
                case Ship.Position.Horizontal:
                    for (int i = -1; i < (int)ship.type + 1; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            if (x + i < 10 && y + j < 10
                                && x + i >= 0 && y + j >= 0)
                            {
                                board[x + i, y + j] = '2';
                            }
                        }
                    }
                    foreach (Point p2 in ship.Coordinates)
                    {
                        board[p2.X, p2.Y] = '1';
                    }
                    ship.IsReady = true;
                    break;
            }
        }
        private void DrawShip(Ship ship,Button [,] board)
        {
            Point p2 = ship.StartPos;
            int x = p2.X;
            int y = p2.Y;
            switch (ship.position)
            {
                case Ship.Position.Vertical:
                    for (int i = -1; i < 2; i++)
                    {
                        for (int j = -1; j < (int)ship.type + 1; j++)
                        {
                            if (x + i < 10 && y + j < 10
                                && x + i >= 0 && y + j >= 0)
                            {
                                board[x + i, y + j].BackColor = Color.DarkRed;
                            }
                        }
                    }
                    foreach (Point p in ship.Coordinates)
                    {
                        board[p.X, p.Y].BackColor = Color.DimGray;
                    }
                    ship.IsReady = true;
                    break;
                case Ship.Position.Horizontal:
                    for (int i = -1; i < (int)ship.type + 1; i++)
                    {
                        for (int j = -1; j < 2; j++)
                        {
                            if (x + i < 10 && y + j < 10
                                && x + i >= 0 && y + j >= 0)
                            {
                                board[x + i, y + j].BackColor = Color.DarkRed;
                            }
                        }
                    }
                    foreach (Point p in ship.Coordinates)
                    {
                        board[p.X, p.Y].BackColor = Color.DimGray;
                    }
                    ship.IsReady = true;
                    break;
            }
        }
        private void Blink(Ship ship,Button [,] board)
        {
            foreach (Point p in ship.Coordinates)
            {
                if (board[p.X, p.Y].BackColor == Color.Orange) board[p.X, p.Y].BackColor = Color.DimGray;
                else board[p.X, p.Y].BackColor = Color.Orange;
            }
        }
        private void Easy()
        {
            bool found = false;
            do
            {
                int x = rand.Next(0, 10);
                int y = rand.Next(0, 10);
                if (bttn_PlayerBoard[x, y].BackColor == Color.RoyalBlue && bttn_PlayerBoard[x, y].Text != "X")
                {
                    PlaySound(splash);
                    richTextBox1.Select(richTextBox1.Text.Length, 0);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.SelectedText = "\n" + ((char)(65 + y)).ToString() + (x + 1).ToString() + " Pudło ";
                    richTextBox1.SelectionColor = Color.Lime;
                    richTextBox1.SelectedText = "\nKapitanie gdzie strzelac?";
                    bttn_PlayerBoard[x, y].Text = "X";
                    found = true;
                }
                else if (bttn_PlayerBoard[x, y].BackColor == Color.DimGray && bttn_PlayerBoard[x, y].BackgroundImage == null)
                {
                    CompHit(x, y);
                    found = true;    
                }
            } while(!found);
        }
        bool hit=false;
        Point lastHIt;
        Point firstHit;
        private void Hard()
        {
            bool found = false;
            do
            {
                if(hit)
                {                  
                    if (firstHit.X + 1 < 10 && bttn_PlayerBoard[firstHit.X + 1, firstHit.Y].BackgroundImage == null && bttn_PlayerBoard[firstHit.X + 1, firstHit.Y].Text != "X")
                    {
                        Hard2(firstHit.X + 1, firstHit.Y);
                        found = true;
                    }
                    else if (firstHit.X + 2 <10 && bttn_PlayerBoard[firstHit.X + 2, firstHit.Y].BackgroundImage == null && bttn_PlayerBoard[firstHit.X + 2, firstHit.Y].Text != "X")
                    {
                        Hard2(firstHit.X +2, firstHit.Y);
                        found = true;
                    }
                    else if (firstHit.X + 3 <10 &&  bttn_PlayerBoard[firstHit.X + 3, firstHit.Y].BackgroundImage == null && bttn_PlayerBoard[firstHit.X + 3, firstHit.Y].Text != "X")
                    {
                        Hard2(firstHit.X + 3, firstHit.Y);
                        found = true;
                    }
                    else if (firstHit.X - 1 >= 0 && bttn_PlayerBoard[firstHit.X - 1, firstHit.Y].BackgroundImage == null && bttn_PlayerBoard[firstHit.X - 1, firstHit.Y].Text != "X")
                    {
                        Hard2(firstHit.X - 1, firstHit.Y);
                        found = true;
                    }
                    else if (firstHit.X - 2 >= 0 && bttn_PlayerBoard[firstHit.X - 2, firstHit.Y].BackgroundImage == null && bttn_PlayerBoard[firstHit.X - 2, firstHit.Y].Text != "X")
                    {
                        Hard2(firstHit.X - 2, firstHit.Y);
                        found = true;
                    }
                    else if (firstHit.X - 3 >= 0 && bttn_PlayerBoard[firstHit.X - 3, firstHit.Y].BackgroundImage == null && bttn_PlayerBoard[firstHit.X - 3, firstHit.Y].Text != "X")
                    {
                        Hard2(firstHit.X - 3, firstHit.Y);
                        found = true;
                    }
                    else if (firstHit.Y + 1 < 10 && bttn_PlayerBoard[firstHit.X, firstHit.Y + 1].BackgroundImage == null && bttn_PlayerBoard[firstHit.X, firstHit.Y + 1].Text != "X")
                    {
                        Hard2(firstHit.X, firstHit.Y + 1);
                        found = true;
                    }
                    else if (firstHit.Y + 2 < 10 && bttn_PlayerBoard[firstHit.X, firstHit.Y + 2].BackgroundImage == null && bttn_PlayerBoard[firstHit.X, firstHit.Y + 2].Text != "X")
                    {
                        Hard2(firstHit.X, firstHit.Y + 2);
                        found = true;
                    }
                    else if (firstHit.Y + 3 < 10 && bttn_PlayerBoard[firstHit.X, firstHit.Y + 3].BackgroundImage == null && bttn_PlayerBoard[firstHit.X, firstHit.Y + 3].Text != "X")
                    {
                        Hard2(firstHit.X, firstHit.Y + 3);
                        found = true;
                    }
                    else if (firstHit.Y - 1 >= 0 && bttn_PlayerBoard[firstHit.X, firstHit.Y - 1].BackgroundImage == null && bttn_PlayerBoard[firstHit.X, firstHit.Y - 1].Text != "X")
                    {
                        Hard2(firstHit.X, firstHit.Y - 1);
                        found = true;
                    }
                    else if (firstHit.Y - 2 >= 0 && bttn_PlayerBoard[firstHit.X, firstHit.Y - 2].BackgroundImage == null && bttn_PlayerBoard[firstHit.X, firstHit.Y - 2].Text != "X")
                    {
                        Hard2(firstHit.X, firstHit.Y - 2);
                        found = true;
                    }
                    else if (firstHit.Y - 3 >= 0 &&  bttn_PlayerBoard[firstHit.X, firstHit.Y - 3].BackgroundImage == null && bttn_PlayerBoard[firstHit.X, firstHit.Y-3].Text != "X")
                    {
                        Hard2(firstHit.X, firstHit.Y - 3);
                        found = true;
                    }
                    else firstHit = lastHIt;
                }
                else
                {
                    int x = rand.Next(0, 10);
                    int y = rand.Next(0, 10);
                    
                    
                    if (bttn_PlayerBoard[x, y].BackColor == Color.RoyalBlue && bttn_PlayerBoard[x, y].Text != "X")
                    {
                        PlaySound(splash);
                        richTextBox1.Select(richTextBox1.Text.Length, 0);
                        richTextBox1.SelectionColor = Color.Red;
                        richTextBox1.SelectedText = "\n" + ((char)(65 + y)).ToString() + (x + 1).ToString() + " Pudło ";
                        richTextBox1.SelectionColor = Color.Lime;
                        richTextBox1.SelectedText = "\nKapitanie gdzie strzelac?";
                        bttn_PlayerBoard[x, y].Text = "X";
                        found = true;
                    }
                    else if (bttn_PlayerBoard[x, y].BackColor == Color.DimGray && bttn_PlayerBoard[x, y].BackgroundImage == null)
                    {
                        CompHit(x, y);
                        found = true;
                    }
                }             
            } while (!found);
        }
        private void Hard2(int x,int y)
        {
            if (bttn_PlayerBoard[x, y].BackColor == Color.RoyalBlue && bttn_PlayerBoard[x, y].Text != "X")
            {
                PlaySound(splash);
                richTextBox1.Select(richTextBox1.Text.Length, 0);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.SelectedText = "\n" + ((char)(65 + y)).ToString() + (x + 1).ToString() + " Pudło ";
                richTextBox1.SelectionColor = Color.Lime;
                richTextBox1.SelectedText = "\nKapitanie gdzie strzelac?";
                bttn_PlayerBoard[x, y].Text = "X";
            }
            else if (bttn_PlayerBoard[x, y].BackColor == Color.DimGray && bttn_PlayerBoard[x, y].BackgroundImage == null)
            {
                CompHit(x, y);
            }
        }
        private void CompHit(int x,int y)
        {
            PlaySound(bomb);
            richTextBox1.Select(richTextBox1.Text.Length, 0);
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.SelectedText = "\n" + ((char)(65 + y)).ToString() + (x + 1).ToString() + " Trafiony ";
            bttn_PlayerBoard[x, y].BackgroundImage = Properties.Resources.as_896_512;
            bttn_PlayerBoard[x, y].BackgroundImageLayout = ImageLayout.Zoom;
            ComputerHitCount++;
            Point p = new Point(x, y);
            if(hit==false)firstHit = p;
            lastHIt = p;
            hit = true;
            for (int i = 0; i < PlayerShips.Length; i++)
            {
                for (int j = 0; j < PlayerShips[i].Coordinates.Length; j++)
                {
                    if (p == PlayerShips[i].Coordinates[j])
                    {
                        PlayerShips[i].Hit();
                        if (!PlayerShips[i].IsAlive)
                        {
                            hit = false;
                            richTextBox1.SelectedText = "i zatopiony " + PlayerShips[i].type.TranslateToPL();
                            switch (PlayerShips[i].position)
                            {
                                case Ship.Position.Vertical:
                                    for (int k = -1; k < 2; k++)
                                    {
                                        for (int l = -1; l < (int)PlayerShips[i].type + 1; l++)
                                        {
                                            if (PlayerShips[i].StartPos.X + k < 10 && PlayerShips[i].StartPos.Y + l < 10
                                                && PlayerShips[i].StartPos.X + k >= 0 && PlayerShips[i].StartPos.Y + l >= 0)
                                            {
                                                bttn_PlayerBoard[PlayerShips[i].StartPos.X + k, PlayerShips[i].StartPos.Y + l].Text = "X";
                                            }
                                        }
                                    }
                                    break;
                                case Ship.Position.Horizontal:
                                    for (int k = -1; k < (int)PlayerShips[i].type + 1; k++)
                                    {
                                        for (int l = -1; l < 2; l++)
                                        {
                                            if (PlayerShips[i].StartPos.X + k < 10 && PlayerShips[i].StartPos.Y + l < 10
                                                && PlayerShips[i].StartPos.X + k >= 0 && PlayerShips[i].StartPos.Y + l >= 0)
                                            {
                                                bttn_PlayerBoard[PlayerShips[i].StartPos.X + k, PlayerShips[i].StartPos.Y + l].Text = "X";
                                            }
                                        }
                                    }
                                    break;
                            }
                            foreach (Point p2 in PlayerShips[i].Coordinates)
                            {
                                bttn_PlayerBoard[p2.X, p2.Y].Text = "";
                            }

                        }
                    }
                }
            }
            if (ComputerHitCount == 20)
            {
                ///comp wins
                richTextBox1.SelectedText = "\nPrzegrałeś\n";
                FormLose lose = new FormLose();
                lose.ShowDialog();
                Reset();
            }
            else
            {
                switch (difficult)
                {
                    case Difficult.Easy:
                        Easy();
                        break;
                    case Difficult.Hard:
                        Hard();
                        break;
                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if(!game)
            {
                game = true;
                activeShip = null;
                for (int i = 0; i < PlayerShips.Length; i++)
                {
                    if (!PlayerShips[i].IsReady)
                    {
                        game = false;
                    }
                }
                if (game)
                {
                    PlaySound(start);
                    richTextBox1.Text = "";
                    buttonStartStop.Text = "Stop";
                    RefreshBoard();
                    RefreshComputerBoard();
                    ComputerHitCount = 0;
                    PlayerHitCount = 0;
                    PlayerMissCount = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            if (bttn_PlayerBoard[i, j].BackColor == Color.DarkRed) bttn_PlayerBoard[i, j].BackColor = Color.RoyalBlue;
                        }
                    }
                    for (int i = 0; i < ComputerShips.Length; i++)
                    {
                        bttn_Ships[i].BackColor = Color.DimGray;
                        DrawCharShipRand(ComputerShips[i], ref char_ComputerBoard);
                    }

                    int firstShot = rand.Next(0, 2);

                    if (firstShot == 0)
                    {
                        richTextBox1.SelectionColor = Color.Lime;
                        richTextBox1.SelectedText = "Kapitanie, pierwszy strzał należy do nas";

                    }
                    else
                    {
                        richTextBox1.SelectionColor = Color.Lime;
                        richTextBox1.SelectedText = "Kapitanie, przeciwnik zaczyna";
                        switch(difficult)
                        {
                            case Difficult.Easy:
                                    Easy();
                                break;
                            case Difficult.Hard:
                                    Hard();
                                break;
                        }
                    }
                }
                else MessageBox.Show("Nie ustawiono wszystkich statków", "",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                richTextBox1.SelectionColor = Color.Lime;
                richTextBox1.SelectedText = "\nZakończono gre";
                Reset();
            }

        }
        private void Reset()
        {
            game = false;
            hit = false;
            buttonStartStop.Text = "Start";
            RefreshBoard();
            RefreshComputerBoard();
            for(int i =0; i<PlayerShips.Length;i++)
            {
                PlayerShips[i].Reset();
                ComputerShips[i].Reset();
            }
        }
        private void ToolStripMenuItemSound_Click(object sender, EventArgs e)
        {
            if (SoundtoolStripMenuItem.Checked)
            {
                SoundtoolStripMenuItem.Checked = false;
                sound = false;
            }
            else
            {
                SoundtoolStripMenuItem.Checked = true;
                sound = true;
            }
        }

        private void EasyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!game)
            {
                EasyToolStripMenuItem.Checked = true;
                HardToolStripMenuItem.Checked = false;
                difficult = Difficult.Easy;
            }        
        }

        private void HardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!game)
            { 
                EasyToolStripMenuItem.Checked = false;
                HardToolStripMenuItem.Checked = true;
                difficult = Difficult.Hard;
            }
        }

        private void MusictoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MusictoolStripMenuItem.Checked) 
            {
                MusictoolStripMenuItem.Checked = false;
                mediaPlayer.controls.stop();
            }
            else
            {
                MusictoolStripMenuItem.Checked = true;
                mediaPlayer.URL = ".\\menu.mp3";
                mediaPlayer.controls.play();
            }
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Naprawdę?","Zakończ", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result==DialogResult.Yes) Dispose();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if(!game)
            {
                FileStream fs;
                if (File.Exists(Path.GetFileName("..\\Scores.txt")))
                {
                    richTextBox1.Text = "";
                    richTextBox1.SelectionColor = Color.Lime;
                    richTextBox1.SelectedText = "Wyniki:\n";
                    fs = new FileStream(Path.GetFileName("..\\Scores.txt"), FileMode.Open);
                    BinaryReader br = new BinaryReader(fs);
                    int count = br.ReadInt32();
                    for (int y = 0; y < count; y++)
                    {
                        richTextBox1.SelectionColor = Color.Yellow;
                        if (y % 2 == 0) richTextBox1.SelectionColor = Color.Red;
                        richTextBox1.SelectedText = br.ReadInt32() + " " + br.ReadString() + "\n";
                    }
                    br.Dispose();
                    fs.Dispose();
                }
            }
        }
    }
}
