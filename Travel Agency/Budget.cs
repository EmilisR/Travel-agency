using System;

namespace Travel_Agency
{
    [Serializable]
    static class Budget
    {
        public static double Balance { get; set; }
        public static double Income { get; set; }
        public static double Outcome { get; set; }
        public static double Profit { get; set; }

        public static void AddToBudget(double amount)
        {
            Balance = Balance + amount;
            Income = Income + amount;
            Outcome = Outcome + (amount / 100 * (100 - Convert.ToInt32(FileInput.ReadSetting("Percentage of income to be profit", "App.config"))));
            Profit = Income - Outcome;
        }
        public static void ReduceFromBudget(double amount)
        {
            Balance = Balance - amount;
            Outcome = Outcome + amount;
            Profit = Income - Outcome;
            IsBankrupt();
        }
        public static bool IfBudgetPositive()
        {
            if (Balance > 0) return true;
            else return false;
        }

        public delegate void BankruptEventHandler(BankruptEventArgs e);

        public static event BankruptEventHandler Bankrupt;

        public static bool IsBankrupt()
        {
            if (Balance < Convert.ToInt32(FileInput.ReadSetting("Limit of bankrupt", "App.config")))
            {
                if (Bankrupt != null) Bankrupt(new BankruptEventArgs(Balance));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
