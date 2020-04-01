namespace ITI.UI.DP.Observer.Stock
{
    interface IInvestor //subscriber
    {
        void Update(Stock stock);
    }
}