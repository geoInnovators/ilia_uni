using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class BigInteger
    {
        private string _value;
        private int _sign;


        /////////////////////////

        public BigInteger(string s)
        {
            if (s.StartsWith("-"))
            {
                _value = s.Substring(1);
                _sign = -1;
            }
            else if (s == "0")
            {
                _sign = 0;
                _value = s;
            }
            else
            {
                _sign = 1;
                _value = s;
            }

        }

        public string StringValue
        {
            get
            {
                if (_sign == -1)
                    return "-" + _value;
                return _value;
            }
        }

        public int Size
        {
            get { return _value.Length; }
        }

        public int Sign
        {
            get { return _sign; }
        }

        public static BigInteger Add(BigInteger first, BigInteger second)
        {
            // first  = 2000;
            // second = 0010;

            if (first.Sign != -1 && second.Sign != -1)
            {
                string s = "";
                int reminder = 0;
                for (int i = first.StringValue.Length - 1; i >= 0; i--)
                {
                    int a = int.Parse("" + first.StringValue[i]);
                    int b = int.Parse("" + second.StringValue[i]);
                    int res = (a + b + reminder)%10;
                    reminder = (a + b + reminder) / 10;
                    s = s.Insert(0, res.ToString());
                }
                if( reminder > 0)
                    s = s.Insert(0, reminder.ToString());
                return new BigInteger(s);
            }

            return null;
        }

        public static BigInteger Subtract(BigInteger first, BigInteger second)
        {
            return null;
        }

    }
}
