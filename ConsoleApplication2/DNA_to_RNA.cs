using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalindProblems
{
    public class DNA_to_RNA
    {
        public static String SecondProblem(String str)
        {
            String s = str.ToUpper();
            String res = "";
            for (int i = 0; i < str.Count(); ++i)
            {
                if (str[i] == 'T')
                    res += 'U';
                else
                    res += str[i];
            }
            return res;
        }

        public static String SecondProblem1(String str)
        {
            return new string(str.Select(c => c == 'T' ? 'U' : c).ToArray());
        }
    }
}
