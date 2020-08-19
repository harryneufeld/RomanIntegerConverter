using NUnit.Framework;
using RomanianIntegerConverter.Model;

namespace RomanianIntegerConverterTests
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
            
            var romanNumber = number.ConvertToRoman();

            Assert.IsFalse(number == 1 && romanNumber != "I");
        }
    }
}