namespace Employee.Entities
{
    /// <summary>
    /// <see cref="CommissionEmployee"/> is a concrete class that is a subclass of <see cref="Employee"/> and adds two instance variables.
    /// </summary>
    public class CommissionEmployee : Employee
    {
        #region Fields
        protected double grossSales;
        protected double commissionRate;
        #endregion

        #region Constructors
        public CommissionEmployee(double grossSales, double commissionRate, string firstname, string lastname, string socialSecurityNumber)
            : base(firstname, lastname, socialSecurityNumber)
        {
            GrossSales = grossSales;
            CommissionRate = commissionRate;
        }
        #endregion

        #region Properties
        public virtual double GrossSales
        {
            get
            {
                return grossSales;
            }
            set
            {
                if(grossSales != value)
                {
                    grossSales = value;
                }
            }
        }

        public virtual double CommissionRate
        {
            get
            {
                return commissionRate;
            }
            set
            {
                if(commissionRate != value)
                {
                    commissionRate = value;
                }
            }
        } 
        #endregion
    }
}