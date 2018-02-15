using System.Text;

namespace Olmelabs.Algorithms.Chapter3
{
    public class LinkedListNode
    {
        public LinkedListNode(int item, LinkedListNode next)
        {
            Item = item;
            Next = next;
        }

        public int Item { get; }
        public LinkedListNode Next { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            var t = this;
            sb.Append($"{Item}");

            while (t != null && (t.Next != null || t.Next != this))
            {
                t = t.Next;
                if (t != null)
                    sb.Append($" -> {t.Item}");
            }

            return sb.ToString();
        }
    }
}
