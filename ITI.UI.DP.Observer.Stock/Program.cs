using System;

namespace ITI.UI.DP.Observer.Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            IBM ibm = new IBM("IBM", 100);
            var ahmed = new Investor("Ahmed");
            ibm.Subscribe(ahmed);
            ibm.Subscribe(new Investor("Hossam"));
            ibm.Price = 200;
            ibm.Price = 300;
            ibm.Unsubscribe(ahmed);
            ibm.Price = 400;
        }
    }
}
