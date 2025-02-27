using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    //extension method must be in static class and not generic
    internal static class IntExtension
    {
        //every fun used in object of it's return type
        public static int Reverse(this int value)
        {
            int ReversedNum = 0,LastDigit;
            while (value > 0)
            {
                LastDigit = value % 10;
                ReversedNum = ReversedNum * 10 + LastDigit;
                value /= 10;
            }
            return ReversedNum;
        }
        public static long Reverse(this long value)
        {
            long ReversedNum = 0, LastDigit;
            while (value > 0)
            {
                LastDigit = value % 10;
                ReversedNum = ReversedNum * 10 + LastDigit;
                value /= 10;
            }
            return ReversedNum;
        }
    }
}
