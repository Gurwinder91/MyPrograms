using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class CheckBalancedParenthess
    {
        public bool MatchedPair(char a, char b)
        {
            if (a == '{' && b == '}') return true;
            if (a == '[' && b == ']') return true;
            if (a == '(' && b == ')') return true;

            return false;
        }

        public bool Verify(string str)
        {
            Stack<char> stack = new Stack<char>();
            for (int index = 0; index < str.Length; index++)
            {

                if (stack.Count > 0 && MatchedPair(stack.Peek(), str[index]))
                {
                    stack.Pop();
                }

                else
                {
                    stack.Push(str[index]);
                }
            }

            return stack.Count == 0;
        }
    }
}
