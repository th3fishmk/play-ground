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

        public void Prepend(T value)
        {
            // insert a new vale at the beginning of the list
            // move the head to a new variable
            // create a new head
            // point the head to the new variable
            var newHead = new Node<T>(value);
            var oldHead = head;
            head = newHead;
            head.Next = oldHead;
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
