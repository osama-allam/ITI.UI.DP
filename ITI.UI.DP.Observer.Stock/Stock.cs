using System.Collections.Generic;

namespace ITI.UI.DP.Observer.Stock
{
    class Stock : IStock
    {
        private int _price;

        public int Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify();
                }
            }
        }

        public string Symbol { get; set; }

        public Stock(int price, string symbol)
        {
            _price = price;
            Symbol = symbol;
        }
        private List<IInvestor> _investors = new List<IInvestor>();
        public void Subscribe(IInvestor investor)
        {
            _investors.Add(investor);
        }

        public void Unsubscribe(IInvestor investor)
        {
            _investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.Update(this);
            }
        }
    }
}