using System;

namespace DataStructures
{
    public class Node
    {
        private object Data;
        private Node Next;

        public Node(object data)
        {
            this.Data = data;
        }

        public Node(object data, Node next)
            : this(data)
        {
            this.Next = next;
        }

        public object GetData()
        {
            return this.Data;
        }

        public Node GetNext()
        {
            return this.Next;
        }

        public void SetNext(Node next)
        {
            this.Next = next;
        }

        public bool Equals(Node other)
        {
            if (other == null)
                throw new ArgumentNullException("other", "Comparison Node must be initialized");
            
            return other.Data.Equals(this.Data);
        }

    }
}
