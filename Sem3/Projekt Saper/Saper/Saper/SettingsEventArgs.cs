using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    public class SettingsEventArgs : EventArgs
    {
        public  int width { get; }
        public int height { get; }
        public int mines { get; }
        public bool sound { get; }
        public Color color { get; }
        public String difficult { get; }
        public SettingsEventArgs(int w, int h, int m, bool s, Color c,string d)
        {
            width = w;
            height = h;
            mines = m;
            sound = s;
            color = c;
            difficult = d;
        }
    }
}
