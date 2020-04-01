namespace ITI.UI.DP.BankAccount
{
    class CreditCard : IAccount
    {
        private Account _account;
        public int Balance { get; set; }

        public CreditCard(Account account)
        {
            _account = account;
        }

        public CreditCard()
        {
            _account = new Account();
        }
        public bool ChargeAccount(int amount)
        {
            if (_account.Balance >= amount)
            {
                Logging.Log($"{this.GetType().Name} charge of {amount:C} succeeded");
            }
            else
            {
                Logging.Log($"{this.GetType().Name} charge of {amount:C} succeeded, as overcharge");
            }
            _account.Balance -= amount;
            return true;
        }
    }
}