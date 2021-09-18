using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal
{
    class ReverseNodesInKGroups
    {
        static ListNode<int> reverseNodesInKGroups(ListNode<int> l, int k)
        {
            int count = 0;
            if (l == null) return null;
            ListNode<int> current = l;
            ListNode<int> next = null, prev = null;
            if (GetLength(l) < k)
            {
                return l;
            }
            while (count < k && current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
                count++;
            }
            if(next != null)
            {
                l.next = reverseNodesInKGroups(next, k);
            }
            return prev;
        }
        static int GetLength(ListNode<int> t)
        {
            int count = 0;
            while (t != null)
            {
                count++;
                t = t.next;
            }
            return count;
        }

        static void Main(string[] args)
        {

        }
    }
}
