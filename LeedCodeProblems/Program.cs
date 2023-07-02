using LeedCodeProblems.Problems;

var nums = new int[4] { 2, 7, 11, 15 };
var target = 9;

var res = TwoSum.TwoSum(nums, target);

foreach (var item in res)
{
    Console.WriteLine(item);
}
Console.ReadLine();
