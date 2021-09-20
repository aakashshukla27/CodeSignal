using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal
{
    class AreFollowingPatterns
    {
        static bool areFollowingPatterns(string[] strings, string[] patterns)
        {
            Dictionary<string, string> dict1 = new Dictionary<string, string>();
            Dictionary<string, string> dict2 = new Dictionary<string, string>();

            for (int i = 0; i < patterns.Length; i++)
            {
                if (!dict1.ContainsKey(patterns[i]) )
                {
                    dict1.Add(patterns[i], strings[i]);
                }
                if (!dict2.ContainsKey(strings[i]))
                {
                    dict2.Add(strings[i], patterns[i]);
                }
                if (dict1.ContainsKey(patterns[i]))
                {
                    string temp = dict1[patterns[i]];
                    if (temp != strings[i]) return false;
                }
                if (dict2.ContainsKey(strings[i]))
                {
                    string temp = dict2[strings[i]];
                    if (temp != patterns[i]) return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            string[] strings = { "kwtfpzm",
 "kwtfpzm",
 "kwtfpzm",
 "kwtfpzm",
 "kwtfpzm",
 "wfktjrdhu",
 "anx",
 "kwtfpzm" };
            string[] patterns = { "z",
 "z",
 "z",
 "hhwdphhnc",
 "zejhegjlha",
 "xgxpvhprdd",
 "e",
 "u" };
            areFollowingPatterns(strings, patterns);
        }
    }
}
