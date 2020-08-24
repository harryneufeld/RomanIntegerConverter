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
        public void ConvertIntegerToRoman()
        {
            RomanInteger number = 1;
            
            var romanNumber = number.GetRomanNumber();

            Assert.IsFalse(number == 1 && romanNumber != "I");
        }
    }
}