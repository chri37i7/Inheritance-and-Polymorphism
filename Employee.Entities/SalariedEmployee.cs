namespace Employee.Entities
{
    /// <summary>
    /// <see cref="SalariedEmployee"/> is a concrete class that is a subclass of <see cref="Employee"/> and adds one instance variables.
    /// </summary>
    public class SalariedEmployee : Employee
    {
        #region Fields
        protected double weeklySalary;
        #endregion

        #region Constructors
        public SalariedEmployee(double weeklySalary, string firstname, string lastname, string socialSecurityNumber)
            : base(firstname, lastname, socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }
        #endregion

        #region Properties
        public virtual double WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if(weeklySalary != value)
                {
                    weeklySalary = value;
                }
            }
        }
        #endregion

        #region Methods
        public override double GetPaymentAmount()
        {
            return weeklySalary * 4;
        } 
        #endregion
    }
}