using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeChallenges.Tests
{
    [Trait("Challenge", "Algo2")]
    public class Algo2Test
    {
        [Fact(DisplayName = "Add Two Numbers Passing")]
        public void PassingTest()
        {
            Algo2 algo2 = new Algo2();

            // 1
            var n1 = new ListNode(2);
            var n2 = new ListNode(4);
            var n3 = new ListNode(3);
            n1.next = n2;
            n2.next = n3;

            var m1 = new ListNode(5);
            var m2 = new ListNode(6);
            var m3 = new ListNode(4);
            m1.next = m2;
            m2.next = m3;

            var o1 = new ListNode(7);
            var o2 = new ListNode(0);
            var o3 = new ListNode(8);
            o1.next = o2;
            o2.next = o3;

            var expected1 = o1;

            var actual1 = algo2.AddTwoNumbers(n1, m1);

            Assert.Equal(expected1, actual1);

            // 2
            var x1 = new ListNode(5);
            var y1 = new ListNode(5);

            var z1 = new ListNode(0);
            var z2 = new ListNode(1);
            z1.next = z2;
            var expected2 = z1;

            var actual2 = algo2.AddTwoNumbers(x1, y1);

            Assert.Equal(expected2, actual2);
        }

        [Fact(DisplayName = "Add Two Numbers Failing")]
        public void FailingTest()
        {
            Algo2 algo2 = new Algo2();

            // 1
            var n1 = new ListNode(2);
            var n2 = new ListNode(4);
            var n3 = new ListNode(3);
            n1.next = n2;
            n2.next = n3;

            var m1 = new ListNode(5);
            var m2 = new ListNode(6);
            var m3 = new ListNode(4);
            m1.next = m2;
            m2.next = m3;

            var o1 = new ListNode(7);
            var o2 = new ListNode(5);
            var o3 = new ListNode(8);
            o1.next = o2;
            o2.next = o3;

            var expected = o1;

            var actual = algo2.AddTwoNumbers(n1, m1);

            Assert.NotNull(actual);
            Assert.NotEqual(expected, actual);
        }
    }
}
