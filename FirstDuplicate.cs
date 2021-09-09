using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal
{
    class FirstDuplicate
    {
        static int firstDuplicate(int[] a)
        {
            HashSet<int> hashSet = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (!hashSet.Contains(a[i]))
                {
                    hashSet.Add(a[i]);
                }
                else
                {
                    return a[i];
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {

        }
    }
}
