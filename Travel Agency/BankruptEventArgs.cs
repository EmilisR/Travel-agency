using System;

namespace Travel_Agency
{
    public class BankruptEventArgs : EventArgs
    {
        public double CurrentBalance;

        public BankruptEventArgs(double currentBalance)
        {
            CurrentBalance = currentBalance;
        }
    }
}