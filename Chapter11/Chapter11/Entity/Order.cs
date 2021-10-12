using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace Chapter11
{
    [Serializable]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
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
            return order != null && order.OrderId == OrderId;
        }

        public override string ToString()
        {
            string arr=$"订单号:{OrderId},";
            foreach(OrderDetail d in OrderDetails)
            {
                arr += d.ToString();
            }
            return arr + $"总金额：{SumPrice}";
            
        }

        public override int GetHashCode()
        {
            int hashCode = 625995856;
            hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetail>>.Default.GetHashCode(OrderDetails);
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(Customer);
            return hashCode;
        }
    }


    class OrderConfig : EntityTypeConfiguration<Order>
    {
        public OrderConfig()
        {
            this.ToTable("Order");
        }
    }
}
