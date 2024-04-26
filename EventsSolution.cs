using System;
namespace EventsSolution
{
    public delegate void BalanceEventHandler(decimal theValue);

    class PiggyBank
    {
        private decimal m_bankBalance;
        public event BalanceEventHandler BalanceChanged;

        public decimal theBalance
        {
            set
            { m_bankBalance = value; BalanceChanged(value); }
            get { return m_bankBalance; }
        }
    }

    class BalanceLogger
    {
        public void BalanceLog(decimal amount)
        {
            Console.WriteLine($"The balance amount is {amount}");
        }
    }

    class BalanceWatcher
    {
        public void BalanceWatch(decimal amount)
        {
            if (amount > 500.0m)
                Console.WriteLine($"You reached your saving goal! You have U$ {amount}");
        }
    }
}