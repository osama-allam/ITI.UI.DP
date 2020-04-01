namespace ITI.UI.DP.Observer.Stock
{
    interface IStock //publisher
    {
        void Subscribe(IInvestor investor);
        void Unsubscribe(IInvestor investor);
        void Notify();
    }
}