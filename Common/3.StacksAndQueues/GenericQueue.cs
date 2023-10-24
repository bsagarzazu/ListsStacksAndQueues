using System.Runtime.ExceptionServices;

namespace Common
{

    public class GenericQueue<T> : IPushPop<T>
    {
        //TODO #1: Declare a List inside this object class to store the objects. Choose the most appropriate object class
        private GenericList<T> MyList;
        //private GenericArrayList<T> MyList;

        public GenericQueue()
        {
            MyList = new GenericList<T>();
            //MyList = new GenericArrayList<T>(10);
        }

        public string AsString()
        {
            //TODO #2: Return the list as a string. Use the method already implemented in your list
            return MyList.AsString();
        }

        public int Count()
        {
            //TODO #3: Return the number of objects
            return MyList.Count();
        }

        public void Clear()
        {
            //TODO #4: Remove all objects stored
            MyList.Clear();
        }

        public void Push(T value)
        {
            //TODO #5: Add a new object to the list (at the end of it)
            MyList.Add(value);
        }

        public T Pop()
        {
            //TODO #6: Remove the first object of the list and return it
            GenericListNode<T> node = MyList.getFirst();
            MyList.Remove(0);
            return node.Value;
            /*T value = MyList.Get(0);
            MyList.Remove(0);
            return value;*/
        }

        /* # Measuring performance (n=10000)
         * 
         * Using GenericList
         * Push (n=10000) -> 0.00031 s O(1)
         * Pop (n=10000) -> 0.00024 s O(1)
         * 
         * Using GenericArrayList
         * Push (n=10000) -> 0.21724 s O(1) (O(n) if there is not space for the new element)
         * Pop (n=10000) -> 0.65901 s O(1)
         * 
         * My choice -> GenericList
         */
    }
}