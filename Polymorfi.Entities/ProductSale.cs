using System;
using System.Collections.Generic;

namespace Polymorfi.Entities
{
    /// <summary>
    /// Represents a sale of one or more <see cref="Product"/>'s
    /// </summary>
    public class ProductSale : Sale
    {
        #region Fields
        protected Dictionary<Product, int> productQuantities; 
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new <see cref="ProductSale"/> object
        /// </summary>
        /// <param name="productQuantities"></param>
        /// <param name="date"></param>
        /// <param name="employeeId"></param>
        public ProductSale(Dictionary<Product, int> productQuantities, DateTime date, int employeeId) 
            : base(date, employeeId)
        {
            ProductQuantities = productQuantities;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Contains <see cref="Product"/>'s and the quantities
        /// </summary>
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
        /// <summary>
        /// Adds a product, and quantity to <see cref="productQuantities"/>
        /// </summary>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        public virtual void Add(Product product, int quantity)
        {
            productQuantities.Add(product, quantity);
        }

        /// <summary>
        /// Returns the total price of all products in <see cref="productQuantities"/>
        /// </summary>
        /// <returns></returns>
        public override decimal GetAmount()
        {
            // Int for storing total price of all products in productQuantities
            decimal totalPrice = 0;

            // Get the total price of all products in productQuantities
            foreach(KeyValuePair<Product, int> product in productQuantities)
            {
                totalPrice += (Convert.ToDecimal(product.Value) * product.Key.UnitPrice);
            }

            // Return totalPrice
            return totalPrice;
        }
        #endregion
    }
}