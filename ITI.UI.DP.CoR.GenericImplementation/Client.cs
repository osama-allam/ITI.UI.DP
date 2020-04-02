using System;
using System.Collections.Generic;

namespace ITI.UI.DP.CoR.GenericImplementation
{
    class Client
    {
        public static void HandleRequest(AbstractHandler handler)
        {
            var requests = new List<string> {"first request", "second request", "third request"};
            foreach (var request in requests)
            {
                Console.WriteLine($"Client: Who wants to handle \"{request.ToString()}\"?");
                var result = handler.Handle(request);
                if (result != null)
                {
                    Console.WriteLine($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {request} was left unhandled.");
                }
            }
        }
    }
}