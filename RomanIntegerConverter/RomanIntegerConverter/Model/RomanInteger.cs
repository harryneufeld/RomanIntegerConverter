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
        private string _name;
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

            // TODO: FIX FUCKING ORDER
            foreach (RomanNumbers v in Enum.GetValues(typeof(RomanNumbers)))
            {
                bool done = false;
                int i = 0;
                while (done == false)
                {
                    int buffer = n;
                    int x = DivideThroughHighestValue(n, (int)v);

                    if (x < 0)
                        done = SetOrAttachRomanValue((int)v, i, buffer);
                    else if (x == 0)
                        done = SetOrAttachRomanValue((int)v, i, x);
                    else
                        n = x;

                    i++;
                }
            }
            return 0;
        }

        private bool SetOrAttachRomanValue(int v, int i, int buffer)
        {
            while (i >= 0)
            {
                _name = Enum.GetName(typeof(RomanNumbers), v).ToString() + _name;
                i--;
            }
            return true;
        }

        private int DivideThroughHighestValue(int n, int v) => n / v;
        #endregion
    }


}
