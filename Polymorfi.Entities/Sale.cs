using System;

namespace Polymorfi.Entities
{
    /// <summary>
    /// Abstract baseclass for <see cref="Sale"/>'s implementing <see cref="IPayable"/>
    /// </summary>
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
        /// <summary>
        /// The date the <see cref="Sale"/> occurred
        /// </summary>
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

        /// <summary>
        /// The <see cref="EmployeeId"/> of the employee who handled the <see cref="Sale"/>
        /// </summary>
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

        /// <summary>
        /// Has the <see cref="Sale"/> been processed yet
        /// </summary>
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
        public abstract decimal GetAmount();
        #endregion
    }
}