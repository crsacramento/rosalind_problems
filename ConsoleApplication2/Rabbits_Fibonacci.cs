using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalindProblems
{
    class Rabbits_Fibonacci
    {
        static Int64 previous   = 1;
        static Int64 previous_2 = 1;
        static bool b         = false;

        //n-1 + n-2 * k
        public static Int64 calculateRabbits(int n, int k)
        {
            Int64 last = 0;
            for(int i = 2; i < n; ++i)
            {
                if (b)
                {
                    previous = previous_2 + previous * k;
                    last = previous;
                }
                else
                {
                    previous_2 = previous + previous_2 * k;
                    last = previous_2;
                }
                b = !b;
            }
            return last;
        }
    }
}
