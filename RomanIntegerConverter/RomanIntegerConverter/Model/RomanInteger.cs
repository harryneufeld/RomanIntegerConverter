using System;
using System.Collections.Generic;
using System.Text;

namespace RomanIntegerConverter.Model
{
    public struct RomanInteger
    {
        private int _value;

        public static implicit operator RomanInteger(int value)
        {
            return new RomanInteger { _value = value };
        }

        public static implicit operator int(RomanInteger value)
        {
            return value._value;
        }

        public string ConvertToRoman()
        {
            if (_value == 1)
                return "I";
            else
                return "";
        }
 
    }


}
