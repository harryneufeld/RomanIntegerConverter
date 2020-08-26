using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography.X509Certificates;

namespace RomanIntegerConverter.Model
{
    public struct RomanInteger
    {
        #region fields
        private int _value;
        private string _name;
        private static SortedDictionary<int, string> _romanNumbers;
        #endregion

        #region static operators
        public static implicit operator RomanInteger(int value)
        {
            _romanNumbers = new SortedDictionary<int, string>()
            {
                { 10000, "O" },
                { 5000, "D" },
                { 1000, "M" },
                { 100, "C" },
                { 50, "L" },
                { 10, "X" },
                { 5, "V" },
                { 1, "I" }
            };
            
            return new RomanInteger { _value = value };
        }

        public static implicit operator int(RomanInteger value)
        {
            return value._value;
        }
        #endregion

        #region public methods
        public string GetRomanNumber()
        {
            if (String.IsNullOrWhiteSpace(_name))
            {
                _name = "";
                GetHighestValueOfSelf();
            }
            return _name;
        }
        #endregion

        #region private methods
        private void GetHighestValueOfSelf()
        {
            int n = _value;
            var romanNumbers = _romanNumbers.OrderByDescending(x => x.Key);

            foreach (var v in romanNumbers)
            {
                bool skip = false;
                while (n >= 1 && !skip)
                {
                    float i = DivideThroughHighestValue(n, v.Key);
                    if (i >= 1)
                    {
                        n -= v.Key;
                        SetOrAttachRomanNumber(v.Value);
                    }
                    else
                    {
                        skip = true;
                    }
                }
            }
        }

        private void SetOrAttachRomanNumber(string romanNumber)
        {
            _name += romanNumber;
        }

        private float DivideThroughHighestValue(int n, int v) => (float)n / v;
        #endregion
    }


}
