namespace Csharp
{
    public class MyLinkedList<T>
    {
        public Node<T>? head;

        public void Append(T value)
        {
            var newNode = new Node<T>(value);

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
    }

    public class Node<T>(T value)
    {
        public T Value = value;
        public Node<T>? Next = null;
    }
}
