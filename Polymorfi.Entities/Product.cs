namespace Polymorfi.Entities
{
    public class Product
    {
        #region Fields
        protected string name;
        protected decimal unitPrice; 
        #endregion

        #region Constructors
        public Product(string name, decimal unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
        } 
        #endregion

        #region Properties
        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(name != value)
                {
                    name = value;
                }
            }
        }

        public virtual decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                if(unitPrice != value)
                {
                    unitPrice = value;
                }
            }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{name}: {unitPrice}";
        }
        #endregion
    }
}