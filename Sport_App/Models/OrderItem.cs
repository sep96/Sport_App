using System;
using System.Collections.Generic;

namespace Sport_App.Models
{
    public partial class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public string ProductId { get; set; }
        public int? Quantity { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
