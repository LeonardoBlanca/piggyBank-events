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
 
}