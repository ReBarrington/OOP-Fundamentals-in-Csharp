using System;
using System.Collections.Generic;

namespace ACM
{
    public class Product
    {
        public Product()
        {
        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public string ProductName { get; set; }
        public string ProductId { get; private set; }

        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }
        // ? means can be null

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (string.IsNullOrWhiteSpace(ProductDescription)) isValid = false;

            return isValid;
        }
    }
}