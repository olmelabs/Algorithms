using System.Collections.Generic;
using System.Text;

namespace Olmelabs.Algorithms.Chapter4
{
    /// <summary>
    /// Program 4.6. Infix-to-postfix conversion
    /// </summary>
    public class StackConvertInfixToPostfix
    {
        public string Convert(string input)
        {
            StringBuilder res = new StringBuilder();
            Stack<char> ops = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char a = input[i];

                if (a == ')')
                    res.Append($"{ops.Pop()} ");

                if ((a == '+') || (a == '*'))
                    ops.Push(a);

                if ((a >= '0') && (a <= '9'))
                    res.Append($"{char.GetNumericValue(a)} ");
            }

            res.Append($"{ops.Pop()} ");

            return res.ToString();
        }
    }
}
