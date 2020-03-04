using NUnit.Framework;

namespace DataStructures.UnitTests
{
    [TestFixture]
    class LinkedListsTests
    {
        [Test]
        public void GetHead_NullHead_ReturnsNull()
        {
            var list = new LinkedList(null);

            Assert.That(list.GetHead(), Is.Null);
        }

        [Test]
        public void GetHead_ObjectHead_ReturnsThatObject()
        {
            var node = new Node(5);
            var list = new LinkedList(node);

            Assert.That(list.GetHead() == node);
        }
        [Test]
        public void GetTail_NullHead_ReturnsNull()
        {
            var list = new LinkedList(null);

            Assert.That(list.GetTail(), Is.Null);
        }

        [Test]
        public void GetTail_HeadIsTail_ReturnsHead()
        {
            var head = new Node(2);
            var list = new LinkedList(head);

            Assert.That(list.GetTail() == head);
        }

        [Test]
        public void GetTail_ObjectIsTail_ReturnThatObject()
        {
            var tail = new Node(2);
            var head = new Node(5, tail);
            var list = new LinkedList(head);

            Assert.That(list.GetTail() == tail);
        }

        [Test]
        public void Search_NullList_ReturnsFalse()
        {
            var list = new LinkedList(null);

            Assert.That(list.Search(null), Is.False);
            Assert.That(list.Search(5), Is.False);
        }

        [Test]
        public void Search_ItemNotInList_ReturnsFalse()
        {
            LinkedList list = CreateListWith_1_2_3();

            Assert.That(list.Search(null), Is.False);
            Assert.That(list.Search(4), Is.False);
        }

        [Test]
        public void Search_HeadItem_ReturnsTrue()
        {
            LinkedList list = CreateListWith_1_2_3();

            Assert.That(list.Search(1), Is.True);
        }

        [Test]
        public void Search_MiddleItem_ReturnsTrue()
        {
            LinkedList list = CreateListWith_1_2_3();

            Assert.That(list.Search(2), Is.True);
        }

        [Test]
        public void Search_TailItem_ReturnsTrue()
        {
            LinkedList list = CreateListWith_1_2_3();

            Assert.That(list.Search(3), Is.True);
        }

        [Test]
        public void GetDataInOrder_Nulllist_ReturnsEmptyString()
        {
            LinkedList list = new LinkedList(null);
            string expectedString = "";
            string dataInOrder = list.GetDataInOrder();

            Assert.That(dataInOrder.Equals(expectedString));
        }

        [Test]
        public void GetDataInOrder_HeadOnlylist_ReturnsSingleDataString()
        {
            LinkedList list = new LinkedList(new Node(3));
            string expectedString = "3";
            string dataInOrder = list.GetDataInOrder();

            Assert.That(dataInOrder.Equals(expectedString));
        }

        [Test]
        public void GetDataInOrder_FullList_ReturnsDataFilledString()
        {
            LinkedList list = CreateLargeList();
            string expectedString = ForwardsOrderedList();
            string dataInOrder = list.GetDataInOrder();

            Assert.That(dataInOrder.Equals(expectedString));
        }

        /*
        [Test]
        public void GetDataInReverseRecursively_FullList_ReturnEmptyString()
        {
            LinkedList list = CreateLargeList();
            string expectedString = ReverseOrderedList();
            string dataInOrder = list.GetDataInReverRecursively();

            Assert.That(dataInOrder.Equals(expectedString));
        }

        [Test]
        public void GetDataInReverseRecursively_HeadOnlyList_ReturnEmptyString()
        {
            LinkedList list = new LinkedList(new Node(3));
            string expectedString = "3";
            string dataInOrder = list.GetDataInReverRecursively();

            Assert.That(dataInOrder.Equals(expectedString));
        }

        [Test]
        public void GetDataInReverseRecursively_EmptyList_ReturnEmptyString()
        {
            LinkedList list = new LinkedList(null);
            string expectedString = "";
            string dataInOrder = list.GetDataInReverRecursively();

            Assert.That(dataInOrder.Equals(expectedString));
        }
        */

        private LinkedList CreateListWith_1_2_3()
        {
            var tail = new Node(3);
            var middle = new Node(2, tail);
            var head = new Node(1, middle);
            return new LinkedList(head);
        }

        private readonly int largeListSize = 100000;
        public LinkedList CreateLargeList()
        {
            int size = largeListSize;
            var next = new Node(size);
            for (int i = size-1; i > 0; i--)
            {
                var current = new Node(i, next);
                next = current;
            }
            return new LinkedList(next);
        }

        public string ForwardsOrderedList()
        {
            int size = largeListSize;
            string ordered = "";
            string seperator = " - ";
            for (int i = 1; i < size; i++)
            {
                ordered += i.ToString() + seperator;
            }
            ordered += size.ToString();
            return ordered;
        }

        private string ReverseOrderedList()
        {
            int size = largeListSize;
            int min = 1;
            string ordered = "";
            string seperator = " - ";
            for (int i = size; i > min; i--)
            {
                ordered += i.ToString() + seperator;
            }
            ordered += min.ToString();
            return ordered;
        }

    }
}
