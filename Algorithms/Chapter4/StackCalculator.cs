using System.Collections.Generic;

namespace Olmelabs.Algorithms.Chapter4
{
    /// <summary>
    /// Program 4.5. Postfix-expression evaluation
    /// The program implicitly assumes that the integers and operators are delimited by other characters of some kind (blanks, say)..
    /// </summary>
    public class StackCalculator
    {

        public int Calculate(string input)
        {
            Stack <int> save = new Stack<int>();

            for (int i = 0; i < input.Length; ++i)
            {
                char a = input[i];

                if (a == '+')
                    save.Push(save.Pop() + save.Pop());

                if (a == '*')
                    save.Push(save.Pop() * save.Pop());

                if ((a >= '0') && (a <= '9'))
                {
                    save.Push(a - '0'); //converts char to int

                    var b = input[++i];
                    while ((b >= '0') && (b <= '9'))
                    {
                        save.Push(10 * save.Pop() + (b - '0'));
                        b = input[++i];
                    }
                }
            }

            return save.Pop();
        }
    }
}
