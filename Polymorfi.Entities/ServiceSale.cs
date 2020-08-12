using System;

namespace Polymorfi.Entities
{
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
        public override decimal GetAmount()
        {
            return amount;
        }
        #endregion
    }
}