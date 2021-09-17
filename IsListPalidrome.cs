using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal
{
    class IsListPalidrome
    {
        static ListNode<int> secondHalf;
        static bool isListPalindrome(ListNode<int> l)
        {
            if (l == null || l.next == null) return true;            
            ListNode<int> slowPtr = l;
            ListNode<int> fastPtr = l;
            ListNode<int> middleNode = null;
            ListNode<int> prevSlowPtr = l;
            while(fastPtr != null && fastPtr.next != null)
            {
                fastPtr = fastPtr.next.next;
                prevSlowPtr = slowPtr;
                slowPtr = slowPtr.next;
            }
            if(fastPtr != null)
            {
                middleNode = slowPtr;
                slowPtr = slowPtr.next;
            }
            secondHalf = slowPtr;
            prevSlowPtr.next = null;
            ListNode<int> firstHalf = l;
            ReverseList();
            return CompareLists(firstHalf, secondHalf);
        }

        static void ReverseList()
        {
            ListNode<int> prev = null;
            ListNode<int> current = secondHalf;
            ListNode<int> next = null;
            while(current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            secondHalf = prev;
        }

        static bool CompareLists(ListNode<int> temp1, ListNode<int> temp2)
        {
            while (temp1 != null && temp2 != null)
            {
                if (temp1.value == temp2.value)
                {
                    temp1 = temp1.next;
                    temp2 = temp2.next;
                }
                else
                {
                    return false;
                }
            }

            if (temp1 == null && temp2 == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            // [1, 1000000000, -1000000000, -1000000000, 1000000000, 1]
            ListNode<int> l = new ListNode<int>(1);
            l.next = new ListNode<int>(1000000000);
            l.next.next = new ListNode<int>(-1000000000);
            l.next.next.next = new ListNode<int>(-1000000000);
            l.next.next.next.next = new ListNode<int>(1000000000);
            l.next.next.next.next.next = new ListNode<int>(1);
            isListPalindrome(l);
        }

    }
}
