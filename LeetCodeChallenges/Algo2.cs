using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    /// <summary>
    /// Add Two Numbers
    /// 
    /// You are given two linked lists representing two non-negative numbers. 
    /// The digits are stored in reverse order and each of their nodes contain a single digit. 
    /// Add the two numbers and return it as a linked list.
    /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    /// Output:7 -> 0 -> 8
    /// </summary>
    public class Algo2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // check nulls
            if (l1 == null && l2 != null)
            {
                return l2;
            }
            else if (l1 != null && l2 == null)
            {
                return l1;
            }
            else if (l1 == null && l2 == null)
            {
                return null;
            }

            ListNode resultHeadNode = null, lastNode = null;
            int tmp = 0;
            while (l1 != null || l2 != null)
            {
                int addition = 0;
                if (l1 != null && l2 != null)
                {
                    addition = l1.val + l2.val;
                }
                else if (l1 == null && l2 != null)
                {
                    addition = l2.val;
                }
                else if (l2 == null && l1 != null)
                {
                    addition = l1.val;
                }


                if (tmp == 1)
                {
                    addition += 1;
                }

                if (addition > 9)
                {
                    tmp = 1;
                    addition -= 10;
                }
                else
                {
                    tmp = 0;
                }

                var tmpNode = new ListNode(addition);
                if (lastNode != null)
                {
                    lastNode.next = tmpNode;
                }

                if (resultHeadNode == null)
                {
                    resultHeadNode = tmpNode;
                }

                lastNode = tmpNode;
                if (l1 != null)
                {
                    l1 = l1.next;
                }

                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }

            if (tmp == 1)
            {
                lastNode.next = new ListNode(1);
            }
            return resultHeadNode;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public override bool Equals(object obj)
        {
            string numString2 = String.Empty;
            if (obj != null)
            {
                ListNode tmp2 = (ListNode)obj;

                while (tmp2 != null)
                {
                    numString2 += tmp2.val;
                    tmp2 = tmp2.next;
                }
            }
            else
            {
                return false;
            }

            ListNode tmp1 = this;
            string numString1 = String.Empty;
            while (tmp1 != null)
            {
                numString1 += tmp1.val;
                tmp1 = tmp1.next;
            }

            return numString1.Equals(numString2);
        }
    }
}
