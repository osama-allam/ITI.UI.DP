namespace ITI.UI.DP.BankAccount
{
    class Account: IAccount
    {
        private int _balance = 1000;

        public int Balance
        {
            get => _balance;
            set
            {
                if (_balance == value)
                {
                    return;
                }
                Logging.Log($"Your balance changed from {_balance:C2} to {value:C2}");
                _balance = value;
            }
        }

        public bool ChargeAccount(int amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Logging.Log($"{this.GetType().Name} charge of {amount:C} succeeded");
                return true;
            }
            Logging.Log($"{this.GetType().Name} charge of {amount:C} failed due to insufficient funds");
            return false;
        }
    }
}