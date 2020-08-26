using RomanIntegerConverter.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanIntegerConverterTests
{
    class RunTest
    {
        static RomanInteger number;
      
        public static void Main()
        {
            number = 1024;
            number.GetRomanNumber();
        }
    }
}
