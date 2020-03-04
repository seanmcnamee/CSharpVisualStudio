using NUnit.Framework;

namespace DataStructures.UnitTests
{
    [TestFixture]
    public class NodeTests
    {
        [Test]
        public void GetNext_NextIsNull_ReturnsNull()
        {
            var testNode = new Node(5, null);

            Assert.That(testNode.GetNext(), Is.Null);
        }

        [Test]
        public void GetNext_NextIsObject_ReturnsThatObject()
        {
            var endNode = new Node(2);
            var startNode = new Node(1, endNode);

            Assert.That(startNode.GetNext() == endNode);
        }

        [Test] 
        public void Equals_SameDataDifferentPointers_ReturnsTrue()
        {
            var node1 = new Node(5);
            var node2 = new Node(5, node1);

            Assert.That(node1.Equals(node2), Is.True);
        }

        [Test]
        public void Equals_SameObjects_ReturnsTrue()
        {
            var node1 = new Node(5);

            Assert.That(node1.Equals(node1), Is.True);
        }

        [Test]
        public void Equals_DifferentDataSamePointer_ReturnsFalse()
        {
            var node1 = new Node(5);
            var node2 = new Node(2);

            Assert.That(node1.Equals(node2), Is.False);
        }
    }
}
