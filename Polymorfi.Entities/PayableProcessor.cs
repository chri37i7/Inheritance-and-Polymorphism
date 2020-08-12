using System;
using System.Collections.Generic;

namespace Polymorfi.Entities
{
    public class PayableProcessor
    {
        #region Fields
        private Account salesAccount;
        private Account expensesAccount;
        #endregion

        #region Constructors
        public PayableProcessor(Account salesAccount, Account expensesAccount)
        {
            SalesAccount = salesAccount;
            ExpensesAccount = expensesAccount;
        } 
        #endregion

        #region Properties
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
        public virtual void Process(List<IPayable> payables)
        {
            foreach(IPayable payable in payables)
            {
                switch(payable is Sale)
                {
                    case true:
                        // Withdraw the expense
                        salesAccount.Deposit(payable.GetAmount());
                        // Set IsProcessed to true
                        payable.IsProcessed = true;
                        // Stop
                        break;
                    case false:
                        // Withdraw the expense
                        expensesAccount.Withdraw(payable.GetAmount());
                        // Set IsProcessed to true
                        payable.IsProcessed = true;
                        // Stop
                        break;
                }
            }
        } 
        #endregion
    }
}