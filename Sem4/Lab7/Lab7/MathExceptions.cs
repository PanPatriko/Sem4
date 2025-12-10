using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public class MathExceptions 
    {
        public void WriteToFile(string text)
        {
                FileStream fs = new FileStream(Directory.GetCurrentDirectory() + "\\Errors.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(DateTime.Now);
                sw.WriteLine(text);
                sw.Close();
        }

    }
}
