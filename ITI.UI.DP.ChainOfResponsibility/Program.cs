using System;

namespace ITI.UI.DP.CoR.ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Method1();
                Console.ReadKey();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(new string('=', 60));
                Console.WriteLine("Main: handled ArgumentException");
                Method2();
            }
            catch (Exception ex)
            {
                Console.WriteLine(new string('=', 60));
                Console.WriteLine("Main: handle generic exception");
                Method2();
            }
        }

        static void Method1()
        {
            try
            {
                Method2();
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(new string('=', 60));
                Console.WriteLine("Method1: handled NullReferenceException");
                Method2();
            }
        }

        static void Method2()
        {
            try
            {
                Console.WriteLine("Choose a number o fire and exception");
                Console.WriteLine("1- AccessViolationException");
                Console.WriteLine("2- NullReferenceException");
                Console.WriteLine("3- ArgumentException");
                Console.WriteLine("4- NotSupportedException");
                var input = Console.ReadKey().Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        throw new AccessViolationException();
                    case ConsoleKey.D2:
                        throw new NullReferenceException();
                    case ConsoleKey.D3:
                        throw new ArgumentException();
                    case ConsoleKey.D4:
                        throw new NotSupportedException();
                }
            }
            catch (AccessViolationException ave)
            {
                Console.WriteLine(new string('=', 60));
                Console.WriteLine("Method2: handled AccessViolationException");
                Method2();
            }
        }
    }
}
