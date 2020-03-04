using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class LinkedList
    {
        private Node Head;
        private readonly string seperationString = " - ";

        public LinkedList(Node head)
        {
            this.Head = head;
        }

        public Node GetHead()
        {
            return this.Head;
        }

        public bool Search(object data)
        {
            return SearchFromFor(this.Head, data);
        }

        private bool SearchFromFor(Node start, object data)
        {
            if (start == null)
                return false;

            Node traversal = start;
            while (traversal.GetNext() != null && !traversal.GetData().Equals(data))
            {
                traversal = traversal.GetNext();
            }

            return traversal.GetData().Equals(data);
        }

        public Node GetTail()
        {
            return GetTail(this.Head);
        }

        private Node GetTail(Node start)
        {
            if (start == null)
                return start;

            Node traversal = start;
            while (traversal.GetNext() != null)
            {
                traversal = traversal.GetNext();
            }

            return traversal;
        }

        public string GetDataInOrder()
        {
            return GetDataInOrderFrom(this.Head);
        }
        /* //Stack Overflow
        private String GetDataInOrderFrom(Node current)
        {
            if (current == null)
                return "";

            if (current.GetNext() == null)
                return current.GetData().ToString();

            //var seperationString = (current == this.Head) ? "" : this.seperationString;
            return current.GetData().ToString() + this.seperationString + GetDataInReverseRecursively(current.GetNext());
        }*/
        private string GetDataInOrderFrom(Node start)
        {
            string returnString = "";

            if (start == null)
                return returnString;

            Node traversal = start;
            while (traversal.GetNext() != null)
            {
                returnString += traversal.GetData().ToString() + this.seperationString;
                traversal = traversal.GetNext();
            }
            returnString += traversal.GetData().ToString();

            return returnString;
        }

        /* //Stack Overflow
        public String GetDataInReverRecursively()
        {
            return GetDataInReverseRecursively(this.Head);
        }
        private String GetDataInReverseRecursively(Node current)
        {
            if (current == null)
                return "";

            if (current.GetNext() == null)
                return current.GetData().ToString();

            //var seperationString = (current == this.Head) ? "" : this.seperationString;
            return GetDataInReverseRecursively(current.GetNext()) + this.seperationString + current.GetData().ToString();
        }*/

        //SLOW (as compared to recursively)
        public String GetDataInReverseIteratively()
        {
            if (this.Head == null)
                return "";
            var returnString = "";
            var current = this.Head;

            while (current != null)
            {
                returnString = current.GetData().ToString() + ((current == this.Head)? "" : this.seperationString) + returnString;
                current = current.GetNext();
            }

            return returnString;
        }
    }
}

