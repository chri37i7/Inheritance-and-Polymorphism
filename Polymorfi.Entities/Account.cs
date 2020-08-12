namespace Polymorfi.Entities
{
    public class Account
    {
        #region Fields
        private decimal balance; 
        #endregion

        #region Constructors
        public Account(decimal balance)
        {
            Balance = balance;
        }
        #endregion

        #region Properties
        public virtual decimal Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if(balance != value)
                {
                    balance = value;
                }
            }
        }
        #endregion

        #region Methods
        public virtual void Deposit(decimal amount)
        {
            balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            balance -= amount;
        }
        #endregion
    }
}