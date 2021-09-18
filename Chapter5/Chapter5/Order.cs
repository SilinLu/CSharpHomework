using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5
{
    class Order
    {
        public uint Order_Num { get; set; }
        public static uint ORDER_NUM=0;
        public List<OrderDetails> OrderDetails;
        public Customer Customer { get; set; }
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return order != null && order.Order_Num == Order_Num;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
