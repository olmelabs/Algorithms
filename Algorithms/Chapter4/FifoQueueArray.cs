
namespace Olmelabs.Algorithms.Chapter4
{
    /// <summary>
    /// Program 4.15. FIFO queue array implementation
    /// % division makes circular array for the queue.
    /// </summary>
    public class FifoQueueArray
    {
        private readonly object[] _q;
        private readonly int _n;
        private int _head, _tail;

        public FifoQueueArray(int maxN)
        {
            _q = new object[maxN + 1];

            _n = maxN + 1;
            _head = _n;
            _tail = 0;
        }

        public void Put(object item)
        {
            _q[_tail++] = item;
            _tail = _tail % _n;
        }

        public object Get()
        {
            _head = _head % _n;
            return _q[_head++];
        }

    }
}
