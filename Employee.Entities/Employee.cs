using System;

namespace Employee.Entities
{
    /// <summary>
    /// <see cref="Employee"/> is an abstract class that is a subclass of <see cref="IPayable"/> and has three instance variables.
    /// </summary>
    public abstract class Employee : IPayable
    {
        #region Fields
        protected string firstname;
        protected string lastname;
        protected string socialSecurityNumber; 
        #endregion

        #region Constructors
        protected Employee(string firstname, string lastname, string socialSecurityNumber)
        {
            Firstname = firstname;
            Lastname = lastname;
            SocialSecurityNumber = socialSecurityNumber;
        }
        #endregion

        #region Properties
        public virtual string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                if(firstname != value)
                {
                    firstname = value;
                }
            }
        }

        public virtual string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                if(lastname != value)
                {
                    lastname = value;
                }
            }
        }

        public virtual string SocialSecurityNumber
        {
            get
            {
                return socialSecurityNumber;
            }
            set
            {
                if(socialSecurityNumber != value)
                {
                    socialSecurityNumber = value;
                }
            }
        } 
        #endregion

        #region Methods
        public virtual double GetPaymentAmount()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}