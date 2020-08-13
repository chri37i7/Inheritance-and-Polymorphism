using System.Collections.Generic;

namespace Polymorfi.Entities
{
    /// <summary>
    /// Represents a processor for processing multiple <see cref="IPayable"/>'s
    /// </summary>
    public class PayableProcessor
    {
        #region Fields
        private Account salesAccount;
        private Account expensesAccount;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new <see cref="PayableProcessor"/> object
        /// </summary>
        /// <param name="salesAccount"></param>
        /// <param name="expensesAccount"></param>
        public PayableProcessor(Account salesAccount, Account expensesAccount)
        {
            SalesAccount = salesAccount;
            ExpensesAccount = expensesAccount;
        } 
        #endregion

        #region Properties
        /// <summary>
        /// <see cref="Account"/> for depositing money from sales
        /// </summary>
        public Account SalesAccount
        {
            get
            {
                return salesAccount;
            }
            set
            {
                if(salesAccount != value)
                {
                    salesAccount = value;
                }
            }
        }

        /// <summary>
        /// <see cref="Account"/> for withdrawing money from expenses
        /// </summary>
        public Account ExpensesAccount
        {
            get
            {
                return expensesAccount;
            }
            set
            {
                if(expensesAccount != value)
                {
                    expensesAccount = value;
                }
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Processes a list of <see cref="IPayable"/>'s
        /// </summary>
        /// <param name="payables"></param>
        public virtual void Process(List<IPayable> payables)
        {
            foreach(IPayable payable in payables)
            {
                // Get the amount
                decimal amount = payable.GetAmount();

                if(payable is Sale)
                {
                    // Deposit the amount
                    salesAccount.Deposit(amount);
                    // Set IsProcessed to true
                    payable.IsProcessed = true;
                }
                else if(payable is Expense)
                {
                    // Withdraw the amount
                    expensesAccount.Withdraw(amount);
                    // Set IsProcessed to true
                    payable.IsProcessed = true;
                }
            }
        } 
        #endregion
    }
}