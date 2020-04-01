using System.Diagnostics;

namespace ITI.UI.DP.BankAccount
{
    class Logging
    {
        public static void Log(string value)
        {
            Debug.WriteLine(value);
        }
        public static void LineSeparator(int length = 40)
        {
            Debug.WriteLine(new string('-', length));
        }
    }
}