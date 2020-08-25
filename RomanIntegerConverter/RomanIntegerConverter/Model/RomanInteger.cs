using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RomanIntegerConverter.Model
{
    public struct RomanInteger
    {
        #region fields
        private int _value;
        private string _name;
        private static Hashtable _romanNumbers;
        #endregion

        #region static operators
        public static implicit operator RomanInteger(int value)
        {
            _romanNumbers = new Hashtable()
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
        private int GetHighestValueOfSelf()
        {
            int n = _value;

            foreach (DictionaryEntry v in _romanNumbers)
            {
                bool done = false;
                int i = 0;
                while (done == false)
                {
                    int buffer = n;
                    int x = DivideThroughHighestValue(n, (int)v.Key);

                    if (x < 0)
                        done = SetOrAttachRomanValue((string)v.Value, i, buffer);
                    else if (x == 0)
                        done = SetOrAttachRomanValue((string)v.Value, i, x);
                    else
                        n = x;

                    i++;
                }
            }
            return 0;
        }

        private bool SetOrAttachRomanValue(string v, int i, int buffer)
        {
            while (i >= 0)
            {
                _name = v + _name;
                i--;
            }
            return true;
        }

        private int DivideThroughHighestValue(int n, int v) => n / v;
        #endregion
    }


}
