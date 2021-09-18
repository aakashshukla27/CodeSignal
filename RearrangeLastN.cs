using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal
{
    class RearrangeLastN
    {
        static ListNode<int> rearrangeLastN(ListNode<int> l, int n)
        {
            ListNode<int> c = l;
            ListNode<int> prev = l;
            int length = GetLength(l);
            for (int i = 0; i < length - n; i++)
            {
                prev = l;
                l = l.next;
            }

            prev.next = null;
            ListNode<int> temp = l;

            while(temp.next != null)
            {
                temp = temp.next;
            }

            temp.next = c;


            //prev.next = null;


            return null;
        }

        static int GetLength(ListNode<int> a)
        {
            int count = 0;
            while (a != null)
            {
                a = a.next;
                count++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            ListNode<int> a = new ListNode<int>(1);
            a.next = new ListNode<int>(2);
            a.next.next = new ListNode<int>(3);
            a.next.next.next = new ListNode<int>(4);
            a.next.next.next.next = new ListNode<int>(5);
            rearrangeLastN(a, 3);
        }
    }
}
