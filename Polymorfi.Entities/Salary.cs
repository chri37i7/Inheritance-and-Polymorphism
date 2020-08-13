using System;

namespace Polymorfi.Entities
{
    /// <summary>
    /// Represents the <see cref="Salary"/> of an employee
    /// </summary>
    public class Salary : Expense
    {
        #region Fields
        protected int employeeId;
        protected int month;
        protected int year;
        protected byte salaryCode;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new <see cref="Salary"/> object
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <param name="salaryCode"></param>
        /// <param name="date"></param>
        /// <param name="amount"></param>
        public Salary(int employeeId, int month, int year, byte salaryCode, DateTime date, decimal amount)
            : base(date, amount)
        {
            EmployeeId = employeeId;
            Month = month;
            Year = year;
            SalaryCode = salaryCode;
        }
        #endregion

        #region Properties
        /// <summary>
        /// The id of the employee
        /// </summary>
        public virtual int EmployeeId
        {
            get
            {
                return employeeId;
            }
            set
            {
                if(employeeId != value)
                {
                    employeeId = value;
                }
            }
        }

        /// <summary>
        /// The month of the <see cref="Salary"/>
        /// </summary>
        public virtual int Month
        {
            get
            {
                return month;
            }
            set
            {
                if(month != value)
                {
                    month = value;
                }
            }
        }

        /// <summary>
        /// The year of the <see cref="Salary"/>
        /// </summary>
        public virtual int Year
        {
            get
            {
                return year;
            }
            set
            {
                if(year != value)
                {
                    year = value;
                }
            }
        }

        /// <summary>
        /// <see cref="SalaryCode"/> specifies the employees salary
        /// </summary>
        public virtual byte SalaryCode
        {
            get
            {
                return salaryCode;
            }
            set
            {
                if(salaryCode != value)
                {
                    salaryCode = value;
                }
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the salary of the employee depending on their <see cref="salaryCode"/>
        /// </summary>
        /// <returns></returns>
        public override decimal GetAmount()
        {
            switch(salaryCode)
            {
                case 2:
                    return 25000;
                case 3:
                    return 27000;
                case 4:
                    return 18000;
                case 8:
                    return 15000;
                case 9:
                    return 17000;
                default:
                    return 0;
            }
        }
        #endregion
    }
}