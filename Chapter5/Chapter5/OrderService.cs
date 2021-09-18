using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter5
{

    class MyExpection : Exception
    {
        private int code;
        public MyExpection(string message,int code) : base(message)
        {
            this.code = code;
        }
        public int Code { get => code; }
    }

    class OrderService
    {
        public List<Order> orders;
        public List<Goods> goods = new List<Goods>{ 
            new Goods("apple", 5), 
            new Goods("banana", 3), 
            new Goods("peach", 3.5),
            new Goods("watermelon", 2),
            new Goods("orange", 2.5)
        };
        public void AddOrderDetails(Order order,int quantity,int goods_Index)
        {
            OrderDetails details = new OrderDetails();
            details.good = goods[goods_Index];
            details.Goods_Num = quantity;
            details.Sum_Cost = quantity * details.good.Unit_Price;
            if (order.OrderDetails != null)
            {
                var query = from o in order.OrderDetails
                            where o.Equals(details)
                            select o;

                if (query.Count()!=0)
                {
                    throw new MyExpection("物品重复", 0);
                }
                       
            }
            else
                order.OrderDetails = new List<OrderDetails>();

            order.OrderDetails.Add(details);


        }
        public void AddOrder(Order order,Customer customer)
        {

            order.Customer = customer;
            order.Order_Num = Order.ORDER_NUM++;
            if (orders == null)
            {
                orders.Add(order);
                return;
            }

            var query = from o in orders
                        where o.Equals(order)
                        select o
                        ;

            if (query == null)
                orders.Add(order);
        }
        public void DeleteOrder(uint num) 
        {
            if (orders != null)
            {
                var query = from o in orders
                            where o.Order_Num == num
                            select o;
                orders.Remove(query as Order);
            }

            throw new MyExpection("订单号不存在，删除失败",1);

        }
    }
}
