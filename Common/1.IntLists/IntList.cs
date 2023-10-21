using System;
using System.Runtime.ConstrainedExecution;

namespace Common
{
    public class IntListNode
    {
        public int Value;
        public IntListNode Next = null;

        public IntListNode(int value)
        {
            Value = value;
        }
    }

    public class IntList : IList
    {
        private IntListNode First = null;
        private IntListNode Last = null;
        private int numElements = 0;

        //This method returns all the elements on the list as a string
        //Use it as an example on how to access all the elements on the list
        public string AsString()
        {
            IntListNode node = First;
            string output = "[";

            while (node != null)
            {
                output += node.Value + ",";
                node = node.Next;
            }
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        
        public void Add(int value)
        {
            //TODO #1: add a new integer to the end of the list
            if (First == null)
            {
                First = new IntListNode(value);
                Last = First;
            }
            else
            {
                Last.Next = new IntListNode(value);
                Last = Last.Next;
            }
            numElements++;
        }

        private IntListNode GetNode(int index)
        {
            //TODO #2: Return the element in position 'index'
            int currentPos = 0;
            IntListNode currentNode = First;
            while (currentPos < index && currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                currentPos++;
            }
            if (currentPos == index)
            {
                return currentNode; 
            }
            return null;
        }

        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). O if the position is out of bounds
            if (GetNode(index) != null)
            {
                return GetNode(index).Value;
            }
            else
            {
                return 0;
            }
        }
        
        public int Count()
        {
            //TODO #4: return the number of elements on the list
            return numElements;
        }
        
        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            IntListNode node = GetNode(index);
            if (node == First)
            {
                First = First.Next;
                numElements--;
            }
            else if (node == Last)
            {
                Last = GetNode(index - 1);
                numElements--;
            }
            else if (node != null)
            {
                GetNode(index - 1).Next = GetNode(index + 1);
                numElements--;
            }
        }

        
        public void Clear()
        {
            //TODO #6: remove all the elements on the list
            First = null;
            Last = null;
            numElements = 0;
        }
    }
}