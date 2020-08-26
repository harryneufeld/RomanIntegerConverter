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
        public void ConvertIntToRomanTest1()
        {
            RomanInteger number = 102;
            
            var romanNumber = number.GetRomanNumber();

            Assert.IsTrue(romanNumber == "CII");
        }

        [Test]
        public void ConvertIntToRomanTest2()
        {
            RomanInteger number = 1024;

            var romanNumber = number.GetRomanNumber();

            Assert.IsTrue(romanNumber == "MXXIV" || romanNumber == "MXXIIII");
        }
    }
}