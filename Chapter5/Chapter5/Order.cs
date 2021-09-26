using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter5
{
    [Serializable]
    public class Order
    {
        public uint Order_Num { get; set; }
        //public static uint ORDER_NUM=0;
        public List<OrderDetails> OrderDetails;
        public double SumPrice=0;
        public Customer Customer { get; set; }
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return order != null && order.Order_Num == Order_Num;
        }

        public override string ToString()
        {
            string arr=$"订单号:{Order_Num},";
            foreach(OrderDetails d in OrderDetails)
            {
                arr += d.ToString();
            }
            return arr + $"总金额：{SumPrice}";
            
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
