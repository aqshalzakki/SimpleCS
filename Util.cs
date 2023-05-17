using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    static internal class Util
    {
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static bool IsOdd(int num)
        {
            return num % 2 == 1;
        }
    }
}
