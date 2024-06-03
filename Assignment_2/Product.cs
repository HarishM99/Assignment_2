using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Stock { get; set; }

        public Product(int productID, string productName, decimal productPrice, int stock)
        {
            if (productID < 1 || productID > 5000)
                throw new ArgumentException("ProductID must be in between 1 to 5000 ");
            if (string.IsNullOrEmpty(productName))
                throw new ArgumentException("ProductName cannot be null or empty.");
            if (productPrice < 1 || productPrice > 10000)
                throw new ArgumentException("Price must be between $1 and $5000.");
            if (stock < 1 || stock > 5000)
                throw new ArgumentException("Stock must be between 1 and 1000.");

            ProductID = productID;
            ProductName = productName;
            ProductPrice = productPrice;
            Stock = stock;
        }

        // Methods
        public void IncreaseStock(int quantity)
        {
            Stock += quantity;
        }

        public void DecreaseStock(int quantity)
        {
            if (Stock >= quantity)
            {
                Stock -= quantity;
            }
            else
            {
                throw new InvalidOperationException("Stock is Insufficient.");
            }

        }
    }
}
