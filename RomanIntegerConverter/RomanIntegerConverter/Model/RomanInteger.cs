using RomanIntegerConverter.Datatypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanIntegerConverter.Model
{
    public struct RomanInteger
    {
        #region fields
        private int _value;
        #endregion

        #region static operators
        public static implicit operator RomanInteger(int value)
        {
            return new RomanInteger { _value = value };
        }

        public static implicit operator int(RomanInteger value)
        {
            return value._value;
        }
        #endregion

        #region public methods
        public string ConvertToRoman()
        {
            if (_value == 1)
                return "I";
            else
                return "";
        }
        #endregion

        #region private methods
        private int GetHighestValueOfSelf()
        {
            int n = 0;
            foreach (RomanNumbers x in Enum.GetValues(typeof(RomanNumbers)))
            {
                for (int i = 0; n == 0; i++)
                {
                    n = DivideThroughHighestValue(x);
                }
            }
            return 0;
        }

        private int DivideThroughHighestValue(int x, RomanNumbers v) => x / (int)Enum.GetValues(typeof(RomanNumbers), v.ToString());
        #endregion
    }


}
