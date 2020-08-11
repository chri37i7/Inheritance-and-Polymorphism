namespace Employee.Entities
{
    /// <summary>
    /// <see cref="BasePlusCommisionEmployee"/> is a concrete class that is a subclass of <see cref="CommissionEmployee"/> and adds one instance variable.
    /// </summary>
    public class BasePlusCommisionEmployee : CommissionEmployee
    {
        #region Fields
        protected double baseSalary; 
        #endregion

        #region Constructors
        public BasePlusCommisionEmployee(double baseSalary, double grossSales, double commissionRate, string firsname, string lastname, string socialSecurityNumber)
            : base(grossSales, commissionRate, firsname, lastname, socialSecurityNumber)
        {
            BaseSalary = baseSalary;
        }
        #endregion

        #region Properties
        public virtual double BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if(baseSalary != value)
                {
                    baseSalary = value;
                }
            }
        }
        #endregion

        #region Methods
        public override double GetPaymentAmount()
        {
            return (grossSales / commissionRate) + baseSalary;
        } 
        #endregion
    }
}