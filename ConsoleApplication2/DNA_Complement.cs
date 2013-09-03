using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalindProblems
{
    public class DNA_Complement
    {
        static Dictionary<Char,Char> SetupComplements() 
        {
            Dictionary<Char, Char> res = new Dictionary<char, char>();
            res.Add('A', 'T');
            res.Add('C', 'G');
            res.Add('T', 'A');
            res.Add('G', 'C');
            return res;
        }

        public static String ThirdProblem(String s) 
        {
            if (s.Count() <= 1000)
            {
                Dictionary<Char, Char> map = SetupComplements();
                String res = "";
                for (int i = s.Count() - 1; i >= 0; --i)
                {
                    if (map.ContainsKey(s[i]))
                        res += map[s[i]];
                    else res += s[i];
                }
                return res;
            }
            else return null;
        }
    }
}
