using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeProblems.Problems
{
    public static class TwoSum
    {
        public static int[] Two_sum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length - 1; i++)
            {
                int twoNumber = target - nums[i];
                int indexTwoNumber = -1;
                indexTwoNumber = Array.LastIndexOf(nums, twoNumber);
                if (indexTwoNumber > i)
                {
                    return new int[] { i, indexTwoNumber };
                }
            }
            return null;
        }

        public static void TestResult(int[] res, int[] result)
        {
            for (var i = 0; i < 2; ++i)
            {
                if (result[i] != res[i])
                {
                    throw new Exception("Invalid result!");
                }
            }
        }
        public static void TestTwoSum()
        {
            var nums = new int[4] { 2, 7, 11, 15 };
            var target = 9;
            var result = new int[] { 0, 1 };
            var res = TwoSum.Two_sum(nums, target);
            TestResult(res, result);
           
            nums = new int[] { 3, 2, 4 };
            target = 6;
            result = new int[] { 1, 2 };
            res = TwoSum.Two_sum(nums, target);
            TestResult(res, result);

            nums = new int[] { 3, 3 };
            target = 6;
            result = new int[] { 0, 1 };
            res = TwoSum.Two_sum(nums, target);
            TestResult(res, result);

            nums = new int[] { -1, -2, -3, -4, -5 };
            target = -8;
            result = new int[] { 2, 4 };
            res = TwoSum.Two_sum(nums, target);
            TestResult(res, result);
        }
    }
}
