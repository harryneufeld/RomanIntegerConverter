using NUnit.Framework;
using RomanIntegerConverter.Model;

namespace RomanIntegerConverterTests
{
    public class ConvertIntegerToRomanTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Convert44ToRoman()
        {
            RomanInteger x = 44;
            Assert.IsTrue(x.GetRomanNumber() == "XLIV");
        }

        [Test]
        public void Convert66ToRoman()
        {
            RomanInteger x = 66;
            Assert.IsTrue(x.GetRomanNumber() == "LXVI");
        }

        [Test]
        public void Convert77ToRoman()
        {
            RomanInteger x = 77;
            Assert.IsTrue(x.GetRomanNumber() == "LXXVII");
        }

        [Test]
        public void Convert90ToRoman()
        {
            RomanInteger x = 90;
            Assert.IsTrue(x.GetRomanNumber() == "XC");
        }

        [Test]
        public void Convert104ToRoman()
        {
            RomanInteger x = 104;
            Assert.IsTrue(x.GetRomanNumber() == "CIV");
        }

        [Test]
        public void Convert921ToRoman()
        {
            RomanInteger x = 921;
            Assert.IsTrue(x.GetRomanNumber() == "CMXXI");
        }

        [Test]
        public void Convert1024ToRoman()
        {
            RomanInteger x = 1024;
            Assert.IsTrue(x.GetRomanNumber() == "MXXIV");
        }

        [Test]
        public void Convert1630ToRoman()
        {
            RomanInteger x = 1630;
            Assert.IsTrue(x.GetRomanNumber() == "MDCXXX");
        }

        [Test]
        public void Convert1984ToRoman()
        {
            RomanInteger x = 1984;
            Assert.IsTrue(x.GetRomanNumber() == "MCMLXXXIV");
        }

        [Test]
        public void Convert2048ToRoman()
        {
            RomanInteger number = 2048;
            Assert.IsTrue(number.GetRomanNumber() == "MMXLVIII");
        }

        [Test]
        public void Convert4096ToRoman()
        {
            RomanInteger x = 4096;
            Assert.IsTrue(x.GetRomanNumber() == "MMMMXCVI");
        }

        [Test]
        public void Convert10000ToRoman()
        {
            RomanInteger x = 10000;
            Assert.IsTrue(x.GetRomanNumber() == "ↂ");
        }

    }
}