using System;
using System.Collections.Generic;

namespace Polymorfi.Entities
{
    public class ProductSale : Sale
    {
        #region Fields
        protected Dictionary<Product, int> productQuantities; 
        #endregion

        #region Constructors
        public ProductSale(Dictionary<Product, int> productQuantities, DateTime date, int employeeId) 
            : base(date, employeeId)
        {
            ProductQuantities = productQuantities;
        }
        #endregion

        #region Properties
        public virtual Dictionary<Product, int> ProductQuantities
        {
            get
            {
                return productQuantities;
            }
            set
            {
                if(productQuantities != value)
                {
                    productQuantities = value;
                }
            }
        }
        #endregion

        #region Methods
        public virtual void Add(Product product, int quantity)
        {
            productQuantities.Add(product, quantity);
        }

        public override decimal GetAmount()
        {
            decimal totalPrice = 0;

            foreach(KeyValuePair<Product, int> product in productQuantities)
            {
                totalPrice += (Convert.ToDecimal(product.Value) * product.Key.UnitPrice);
            }

            return totalPrice;
        }
        #endregion
    }
}