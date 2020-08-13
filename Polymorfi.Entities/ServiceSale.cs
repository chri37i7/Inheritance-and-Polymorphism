using System;

namespace Polymorfi.Entities
{
    /// <summary>
    /// Represents a sale of a service
    /// </summary>
    public class ServiceSale : Sale
    {
        #region Fields
        protected decimal amount; 
        #endregion

        #region Constructor
        public ServiceSale(decimal amount, DateTime date, int employeeId)
            : base(date, employeeId)
        {
            Amount = amount;
        }
        #endregion

        #region Properties
        /// <summary>
        /// The money amount of the <see cref="ServiceSale"/>
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
        #endregion

        #region Methods
        /// <summary>
        /// Returns the <see cref="amount"/>
        /// </summary>
        /// <returns></returns>
        public override decimal GetAmount()
        {
            return amount;
        }
        #endregion
    }
}