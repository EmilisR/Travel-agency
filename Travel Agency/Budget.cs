using System;

namespace Travel_Agency
{
    [Serializable]
    static partial class Budget
    {
        public static void AddToBudget(double amount)
        {
            Balance = Balance + amount;
            Income = Income + amount;
            Outcome = Outcome + (amount / 100 * (100 - Convert.ToInt32(Program.ReadSetting("Percentage of income to be profit", "App.config"))));
            Profit = Income - Outcome;
        }
        public static void ReduceFromBudget(double amount)
        {
            Balance = Balance - amount;
            Outcome = Outcome + amount;
            Profit = Income - Outcome;
            IsBankrupt();
        }

        public delegate void BankruptEventHandler(BankruptEventArgs e);

        public static event BankruptEventHandler Bankrupt;

        public static bool IsBankrupt()
        {
            if (Balance < Convert.ToInt32(Program.ReadSetting("Limit of bankrupt", "App.config")))
            {
                Bankrupt(new BankruptEventArgs(Balance));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
