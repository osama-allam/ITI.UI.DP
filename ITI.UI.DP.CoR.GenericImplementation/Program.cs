using System;
using System.Collections.Generic;

namespace ITI.UI.DP.CoR.GenericImplementation
{
    interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object Handle(object request);
    }
    abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual object Handle(object request)
        {
            if (_nextHandler != null)
            {
                return _nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }

    class FirstHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "first request")
            {
                return $"First Handler: I'll handle the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
    
    class SecondHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "second request")
            {
                return $"Second Handler: I'll handle the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
    class ThirdHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "third request")
            {
                return $"Third Handler: I'll handle the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

    class Client
    {
        public static void HandleRequest(AbstractHandler handler, List<string> requests)
        {
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
