using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeProblems.Problems
{
    internal class LongestCommonPrefix
    {
        public static int MinimumWordLength (string[] strs)
        {
            var length = strs[0].Length;
            for (var i = 1; i < strs.Length; i++)
            {
                if (length > strs[i].Length)
                {
                    length = strs[i].Length;
                }
            }
            return length;
        }
        public static string LongestCommonPrefix1(string[] strs)
        {
            string prefix = "";
            var isFlag = true;
            var minimumWordLength = MinimumWordLength(strs);
            for (var i = 0; i < minimumWordLength; i++)
            {
                for (var j = 0; j < strs.Length-1; j++)
                {
                    if (strs[j][i] != strs[j + 1][i])
                    {
                        isFlag = false;
                        break;
                    }
                }
                if (!isFlag) break;
                prefix = prefix + strs[0][i];
            }
            return prefix;
        }
        public static void TestResult(string res, string result)
        {
            if (res != result)
            {
                throw new Exception("Invalid result");
            }
        }
        public static void TestLongestCommonPrefix()
        {
            string[] strs = { "flower", "flow", "flight" };
            var result = "fl";
            var res = LongestCommonPrefix1(strs);
            TestResult (res, result);
            strs = new []{ "dog","racecar","car" };
            result = "";
            res = LongestCommonPrefix1(strs);
            TestResult (res, result);
    }
    }
}
