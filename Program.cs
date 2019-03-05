using System;
using System.Collections.Generic;

namespace TestApps
{
    /// <summary>
    /// Test class to do test stuff
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ReverseALinkedLisr();
        }

        private static void ReverseALinkedLisr()
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddFirst(1);
            myList.AddLast(2);
            myList.AddLast(3);
            myList.AddLast(4);
            myList.AddLast(5);
            myList.AddLast(6);


            foreach (var item in ReverseLinkedList(myList))
            {
                Console.WriteLine(item);
            }
        }

        // This could definately be made faster.
        private static LinkedList<T> ReverseLinkedList<T>(LinkedList<T> list)
        {
            LinkedList<T> myList = new LinkedList<T>();

            foreach(var item in list)
            {
                myList.AddFirst(item);
            }

            return myList;
        }
    
    }
}
