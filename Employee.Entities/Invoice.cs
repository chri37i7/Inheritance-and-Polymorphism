using System;

namespace Employee.Entities
{
    /// <summary>
    /// <see cref="Invoice"/> is a concrete class that is a subclass of <see cref="IPayable"/> and has four instance variables.
    /// </summary>
    public class Invoice : IPayable
    {
        #region Fields
        protected string partNumber;
        protected string partDescription;
        protected int quantity;
        protected double pricePerItem;
        #endregion

        #region Constructors
        public Invoice(string partNumber, string partDescription, int quantity, double pricePerItem)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            PricePerItem = pricePerItem;
        }
        #endregion

        #region Properties
        public virtual string PartNumber
        {
            get
            {
                return partNumber;
            }
            set
            {
                if(partNumber != value)
                {
                    partNumber = value;
                }
            }
        }

        public virtual string PartDescription
        {
            get
            {
                return partDescription;
            }
            set
            {
                if(partDescription != value)
                {
                    partDescription = value;
                }
            }
        }

        public virtual int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if(quantity != value)
                {
                    quantity = value;
                }
            }
        }

        public virtual double PricePerItem
        {
            get
            {
                return pricePerItem;
            }
            set
            {
                if(pricePerItem != value)
                {
                    pricePerItem = value;
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