
using System.Collections;

namespace EnumerableVsEnumerator
{
    public class MyCollection : IEnumerable<int>
    {
        private int[] data = { 1, 2, 3, 4, 5 };
        public IEnumerator<int> GetEnumerator()
        {
            return ((IEnumerable<int>)data).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class IEnumerable_Demo
    {
        public static void Demo()
        {
            var collection = new MyCollection();

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }             
        }
    }

    public class MyEnumerator
    {
        private int[] data = { 1,2,3,4,5 };
        private int position = -1;

        public int Current = data[0];



}
