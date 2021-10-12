using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Chapter5
{
    [Serializable]

    [Table("Orders")]
    public class Order
    {
        [Key]
        public int Order_Num { get; set; }
        //public static uint ORDER_NUM=0;
        public List<OrderDetail> OrderDetails;
        
        public double SumPrice
        {
            get
            {
                double sum=0;
                foreach(OrderDetail orderDetails in OrderDetails)
                {
                    sum += orderDetails.Sum_Cost;
                }
                return sum;
            }
        }
        public Customer Customer { get; set; }
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return order != null && order.Order_Num == Order_Num;
        }

        public override string ToString()
        {
            string arr=$"订单号:{Order_Num},";
            foreach(OrderDetail d in OrderDetails)
            {
                arr += d.ToString();
            }
            return arr + $"总金额：{SumPrice}";
            
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Order_Num, OrderDetails, Customer);
        }
    }
}
