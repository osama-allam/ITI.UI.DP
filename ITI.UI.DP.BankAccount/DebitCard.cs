namespace ITI.UI.DP.BankAccount
{
    class DebitCard : IAccount
    {
        private Account _account;
        public int Balance { get; set; }

        public DebitCard(Account account)
        {
            _account = account;
        }

        public DebitCard()
        {
            _account = new Account();
        }
        public bool ChargeAccount(int amount)
        {
            if (_account.Balance >= amount)
            {
                _account.Balance -= amount;
                Logging.Log($"{this.GetType().Name} charge of {amount:C} succeeded");
                return true;
            }
            Logging.Log($"{this.GetType().Name} charge of {amount:C} failed due to not enough balance");
            return false;
        }
    }
}