using System;
using System.Collections.Generic;

namespace ITI.UI.DP.CoR.GenericImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstHandler = new FirstHandler();
            var secondHandler = new SecondHandler();
            var thirdHandler = new ThirdHandler();
            firstHandler.SetNext(secondHandler).SetNext(thirdHandler);
            Console.WriteLine("first => second => third");
            Client.HandleRequest(firstHandler);
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("second => third");
            Client.HandleRequest(secondHandler);
            Console.ReadKey();
        }
    }
}
