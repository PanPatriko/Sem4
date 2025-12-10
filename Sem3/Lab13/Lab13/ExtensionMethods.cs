using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab13
{
    public static class ExtensionMethods
    {
        public static string CapitalizeWords(this string s)
        {
            string[] words = s.Split();
            for(int i =0;i< words.Length;i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);               
            }
            return string.Join(" ", words);
        }
        public static int CountVowels(this string s)
        {
            int counter = 0;
            foreach(char letter in s)
            {
                if("aAąĄeEeĘoOuUóÓiIyY".Contains(letter))
                {
                    counter++;
                }
            }
            return counter;
        }
        public static int CountWords(this string s)
        {
            return s.Split().Length;
        }
       public static string RemoveVowels(this string s)
        {
            Regex reg = new Regex("a*A*ą*Ą*e*E*e*Ę*o*O*u*U*ó*Ó*i*I*y*Y*");
            return reg.Replace(s, "");
        }
        public static string ReverseLettersInWords(this string s)
        {
            string[] words = s.Split();
            string reverse = "";
            for (int i = 0; i < words.Length; i++)
            {
                char[] array = words[i].ToCharArray();
                array = array.Reverse().ToArray();
                foreach(char c in array)
                {
                    reverse += c;
                }
                reverse += " ";
            }
            return reverse;
        }
        public static string RandomizeMiddleLetters(this string s)
        {
            Random rand = new Random();
            string[] words = s.Split();
            string random = "";
            int x,x2,x3; 
            char buffer;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length>3)
                {
                    char[] array = words[i].ToCharArray();
                    x = rand.Next(0, 20);
                    for (int j = 0; j < x; j++)
                    {
                        x2 = rand.Next(1, array.Length - 1);
                        x3 = rand.Next(1, array.Length - 1);
                        buffer = array[x2];
                        array[x2] = array[x3];
                        array[x3] = buffer;
                    }
                    foreach (char c in array)
                    {
                        random += c;
                    }
                }
                else random += words[i];
                random += " ";
            }
            return random;
        }
        public static string ConvertToMorse(this string s)
        {
            char[] array = s.ToCharArray();
            string morse = "";
            foreach(char c in array)
            {
                if (translator.ContainsKey(c)) morse += translator[c];
            }
            return morse;
        }
        public static string RemoveNonLetters(this string s)
        {
            Regex reg = new Regex("[^a-zA-Z ]");
            return reg.Replace(s,"");
        }
        public static bool ContainsAlaMaKota(this string s)
        {
            Regex reg = new Regex(@"[\w\d\s]*ala+[\w\d\s]*ma+[\w\d\s]*kota+[\w\d\s]*");
            if (reg.IsMatch(s)) return true;
            return false;
        }
      
        private static char dot = '.';
        private static char dash = '−';
        private static  Dictionary<char, string> translator = new Dictionary<char, string>()
            {
                {'a', string.Concat(dot, dash)},
                {'b', string.Concat(dash, dot, dot, dot)},
                {'c', string.Concat(dash, dot, dash, dot)},
                {'d', string.Concat(dash, dot, dot)},
                {'e', dot.ToString()},
                {'f', string.Concat(dot, dot, dash, dot)},
                {'g', string.Concat(dash, dash, dot)},
                {'h', string.Concat(dot, dot, dot, dot)},
                {'i', string.Concat(dot, dot)},
                {'j', string.Concat(dot, dash, dash, dash)},
                {'k', string.Concat(dash, dot, dash)},
                {'l', string.Concat(dot, dash, dot, dot)},
                {'m', string.Concat(dash, dash)},
                {'n', string.Concat(dash, dot)},
                {'o', string.Concat(dash, dash, dash)},
                {'p', string.Concat(dot, dash, dash, dot)},
                {'q', string.Concat(dash, dash, dot, dash)},
                {'r', string.Concat(dot, dash, dot)},
                {'s', string.Concat(dot, dot, dot)},
                {'t', string.Concat(dash)},
                {'u', string.Concat(dot, dot, dash)},
                {'v', string.Concat(dot, dot, dot, dash)},
                {'w', string.Concat(dot, dash, dash)},
                {'x', string.Concat(dash, dot, dot, dash)},
                {'y', string.Concat(dash, dot, dash, dash)},
                {'z', string.Concat(dash, dash, dot, dot)},
                {'0', string.Concat(dash, dash, dash, dash, dash)},
                {'1', string.Concat(dot, dash, dash, dash, dash)},
                {'2', string.Concat(dot, dot, dash, dash, dash)},
                {'3', string.Concat(dot, dot, dot, dash, dash)},
                {'4', string.Concat(dot, dot, dot, dot, dash)},
                {'5', string.Concat(dot, dot, dot, dot, dot)},
                {'6', string.Concat(dash, dot, dot, dot, dot)},
                {'7', string.Concat(dash, dash, dot, dot, dot)},
                {'8', string.Concat(dash, dash, dash, dot, dot)},
                {'9', string.Concat(dash, dash, dash, dash, dot)},
                {' ', " "}
            };
      

    }
}
