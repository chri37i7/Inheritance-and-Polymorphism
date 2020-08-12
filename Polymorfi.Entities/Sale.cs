using System;

namespace Polymorfi.Entities
{
    public abstract class Sale : IPayable
    {
        #region Fields
        protected DateTime date;
        protected int employeeId;
        protected bool isProcessed;
        #endregion

        #region Constructors
        protected Sale(DateTime date, int employeeId)
        {
            Date = date;
            EmployeeId = employeeId;
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
                date = value;
            }
        }

        public virtual int EmployeeId
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
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
                isProcessed = value;
            }
        }
        #endregion

        #region Methods
        public virtual decimal GetAmount()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}