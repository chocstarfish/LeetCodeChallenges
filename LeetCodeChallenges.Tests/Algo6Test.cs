using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeChallenges.Tests
{
    [Trait("Challenge", "Algo6")]
    public class Algo6Test
    {
        [Fact(DisplayName = "ZigZag Conversion Passing")]
        public void PassingTest()
        {
            Algo6 algo6 = new Algo6();
            var test1 = "BOSTONISAREALLYNICECITY";
            /*
             * B     I     L     E 
             * O   N S   A L   C C
             * S O   A E   Y I   I Y
             * T     R     N     T
             */
            var expected1 = "BILEONSALCCSOAEYIIYTRNT";
            var actual1 = algo6.Convert(test1, 4);
            Assert.Equal(expected1, actual1);

            var test2 = "PAYPALISHIRING";
            var expected2 = "PAHNAPLSIIGYIR";
            Assert.Equal(expected2, algo6.Convert(test2, 3));
        }
    }
}
