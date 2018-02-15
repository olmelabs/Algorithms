
using System.Diagnostics;

namespace Olmelabs.Algorithms.Chapter3
{

    /// <summary>
    /// Program 3.9. Circular list example (Josephus problem)
    /// N - number of people in circle
    /// M - every Mth person is eliminated
    /// Will not use LinkedList class here - DIY instead
    /// </summary>
    public class JosephusProblem
    {

        private readonly int _m;
        private LinkedListNode _x;

        public JosephusProblem(int n, int m)
        {
            _m = m;

            LinkedListNode t = new LinkedListNode(1, null);
            t.Next = t;

            _x = t;

            for (int i = 2; i <= n; i++)
            {
                _x = (_x.Next = new LinkedListNode(i, t));
            }
        }

        public void KillThemAll()
        {
            while (_x != _x.Next)
            {
                for (int i = 1; i < _m; i++)
                {
                    _x = _x.Next;
                }

                Trace.WriteLine($"killed {_x.Next.Item}");
                _x.Next = _x.Next.Next;
                
            }
            Trace.WriteLine($"Survived {_x.Item}");
        }


    }
}

