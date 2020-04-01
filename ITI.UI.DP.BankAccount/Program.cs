using System;
using System.Collections.Generic;

namespace ITI.UI.DP.BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var debitCard = new DebitCard();
            debitCard.ChargeAccount(500);
            debitCard.ChargeAccount(500);
            debitCard.ChargeAccount(500);
            Logging.LineSeparator(60);
            var creditCard = new CreditCard();//1000
            creditCard.ChargeAccount(300);//700
            creditCard.ChargeAccount(400);//300
            creditCard.ChargeAccount(700);//
        }
    }
}
