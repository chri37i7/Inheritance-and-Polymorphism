using System;

namespace Polymorfi.Entities
{
    /// <summary>
    /// Concreate class representing an <see cref="Expense"/>
    /// </summary>
    public class Expense : IPayable
    {
        #region Fields
        protected DateTime date;
        protected decimal amount;
        protected bool isProcessed;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new <see cref="Expense"/> object
        /// </summary>
        /// <param name="date"></param>
        /// <param name="amount"></param>
        public Expense(DateTime date, decimal amount)
        {
            Date = date;
            Amount = amount;
        } 
        #endregion

        #region Properties
        /// <summary>
        /// The date of the <see cref="Expense"/>
        /// </summary>
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

        /// <summary>
        /// The amount of the <see cref="Expense"/>
        /// </summary>
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
        /// <summary>
        /// Returns the <see cref="amount"/> of the <see cref="Expense"/>
        /// </summary>
        /// <returns></returns>
        public virtual decimal GetAmount()
        {
            return amount;
        } 
        #endregion
    }
}