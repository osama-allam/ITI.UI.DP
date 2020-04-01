namespace ITI.UI.DP.BankAccount
{
    interface IAccount
    {
        int Balance { get; set; }
        bool ChargeAccount(int amount);
    }
}