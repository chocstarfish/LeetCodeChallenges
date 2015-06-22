using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeChallenges.Tests
{
    [Trait("Challenge", "Algo1")]
    public class Algo1Test
    {
        [Fact(DisplayName = "Two Sum Passing")]
        public void PassingTest()
        {
            Algo1 algo1 = new Algo1();

            var nums1 = new[] { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 };

            var target1 = 100;
            var expected1 = new[] { 9, 10 };
            var actual1 = algo1.TwoSum(nums1, target1);
            Assert.Equal(expected1, actual1);

            var target2 = 1642;
            var expected2 = new[] { 15, 16 };
            var actual2 = algo1.TwoSum(nums1, target2);
            Assert.Equal(expected2, actual2);


            var nums3 = new[] { 0, 4, 3, 0 };
            var target3 = 0;
            var expected3 = new[] { 1, 4 };
            var actual3 = algo1.TwoSum(nums3, target3);
            Assert.Equal(expected3, actual3);


            var nums4 = new[] { -1, -2, -3, -4, -5 };
            var target4 = -8;
            var expected4 = new[] { 3, 5 };
            var actual4 = algo1.TwoSum(nums4, target4);
            Assert.Equal(expected4, actual4);
        }

        [Fact(DisplayName = "Two Sum Failing")]
        public void FailingTest()
        {
            var numbers = new[] { 2, 7, 11, 15 };
            var target = 19;
            var expected = new int[2];

            Algo1 algo1 = new Algo1();
            var actual = algo1.TwoSum(numbers, target);
            Assert.Equal(expected, actual);
        }
    }
}
