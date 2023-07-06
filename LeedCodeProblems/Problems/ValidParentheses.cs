using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeedCodeProblems.Problems
{
    internal class ValidParentheses
    {
        public static bool OpeningParenthesis (char c)
        {
            switch (c)
            {
                case '(':return true;
                case '{':return true;
                case '[':return true;
                default: return false;
            }
        }
        public static bool TypeMatches(char c,char stackElement)
        {
           if (c == ')' && stackElement == '(')
            {
                return true;
            } 
            if (c == '}' && stackElement == '{')
            {
                return true;
            }
            if (c == ']' && stackElement == '[')
            {
                return true;
            }
            return false;
        }
        public static bool IsValid(string s)
        {
            Stack<char> str = new Stack<char>();
            foreach (char c in s) 
            {
                if (OpeningParenthesis(c))
                {
                    str.Push(c);
                }
                else
                {
                    if(str.Count==0) return false;
                    char stackElement = str.Pop();
                    if(!TypeMatches(c, stackElement))
                    {
                        return false;
                    }
                }
            }
            if (str.Count == 0) return true;
            return false;
        }
        public static void TestResult(bool res, bool result)
        {
            if (res != result)
            {
                throw new Exception("Invalid result");
            }
        }
        public static void TestValidParentheses()
        {
            string s = "()" ;
            var result = true;
            var res = IsValid(s);
            TestResult(res, result);
            s = "()[]{}";
            result = true;
            res = IsValid(s);
            TestResult(res, result);
            s = "(]";
            result = false;
            res = IsValid(s);
            TestResult(res, result); 
            s = "(())";
            result = true;
            res = IsValid(s);
            TestResult(res, result); 
            s = "())";
            result = false;
            res = IsValid(s);
            TestResult(res, result);
            s = "((())";
            result = false;
            res = IsValid(s);
            TestResult(res, result);
        }
    }
}
