using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab13;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.Tests
{
    [TestClass()]
    public class ExtensionMethodsTests
    {
        [TestMethod()]
        public void CapitalizeWordsTest()
        {
            string s = "ala ma kota";
            s = s.CapitalizeWords();
            string s3 = "Ala Ma Kota";
            Assert.AreEqual(s3, s);
        }

        [TestMethod()]
        public void CountWordsTest()
        {
            string s = "ala ma kota";
            int x = 3;
            int y = s.CountWords();
            Assert.AreEqual(x, y);
        }

        [TestMethod()]
        public void CountVowelsTest()
        {
            string s = "ala ma kota";
            int x = 5;
            int y = s.CountVowels();
            Assert.AreEqual(x, y);
        }

        [TestMethod()]
        public void RemoveVowelsTest()
        {
            string s = "ala ma kota";
            s = s.RemoveVowels();
            string s2 = "l m kt";
            Assert.AreEqual(s2, s);
        }

        [TestMethod()]
        public void ReverseLettersInWordsTest()
        {
            string s = "ala ma kota";
            s = s.ReverseLettersInWords();
            string s2 = "ala am atok ";
            Assert.AreEqual(s2, s);
        }

        [TestMethod()]
        public void ConvertToMorseTest()
        {
            string s = "sos";
            s = s.ConvertToMorse();
            string s2 = "...−−−...";
            Assert.AreEqual(s2, s);
        }

        [TestMethod()]
        public void RemoveNonLettersTest()
        {
            string s = "a@la 15m3a k.0ot!a";
            s = s.RemoveNonLetters();
            string s2 = "ala ma kota";
            Assert.AreEqual(s2, s);
        }

        [TestMethod()]
        public void ContainsAlaMaKotaTest()
        {
            string s = "ala i ela ma nie ma psa i kota";
            bool x = s.ContainsAlaMaKota();
            bool y = true;
            Assert.AreEqual(y, x);
        }

        [TestMethod()]
        public void ContainsAlaMaKotaTest1()
        {
            string s = "ala i ela ma nie ma psa i kota";
            bool x = s.ContainsAlaMaKota();
            bool y = true;
            Assert.AreEqual(y, x);
        }

        [TestMethod()]
        public void RandomizeMiddleLettersTest()
        {
            Assert.Fail();
        }
    }
}