namespace Employee.Entities
{
    /// <summary>
    /// <see cref="HourlyEmployee"/> is a concrete class that is a subclass of <see cref="Employee"/> and adds two instance variables.
    /// </summary>
    public class HourlyEmployee : Employee
    {
        #region Fields
        protected double wage;
        protected double hours;
        #endregion

        #region Constructors
        public HourlyEmployee(double wage, double hours, string firstname, string lastname, string socialSecurityNumber)
            : base(firstname, lastname, socialSecurityNumber)
        {
            Wage = wage;
            Hours = hours;
        }
        #endregion

        #region Properties
        public virtual double Wage
        {
            get
            {
                return wage;
            }
            set
            {
                if(wage != value)
                {
                    wage = value;
                }
            }
        }

        public virtual double Hours
        {
            get
            {
                return hours;
            }
            set
            {
                if(hours != value)
                {
                    hours = value;
                }
            }
        }
        #endregion

        #region Methods
        public override double GetPaymentAmount()
        {
            return wage * hours;
        } 
        #endregion
    }
}