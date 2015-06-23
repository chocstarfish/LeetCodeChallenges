using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    /// <summary>
    /// Two Sum
    /// 
    /// Given an array of integers, find two numbers such that they add up to a specific target number.
    /// The function twoSum should return indices of the two numbers such that they add up to the target,
    /// where index1 must be less than index2. Please note that your returned answers (both index1 and index2) are not zero-based.
    /// You may assume that each input would have exactly one solution.
    /// Input: numbers={2, 7, 11, 15}, target=9
    /// Output: index1=1, index2=2 
    /// </summary>
    public class Algo1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];

            // the key of the dictionary is the item value in the nums, 
            // the value of the dictionary is the index of the item
            var dic = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var currentNum = nums[i];
                var substraction = target - currentNum;
                if (!dic.ContainsKey(currentNum))
                {
                    if (!dic.ContainsKey(substraction))
                    {
                        dic.Add(substraction, i);
                    }
                }
                else
                {
                    // got the answer
                    var index1 = dic[currentNum];
                    result[0] = index1 + 1;
                    result[1] = i + 1;
                    break;
                }
            }

            return result;

        }
    }
}
