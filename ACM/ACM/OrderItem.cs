using System;
using System.Collections.Generic;

namespace ACM
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }



        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (PurchasePrice <= 0) isValid = false;

            return isValid;
        }

    }
}