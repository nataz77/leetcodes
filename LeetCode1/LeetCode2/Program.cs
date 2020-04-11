using System;
using System.Collections.Generic;

namespace LeetCode2
{
    static class Program
    {
        static void Main(string[] args)
        {
            //testcases
            var num342 = new ListNode(2)
            {
                next = new ListNode(4)
            };
            num342.next.next = new ListNode(3);
            var num465 = new ListNode(5)
            {
                next = new ListNode(6)
            };
            num342.next.next = new ListNode(4);

            AddTwoNumbers(num342, num465);
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            throw new NotImplementedException("");
        }
    }
}
