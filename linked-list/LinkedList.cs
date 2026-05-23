using System.Linq.Expressions;

namespace Csharp
{
    public class MyLinkedList<T>
        where T : IComparable<T>
    {
        private Node? head;

        public void Append(T value)
        {
            var newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                // ref var next = ref head.Next;
                // while (next != null)
                // {
                //     next = ref next.Next;
                // }
                // next ??= newNode;
                var current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Prepend(T value)
        {
            var newHead = new Node(value);
            var oldHead = head;
            head = newHead;
            head.Next = oldHead;
        }

        public int Size()
        {
            var steps = 0;
            var next = head;
            while (next != null)
            {
                steps++;
                next = next.Next;
            }
            return steps;
        }

        public T? Head()
        {
            return head!.Value;
        }

        public T Tail()
        {
            if (head == null)
            {
                throw new Exception("Trying to access an empty linked list");
            }
            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current.Value;
        }

        public void PrintAllValues()
        {
            if (head == null)
            {
                return;
            }
            else
            {
                WriteLine(head.Value);
                var next = head.Next;
                while (next != null)
                {
                    WriteLine(next.Value);
                    next = next.Next;
                }
            }
        }

        public T AtIndex(int index)
        {
            if (index < 0 | head == null)
            {
                throw new IndexOutOfRangeException();
            }

            var current = head;
            for (int i = 0; i < index; i++)
            {
                current = current!.Next;
            }
            return current!.Value;
        }

        public T Pop()
        {
            if (head == null)
            {
                throw new NullReferenceException();
            }
            else
            {
                var returning = head;
                head = returning.Next;

                return returning.Value;
            }
        }

        public bool Contains(T value)
        {
            var next = head;
            while (next != null)
            {
                if (next.Value.Equals(value))
                {
                    return true;
                }
                next = next.Next;
            }
            return false;
        }

        class Node(T value)
        {
            public T Value = value;
            public Node? Next;
        }
    }
}
