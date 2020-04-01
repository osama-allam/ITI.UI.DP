using System;
using System.Diagnostics;

namespace ITI.UI.DP.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new WordCollection();
            collection.AddItem("first");
            collection.AddItem("second");
            collection.AddItem("third");
            //foreach (var item in collection)
            //{
            //    Debug.WriteLine(item);
            //}
            var wordsIterator = collection.GetEnumerator();
            while (wordsIterator.MoveNext())
            {
                Debug.WriteLine(wordsIterator.Current);
            }
            Debug.WriteLine(new string('-',60));
            collection.ReverseDirection();
            //foreach (var item in collection)
            //{
            //    Debug.WriteLine(item);
            //}
        }
    }
}
