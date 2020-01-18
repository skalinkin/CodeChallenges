using System.Collections.Generic;
using System.Linq;

namespace CodeChallenges.Codility
{
    public class Brackets
    {
        public int solution(string S)
        {
            var stack = new Stack<char>();
            var openers = new[] {'(', '{', '['};
            foreach (var symbol in S)
            {
                if (openers.Contains(symbol))
                {
                    stack.Push(symbol);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }

                    if (!ValidPair(stack.Pop(), symbol))
                    {
                        return 0;
                    }
                }
            }

            if (stack.Count > 0)
            {
                return 0;
            }

            return 1;
        }

        private bool ValidPair(char opener, char closer)
        {
            if (opener == '(' && closer == ')')
            {
                return true;
            }

            if (opener == '{' && closer == '}')
            {
                return true;
            }

            if (opener == '[' && closer == ']')
            {
                return true;
            }

            return false;
        }
    }
}
/*A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:

S is empty;
S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;
S has the form "VW" where V and W are properly nested strings.
For example, the string "{[()()]}" is properly nested but "([)()]" is not.

Write a function:

class Solution { public int solution(string S); }

that, given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.

For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]", the function should return 0, as explained above.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [0..200,000];
string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")".
*/