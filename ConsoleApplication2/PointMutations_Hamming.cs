using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalindProblems
{
    class PointMutations_Hamming
    {
        public static int calculateHammingDistance(string str1, string str2) 
        {
            if (str1.Count() == str1.Count() && str1.Count() < 1000)
            {
                int distance = 0;
                for (int i = 0; i < str1.Count(); ++i)
                {
                    if (str1[i] != str2[i])
                        distance++;
                }
                return distance;
            }
            else
                return -1;
        }
    }
}
