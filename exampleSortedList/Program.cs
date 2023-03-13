using System;
using System.Collections.Immutable;

namespace exampleSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> newSortedList = new SortedList<string, int>();
            // add items
            newSortedList.Add("A", 1);
            newSortedList.Add("B", 2);
            newSortedList.Add("C", 3);
            newSortedList.Add("D", 4);
            newSortedList.Add("E", 5);
            // allow value entering (yay)
            Console.WriteLine("Please input a string value key");
            string inputvalue = Console.ReadLine();
            Console.WriteLine("Please input a int value");
            int inputintvalue = int.Parse(Console.ReadLine());
            newSortedList.Add(inputvalue, inputintvalue);
            // remove
            newSortedList.Remove("A");
            // print items
            foreach (KeyValuePair<string, int> printStuff in newSortedList) Console.WriteLine(printStuff.Key, printStuff.Value);
        }
    }
}