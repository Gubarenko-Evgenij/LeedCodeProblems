using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class PalindromeAlt
{
    public static bool IsPalindrome(int x)
    {
        var str = x.ToString();
        for (var i = 0; i <str.Length; i++)
        {
            if (str[i] != str[str.Length-i-1])
            {
                return false;
            }
        }
        return true;
    }

    public static void TestResult(bool res, bool result)
    {
        if (res != result)
        {
            throw new Exception("Invalid result");
        }
    }
    public static void TestIsPalindrome()
    {
        var x = 121;
        var result = true;
        var res = IsPalindrome(x);
        TestResult(res, result);
        x = -121;
        result = false;
        res = IsPalindrome(x);
        TestResult(res, result);
        x = 10;
        result = false;
        res = IsPalindrome(x);
        TestResult(res, result);
        x = 1000110001;
        result = true;
        res = IsPalindrome(x);
        TestResult(res, result);

    }
}
