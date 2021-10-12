using Chapter11.DBConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
{
    class Program
    {
        static void Main(string[] args)
        {


            using (OrderContext ctx = new OrderContext())//增
            {
                Order order = new Order();
                order.Customer = new Customer() { Name = "lily" };


                ctx.Orders.Add(order);
                ctx.SaveChanges();

                OrderDetail orderDetail = new OrderDetail();
                orderDetail.good = new Goods() { Name = "APPLE", Unit_Price = 5 };
                orderDetail.Goods_Num = 1;
                orderDetail.OrderId = order.OrderId;
                orderDetail.Order = order;
                ctx.OrderDetails.Add(orderDetail);
                ctx.SaveChanges();
                order.OrderDetails = new List<OrderDetail>() { orderDetail };
            }
            using(OrderContext ctx = new OrderContext())//删除+查
            {
                var order = ctx.Orders.FirstOrDefault(p => p.OrderId == 6);
                if (order!=null)
                {
                    ctx.Orders.Remove(order);
                    ctx.SaveChanges();
                }

            }

            using (OrderContext ctx = new OrderContext())//改+查
            {
                var order = ctx.Orders.FirstOrDefault(p => p.OrderId == 8);
                if (order != null)
                {
                    order.Customer= new Customer() { Name="me"};
                    ctx.SaveChanges();
                }

            }

        }
    }
}
