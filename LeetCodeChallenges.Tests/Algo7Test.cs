using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeChallenges.Tests
{
    [Trait("Challenge", "Algo7")]
    public class Algo7Test
    {

        [Fact(DisplayName = "Reverse Integer Passing")]
        public void PassingTest()
        {
            Algo7 algo6 = new Algo7();

            // Example1: x = 123, return 321
            // Example2: x = -123, return -321
            Assert.Equal(321, algo6.Reverse(123));
            Assert.Equal(-321, algo6.Reverse(-123));
            Assert.Equal(1, algo6.Reverse(100));
            Assert.Equal(0, algo6.Reverse(1000000003));
            Assert.Equal(0, algo6.Reverse(-2147483648));

        }
    }
}
