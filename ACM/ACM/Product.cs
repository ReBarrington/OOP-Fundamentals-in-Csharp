using System;
using System.Collections.Generic;

namespace ACM
{
    public class Product: EntityBase
    {
        public Product()
        {
        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public string ProductName { get; set; }
        public int ProductId { get; private set; }

        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }
        // ? means can be null

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (string.IsNullOrWhiteSpace(ProductDescription)) isValid = false;

            return isValid;
        }
    }
}