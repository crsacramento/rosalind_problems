using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalindProblems
{
    class Rearrangements_Genomic_Changes
    {
        public static List<string> possibilitiesMatrix = new List<string>();

        static public List<string> recursive(int n) 
        {
            List<int> numbers     = new List<int>();
            List<int> numbers_aux = new List<int>();
            for (int i = 1; i <= n; ++i)
            {
                numbers.Add(i);
                numbers_aux.Add(i);
            }

            foreach (int i in numbers)
            {
                //numbers_aux.;
                possibilitiesMatrix.Add(generatePermutation(i_.ToString(), numbers_aux));
            } 

            return possibilitiesMatrix;
        }

        static string generatePermutation(string s, List<int> list)
        {
            if (list.Count() == 0)
                return s;
            else
                for(int i = 1; i <= list.Count(); ++i)
                {
                    if(list.Remove(i))
                        s += generatePermutation(s + i, list);
                    i--;
                }
            return s;
        }
    }
}
