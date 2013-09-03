using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalindProblems
{
    public class DNA_Nucleotides
    {
        public static int[] FirstProblem(String str) {
            if (str.Count() <= 1000)
            {
                Dictionary<Char, Int32> occurrences = new Dictionary<char, int>();
                foreach (char c in str) {
                    if (occurrences.ContainsKey(c))
                    {
                        occurrences[c]++;
                    }
                    else {
                        occurrences.Add(c, 1);
                    }
                }
                occurrences.Keys.OrderBy(n => (int)n);
                return occurrences.Values.ToArray();
            }
            else return null;
        }

        public static int[] FirstProblem1(String str){
            return str.Distinct<char>().OrderBy(n => (int)n).Select(l => str.Count(c => l == c)).ToArray<int>();
        }
    }
}
