using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships
{
    public class Ship
    {
        public Position position;
        public Type type;
        public bool IsReady = false;
        public bool IsAlive { get; set; }// cos trza zorboc xdd
        private int hitCount;
        int HitCount
        {
            get
            {
                return hitCount;
            }
            set
            {
                hitCount = value;
                if (hitCount == (int)type) IsAlive = false;
            }
        }
        public System.Drawing.Point[] Coordinates;
        private System.Drawing.Point startpos;
        public System.Drawing.Point StartPos
        {
            get
            {
                return startpos;
            }
            set
            {
                startpos = value;
                Coordinates = new System.Drawing.Point[(int)type];
                switch (position)
                {
                    case Ship.Position.Vertical:
                        for (int i = 0; i <(int)type; i++)
                        {
                            Coordinates[i] = new System.Drawing.Point(startpos.X, startpos.Y+i);
                        }
                        break;
                    case Ship.Position.Horizontal:
                        for (int i = 0; i < (int)type; i++)
                        {
                            Coordinates[i] = new System.Drawing.Point(startpos.X+i, startpos.Y);
                        }
                        break;
                }
            }
        }
        public void Hit()
        {
            HitCount++;
        }
        public void Reset()
        {
            HitCount = 0;
            IsAlive = true;
        }
        public Ship(Type type)
        {
            this.type = type;
            position = Position.Horizontal;
            IsAlive = true;
        }
        public enum Position
        {
            Vertical, //pionowy
            Horizontal, 
        }
        public enum Type
        {
            Submarine=1, //1
            Destroyer, //2
            Cruiser, //3
            Battleship, //4
        }

    }

    public static class Extension
    {
        public static string TranslateToPL(this Ship.Type type)
        {
            switch (type)
            {
                case Ship.Type.Battleship:
                    return "Pancernik";
                case Ship.Type.Destroyer:
                    return "Niszczyciel";
                case Ship.Type.Submarine:
                    return "Okręt podwodny";
                case Ship.Type.Cruiser:
                    return "Krążownik";
            }
            throw new NotImplementedException();
        }
    }
}
