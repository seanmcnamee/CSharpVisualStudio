using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = CreateLargeList();
            Console.WriteLine(list.GetDataInReverseIteratively());
        }

        private static readonly int largeListSize = 100000;
        public static LinkedList CreateLargeList()
        {
            int size = largeListSize;
            var next = new Node(size);
            for (int i = size - 1; i > 0; i--)
            {
                var current = new Node(i, next);
                next = current;
            }
            return new LinkedList(next);
        }
    }
}
