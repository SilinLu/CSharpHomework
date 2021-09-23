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
        public void AddOrderDetails(Order order,int quantity,int goods_Index)//添加订单明细
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
            order.SumPrice += details.Sum_Cost;
            order.OrderDetails.Add(details);


        }
        public void AddOrder(Order order,Customer customer)//添加订单
        {

            order.Customer = customer;
            order.Order_Num = Order.ORDER_NUM++;
            
            if (orders == null)
            {
                orders = new List<Order>();
                orders.Add(order);
                return;
            }

            var query = from o in orders
                        where o.Equals(order)
                        select o
                        ;

            if (query.Count()==0)
                orders.Add(order);
        }
        public void DeleteOrder(uint num) //删除订单
        {
            var order = this.SearchByNum(num);

            orders.Remove(order);

        }

        //public void ChangeCustomer(Order order, string name)//修改订单用户
        //{

        //    if(order==null)
        //        throw new MyExpection("订单号不存在", 1);
        //    order.Customer.Name = name;
        //}

        //public void ChangeAddDetail(Order o, OrderDetails details)          //直接用上面的AddDetail
        //{
        //    var query = from d in o.OrderDetails
        //                where d.Equals(details)
        //                select d;
        //    if (query.Count() != 0)
        //        throw new MyExpection("物品重复", 0);
        //    o.OrderDetails.Add(details);

        //}
        public void ChangeDeleteDetail(Order order, int goodIndex)//删除某个订单明细
        {
            

            var query = from d in order.OrderDetails
                        where d.good.Equals(goods[goodIndex])
                        select d;
            order.OrderDetails.Remove(query.First());
        }
        public void ChangeNumOfGoods(Order o, int goodIndex,int num)//修改订单明细中的货物数量
        {

            var query = from d in o.OrderDetails
                        where d.good.Equals(goods[goodIndex])
                        select d;
            if (query.Count() == 0)
                throw new MyExpection("物品不存在", 2);
            query.First().Goods_Num = num;

        }
        //-------------------------------------------------------------------
        public Order SearchByNum(uint num)
        {
            if (orders == null)
                throw new MyExpection("List为空", 3);
            var query = from o in orders
                        where o.Order_Num == num
                        orderby o.SumPrice
                        select o;
            if (query.FirstOrDefault() == null)
                throw new MyExpection("订单号不存在", 1);
            return query.FirstOrDefault();
        }
        public List<Order> SearchByCost(double price)
        {
            if (orders == null)
                throw new MyExpection("List为空", 3);
            var query = from o in orders
                        where o.SumPrice == price
                        orderby o.SumPrice
                        select o;
            return query.ToList<Order>();
        }
        public List<Order> SearchByCostomer(string name)
        {
            if (orders == null)
                throw new MyExpection("List为空", 3);
            var query = from o in orders
                        where o.Customer.Name == name
                        orderby o.SumPrice
                        select o;
            return query.ToList<Order>();
        }
        public List<Order> SearchByGoodsName(string name)
        {
            if (orders == null)
                throw new MyExpection("List为空", 3);
            //foreach (Order o in orders)
            //{
            //    var query = from d in o.OrderDetails
            //                where d.good.Name == name
            //                select d;
            //    if(query.Count()!=0)

            //}
            var query = orders.Where( s=>s.OrderDetails.Where(a => a.good.Name == name).Count()!=0);
            return query.ToList<Order>();
        }

    }


}
