using System;

namespace Polymorfi.Entities
{
    public class Salary : Expense
    {
        #region Fields
        protected int employeeId;
        protected int month;
        protected int year;
        protected byte salaryCode;
        #endregion

        #region Constructors
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