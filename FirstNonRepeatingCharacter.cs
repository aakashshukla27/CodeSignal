using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal
{
    class FirstNonRepeatingCharacter
    {
        char firstNotRepeatingCharacter(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 1);
                }
                else
                {
                    dict[c]++;
                }
            }

            foreach (var c in dict)
            {
                if (c.Value == 1)
                {
                    return c.Key;
                }
            }

            return '_';
        }

    }
}
