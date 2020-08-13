namespace Polymorfi.Entities
{
    /// <summary>
    /// Represents an <see cref="Account"/> containing money in the <see cref="balance"/>
    /// </summary>
    public class Account
    {
        #region Fields
        private decimal balance; 
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new <see cref="Account"/> object
        /// </summary>
        /// <param name="balance"></param>
        public Account(decimal balance)
        {
            Balance = balance;
        }
        #endregion

        #region Properties
        /// <summary>
        /// The <see cref="balance"/> of the <see cref="Account"/>
        /// </summary>
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
        /// <summary>
        /// Deposits an amount into the <see cref="balance"/>
        /// </summary>
        /// <param name="amount"></param>
        public virtual void Deposit(decimal amount)
        {
            balance += amount;
        }

        /// <summary>
        /// Withdraws an amount from the <see cref="balance"/>
        /// </summary>
        /// <param name="amount"></param>
        public virtual void Withdraw(decimal amount)
        {
            balance -= amount;
        }
        #endregion
    }
}