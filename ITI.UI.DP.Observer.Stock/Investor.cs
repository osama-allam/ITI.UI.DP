using System.Diagnostics;

namespace ITI.UI.DP.Observer.Stock
{
    class Investor: IInvestor
    {
        public string Name { get; set; }

        public Investor(string name)
        {
            Name = name;
        }
        public void Update(Stock stock)
        {
            Debug.WriteLine($"{Name} notified that {stock.Symbol}'s price changed to {stock.Price}");
        }
    }
}