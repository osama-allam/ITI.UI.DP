using System;
using System.Collections.Generic;

namespace ITI.UI.DP.CoR.GenericImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var requests = new List<string> {"first request", "second request", "third request"};

            var firstHandler = new FirstHandler();
            var secondHandler = new SecondHandler();
            var thirdHandler = new ThirdHandler();
            firstHandler.SetNext(secondHandler).SetNext(thirdHandler);
            Console.WriteLine("first => second => third");
            Client.HandleRequest(firstHandler, requests);
            Console.WriteLine(new string('=', 60));
            Console.WriteLine("second => third");
            Client.HandleRequest(secondHandler, requests);
            Console.ReadKey();
        }
    }
}
