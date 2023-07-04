using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public static class Palindrome
{
    public static int NumberOfDigits(int x)
    {
        var digit = 1;
        while (x / (Math.Pow(10, digit)) >= 1)
        {
            digit++;
        }
        return digit;
    }
	public static int DigitOfTheDischarge (int x, int digit)
	{
		int temp = (int)(x % Math.Pow(10, digit));
		temp = (int)(temp / Math.Pow(10, digit - 1));
        return temp;
    }
    public static bool IsPalindrome(int x)
    {
		if (x < 0)
		{
			return false;
		}
		else if (x == 0) 
		{ 
			return true; 
		}
		var digit = NumberOfDigits(x);
		for(var i = 1; i != digit; i++)
		{
			if((DigitOfTheDischarge(x,digit-i+1) != DigitOfTheDischarge(x,i)))
			{
				return false;
			}
        }
		return true;
	}
	
    public static void TestResult (bool res, bool result)
	{
		if (res!=result) 
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
