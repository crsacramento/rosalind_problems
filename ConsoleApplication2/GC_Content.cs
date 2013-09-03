using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalindProblems
{
    public class GC_Content
    {
        static Dictionary<String,String> ReadFile(String path) 
        {
            Dictionary<String, String> res = new Dictionary<String, String>();
            StreamReader fr = null;
            
            try{
                fr = new StreamReader(path);
            }catch(FileNotFoundException e){
                Console.WriteLine("File not found");
                Console.ReadKey();
            }

            String stringToProcess = "", stringIdentifier = "";
            while (!fr.EndOfStream) 
            {
                String s = fr.ReadLine();
                if (s[0] == '>')
                {
                    if (stringToProcess.Count() > 0 && stringIdentifier.Count() > 0)
                    {
                        res.Add(stringIdentifier, stringToProcess);
                        stringToProcess = "";
                    }
                    stringIdentifier = s.Substring(1);
                }
                else
                {
                    stringToProcess += s;
                }
            }
            if (stringToProcess.Count() > 0 && stringIdentifier.Count() > 0)
                res.Add(stringIdentifier, stringToProcess);
                
            return res;
        }

        static decimal Calculate_GC_Content(String s)
        {
            
            int counter = 0;
            foreach (char c in s)
            {
                counter += c == 'C' || c == 'G' ? 1 : 0;
            }
            return (decimal) (counter / (float)s.Count()) * 100;
        }

        public static string FourthProblem(String input){
            Dictionary<String,String> res = ReadFile(input);
            Dictionary<String, Decimal> results = new Dictionary<string, decimal>();
            foreach (KeyValuePair<String, String> kv in res)
            {
                results.Add(kv.Key, Calculate_GC_Content(kv.Value));
            }
            KeyValuePair<string, decimal> pair = new KeyValuePair<string,decimal>("",int.MinValue);
            foreach (KeyValuePair<String, Decimal> p in results) 
            {
                if (p.Value > pair.Value)
                    pair = p;
            }

            return pair.Key + "\n" + pair.Value.ToString();
        }

    }
}
