using System;

namespace Polymorfi.Entities
{
    public class Expense : IPayable
    {
        #region Fields
        protected DateTime date;
        protected decimal amount;
        protected bool isProcessed;
        #endregion

        #region Constructors
        public Expense(DateTime date, decimal amount)
        {
            Date = date;
            Amount = amount;
        } 
        #endregion

        #region Properties
        public virtual DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                if(date != value)
                {
                    date = value; 
                }
            }
        }

        public virtual decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if(amount != value)
                {
                    amount = value; 
                }
            }
        }

        public virtual bool IsProcessed
        {
            get
            {
                return isProcessed;
            }
            set
            {
                if(isProcessed != value)
                {
                    isProcessed = value; 
                }
            }
        } 
        #endregion

        #region Methods
        public virtual decimal GetAmount()
        {
            return amount;
        } 
        #endregion
    }
}