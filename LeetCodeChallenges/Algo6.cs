using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenges
{
    /// <summary>
    /// ZigZag Conversion
    /// 
    /// The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this:
    ///  (you may want to display this pattern in a fixed font for better legibility)
    /// P   A   H   N
    /// A P L S I I G
    /// Y   I   R
    /// And then read line by line: "PAHNAPLSIIGYIR"
    /// Write the code that will take a string and make this conversion given a number of rows:
    /// string convert(string text, int nRows);
    /// convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR". 
    /// </summary>
    public class Algo6
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            string result = string.Empty;
            var skip = numRows * 2 - 2;
            for (var i = 0; i < numRows; i++)
            {
                for (var j = i; j < s.Length; j += skip)
                {
                    result += s[j];
                    var index = j + skip - 2 * i;
                    if (i != 0 && i != numRows - 1 && index < s.Length)
                    {
                        result += s[index];
                    }
                }
            }
            return result;
        }
    }


}
