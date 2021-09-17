using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal
{
    class AddTwoHugeNumbers
    {
        static ListNode<int> addTwoHugeNumbers(ListNode<int> a, ListNode<int> b)
        {
            if (a == null) return b;
            if (b == null) return a;

            a = ReverseList(a);
            b = ReverseList(b);
            
            List<int> returnList = new List<int>();
            int carry = 0;
            while(a != null && b != null)
            {
                int temp = a.value + b.value + carry;
                if (temp - 10000 >= 0)
                {
                    carry = 1;
                    returnList.Add(temp - 10000);
                }
                else
                {
                    carry = 0;
                    returnList.Add(temp);
                } 
                   
                
                a = a.next;
                b = b.next;
                
            }
            if(b == null)
            {
                while(a != null)
                {
                    int temp = a.value + carry;
                    if(temp - 10000 >= 0)
                    {
                        carry = 1;
                        returnList.Add(temp - 10000);
                    }
                    else
                    {
                        carry = 0;
                        returnList.Add(temp);
                    }
                    a = a.next;
                }
            }
            if (a == null)
            {
                while (b != null)
                {
                    int temp = b.value + carry;
                    if (temp - 10000 >= 0)
                    {
                        carry = 1;
                        returnList.Add(temp - 10000);
                    }
                    else
                    {
                        carry = 0;
                        returnList.Add(temp);
                    }
                    b = b.next;
                }
            }
            ListNode<int> c = new ListNode<int>(0);
            ListNode<int> p = c;
            for(int i = returnList.Count -1; i>= 0; i--)
            {
                c.next = new ListNode<int>(returnList[i]);
                c = c.next;
            }

            return p.next;
        }

        static ListNode<int> addTwoHugeNumbers2(ListNode<int> a, ListNode<int> b)
        {
            if (a == null) return b;
            if (b == null) return a;
            a = ReverseList(a);
            b = ReverseList(b);
            int lengthA = GetLength(a);
            int lengthB = GetLength(b);
            ListNode<int> c = lengthA >= lengthB ?  a : b;
            int carry = 0;
            if (lengthA >= lengthB)
            {
                while (a != null && b != null)
                {

                    int temp = a.value + b.value + carry;
                    if (temp >= 10000)
                    {
                        carry = 1;
                        a.value = temp - 10000;
                    }
                    else
                    {
                        carry = 0;
                        a.value = temp;
                    }
                    a = a.next;
                    b = b.next;
                }
            }
            else
            {
                while (a != null && b != null)
                {

                    int temp = a.value + b.value + carry;
                    if (temp >= 10000)
                    {
                        carry = 1;
                        b.value = temp - 10000;
                    }
                    else
                    {
                        carry = 0;
                        b.value = temp;
                    }
                    a = a.next;
                    b = b.next;
                }
            }

            //ListNode<int> c = a;
            
           

            if(b== null)
            {
                while(a != null)
                {
                    int temp = a.value + carry;
                    if(temp >= 10000)
                    {
                        carry = 1;
                        a.value = temp - 10000;
                    }
                    else
                    {
                        carry = 0;
                        a.value = temp;
                    }
                    a = a.next;
                }
            }
            if(a == null)
            {
                while (b != null)
                {
                    int temp = b.value + carry;
                    if (temp >= 10000)
                    {
                        carry = 1;
                        b.value = temp - 10000;
                    }
                    else
                    {
                        carry = 0;
                        b.value = temp;
                    }
                    b = b.next;
                }
            }
            if (carry == 0)
            {

                return ReverseList(c);
            }
            else
            {
                ListNode<int> d = new ListNode<int>(1);
                d.value = 1;
                d.next = ReverseList(c);
                return d;
            }


        }

        static int GetLength(ListNode<int> t)
        {
            int count = 0;
            while(t != null)
            {
                count++;
                t = t.next;
            }
            return count;
        }

        static ListNode<int> ReverseList(ListNode<int> t)
        {
            ListNode<int> prev = null;
            ListNode<int> current = t;
            ListNode<int> next = null;
            while(current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }
        static void Main(string[] args)
        {
            //a = [9876, 5432, 1999]
            //b = [1, 8001]
            ListNode<int> a = new ListNode<int>(1);
            //a.next = new ListNode<int>(5432);
            //a.next.next = new ListNode<int>(1999);

            ListNode<int> b = new ListNode<int>(9999);
            b.next = new ListNode<int>(9999);
            b.next.next = new ListNode<int>(9999);
            b.next.next.next = new ListNode<int>(9999);
            b.next.next.next.next = new ListNode<int>(9999);
            b.next.next.next.next.next = new ListNode<int>(9999);
            b.next.next.next.next.next.next = new ListNode<int>(9999);

            addTwoHugeNumbers2(a, b);
        }
    }
}
