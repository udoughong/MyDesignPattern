using System;

namespace SDP_IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingCollectionsThroughIterators();
            Console.ReadLine();
        }

        private static void UsingCollectionsThroughIterators()
        {
            Array arr = new Array(5);
            arr.Add(5);
            arr.Add(8);
            arr.Add(92);
            arr.Add(43);
            Console.WriteLine("Iterating over the array...");
            Iterate(arr.CreateIterator());
            LinkedList list = new LinkedList();
            list.Add(80);
            list.Add(12);
            list.Add(1);
            list.Add(52);
            Console.WriteLine("\nIterating over the list...");
            Iterate(list.CreateIterator());
        }

        public static void Iterate(Iterator it)
        {
            it.First();
            while (it.HasNext())
            {
                Console.WriteLine(it.CurrentItem()+" ");
                it.Next();
            }
        }
    }
}
/*Output:
Iterating over the array...
5
8
92
43

Iterating over the list...
80
12
1
52
*/
