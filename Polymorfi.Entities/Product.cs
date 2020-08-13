namespace Polymorfi.Entities
{
    /// <summary>
    /// Represents a <see cref="Product"/>
    /// </summary>
    public class Product
    {
        #region Fields
        private string name;
        private decimal unitPrice; 
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new <see cref="Product"/> object
        /// </summary>
        /// <param name="name"></param>
        /// <param name="unitPrice"></param>
        public Product(string name, decimal unitPrice)
        {
            Name = name;
            UnitPrice = unitPrice;
        } 
        #endregion

        #region Properties
        /// <summary>
        /// Name of the <see cref="Product"/>
        /// </summary>
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

        /// <summary>
        /// Unit price of the <see cref="Product"/>
        /// </summary>
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