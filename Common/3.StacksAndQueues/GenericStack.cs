
namespace Common
{
    public class GenericStack<T> : IPushPop<T>
    {
        //TODO #1: Declare a List inside this object class to store the objects. Choose the most appropriate object class
        //private GenericList<T> MyList;
        private GenericArrayList<T> MyList;

        public GenericStack()
        {
            //MyList = new GenericList<T>();
            MyList = new GenericArrayList<T>(10);
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
            /*GenericListNode<T> node = MyList.getLast();
            MyList.Remove(MyList.Count() - 1);
            return node.Value;*/
            T value = MyList.Get(MyList.Count() - 1);
            MyList.Remove(MyList.Count() - 1);
            return value;
        }

        /* # Measuring performance (n=10000)
         * 
         * Using GenericList
         * Push (n=10000) -> 0.00034 s O(1)
         * Pop (n=10000) -> 0.99231 s O(n) (could be optimized to O(1) adding Previous parameter to GenericListNode class)
         * 
         * Using GenericArrayList
         * Push (n=10000) -> 0.23168 s O(1) (O(n) if there is not space for the new element)
         * Pop (n=10000) -> 0.00033 s O(n) (could be optimized using circular arrays)
         * 
         * My choice -> GenericArrayList
         */
    }
}