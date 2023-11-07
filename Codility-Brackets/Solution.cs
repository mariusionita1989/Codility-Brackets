using System.Runtime.CompilerServices;

namespace Codility_Brackets
{
    public class Solution
    {
        public const int RANGE_LOWEST_VALUE = 0;
        public const int RANGE_HIGHEST_VALUE = 200000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(string S)
        {
            int N = S.Length;
            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE) 
            {
                // Create a stack to keep track of opening brackets
                Stack<char> stack = new Stack<char>();
                // Iterate through each character in the input string
                foreach (char c in S)
                {
                    if (c == '(' || c == '{' || c == '[')
                    {
                        // If the character is an opening bracket, push it onto the stack
                        stack.Push(c);
                    }
                    else
                    {
                        if (stack.Count == 0)
                        {
                            // If there are no opening brackets to match, return 0
                            return 0;
                        }

                        char top = stack.Pop(); // Pop the last opening bracket

                        // Check if the current character closes the last opening bracket
                        if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
                            return 0; // Mismatched closing bracket
                    }
                }

                // If the stack is empty, all brackets are properly nested
                return stack.Count == 0 ? 1 : 0;
            }

            return -1;
        }
    }
}
