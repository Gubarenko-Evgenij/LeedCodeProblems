using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class RomanToInteger
{
    public static short NumberDefinition(char x)
    {
        switch (x)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
    public static int RomanToInt(string s)
    {
        int ineger = NumberDefinition(s[s.Length - 1]);

        for(var i = s.Length-2; i>=0;i--)
        {
            short temp = NumberDefinition(s[i]);
            if ( temp < NumberDefinition(s[i + 1]))
            {
                ineger -= NumberDefinition(s[i]);
            }
            else
            {
                ineger += NumberDefinition(s[i]);
            }
        }
        return ineger;
    }
    public static void TestResult(int res, int result)
    {
        if (res != result)
        {
            throw new Exception("Invalid result");
        }
    }
    public static void TestRomanToInteger()
    {
        string s = "III";
        var result = 3;
        var res = RomanToInt(s);
        TestResult(res, result);
        s = "LVIII";
        result = 58;
        res = RomanToInt(s);
        TestResult(res, result);
        s = "MCMXCIV";
        result = 1994;
        res = RomanToInt(s);
        TestResult(res, result);
    }
}
