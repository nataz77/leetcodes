using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode2
{
    static class Program
    {
        static void Main(string[] args)
        {
            AddTwoNumbers(IntToList(9), IntToList(1999999999));
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode reversedL1 = ReverseList(l1);
            ListNode reversedL2 = ReverseList(l2);
            int numl1 = ListToInt(reversedL1);
            int numl2 = ListToInt(reversedL2);
            Console.WriteLine("Reversed number 1 is {0} and 2 is {1}", numl1, numl2);
            Console.ReadLine();
            var target = numl1 + numl2;
            var res = IntToList(target);
            return res;
        }

        public static ListNode ReverseList(ListNode toReverse)
        {
            ListNode Previous = null, Following = null;
            ListNode Current = toReverse;
            while (Current != null)
            {
                Following = Current.next;
                Current.next = Previous;
                Previous = Current;
                Current = Following;
            }
            return Previous;
        }

        public static int ListToInt(ListNode node)
        {
            StringBuilder result = new StringBuilder();
            while (node != null)
            {
                result.Append(node.val);
                node = node.next;
            }
            return int.Parse(result.ToString());
        }

        public static ListNode IntToList(int num)
        {
            ListNode result = null;
            if (num == 0) return new ListNode(0);
            while (num > 0)
            {
                result = Add(num, result);
                num /= 10;
            }
            return result;
        }

        public static ListNode Add(int num, ListNode head)
        {
            if (head == null)
                head = new ListNode(num % 10);
            else
                head.next = Add(num % 10, head.next);
            return head;
        }
    }
}
