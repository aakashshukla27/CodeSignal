using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal
{
    class MergeTwoLinkedLists
    {
        static ListNode<int> mergeTwoLinkedLists(ListNode<int> l1, ListNode<int> l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            ListNode<int> c = new ListNode<int>(0);
            ListNode<int> p = c;
            while(l1 != null && l2 != null)
            {
                if(l1.value <= l2.value)
                {
                    c.next = new ListNode<int>(l1.value);
                    l1 = l1.next;
                    c = c.next;
                }
                else
                {
                    c.next = new ListNode<int>(l2.value);
                    l2 = l2.next;
                    c = c.next;
                }

      
            }

            if(l1 == null)
            {
                c.next = l2;
            }
            if(l2 == null)
            {
                c.next = l1;
            }


            return p.next;
        }
        static void Main(string[] args)
        {
            // 1, 1, 2, 4
            ListNode<int> a = new ListNode<int>(1);
            a.next = new ListNode<int>(1);
            a.next.next = new ListNode<int>(2);
            a.next.next.next = new ListNode<int>(4);

            ListNode<int> b = new ListNode<int>(0);
            b.next = new ListNode<int>(3);
            b.next.next = new ListNode<int>(5);

            mergeTwoLinkedLists(a, b);

        }
    }
}
