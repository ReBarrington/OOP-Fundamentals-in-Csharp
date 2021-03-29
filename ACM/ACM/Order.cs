using System;
using System.Collections.Generic;

namespace ACM
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public string OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
    }
}