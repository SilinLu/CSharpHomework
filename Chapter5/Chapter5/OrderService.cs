using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Chapter5
{

    public class MyException : Exception
    {
        private int code;
        public MyException(string message,int code) : base(message)
        {
            this.code = code;
        }
        public int Code { get => code; }
    }

    public class OrderService
    {
        public List<Order> orders = new List<Order>();
        public List<Goods> goods = new List<Goods>{ 
            new Goods("apple", 5), 
            new Goods("banana", 3), 
            new Goods("peach", 3.5),
            new Goods("watermelon", 2),
            new Goods("orange", 2.5)
        };
        public bool AddOrderDetails(Order order,int quantity,int goods_Index)//添加订单明细
        {
            if (quantity <= 0 || goods_Index < 0 || goods_Index > 4)
                throw new MyException("参数错误", 4);
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
                    throw new MyException("物品重复", 0);
                
                       
            }
            else
                order.OrderDetails = new List<OrderDetails>();
            order.SumPrice += details.Sum_Cost;
            order.OrderDetails.Add(details);

            return true;
        }
        public bool AddOrder(Order order,Customer customer)//添加订单
        {
            if (customer == null||order==null)
                throw new MyException("参数错误", 4);
            order.Customer = customer;
            if (orders.Count() != 0)
                order.Order_Num = orders.Last().Order_Num++;
            else
                order.Order_Num = 0;
            

            //if (orders == null)
            //{
            //    orders = new List<Order>();
            //    orders.Add(order);
            //    return;
            //}

            var query = from o in orders
                        where o.Equals(order)
                        select o
                        ;

            if (query.Count() == 0)
            {
                orders.Add(order);
                return true;
            }
            return false;
        }
        public void DeleteOrder(uint num) //删除订单
        {
            var order = this.SearchByNum(num);
            
            orders.Remove(order);

        }

        //public void ChangeCustomer(Order order, string name)//修改订单用户
        //{

        //    if(order==null)
        //        throw new MyException("订单号不存在", 1);
        //    order.Customer.Name = name;
        //}

        //public void ChangeAddDetail(Order o, OrderDetails details)          //直接用上面的AddDetail
        //{
        //    var query = from d in o.OrderDetails
        //                where d.Equals(details)
        //                select d;
        //    if (query.Count() != 0)
        //        throw new MyException("物品重复", 0);
        //    o.OrderDetails.Add(details);

        //}
        public bool ChangeDeleteDetail(Order order, int goodIndex)//删除某个订单明细
        {

            if (goodIndex>4||goodIndex<0||order==null)
                throw new MyException("参数错误", 4);
            var query = from d in order.OrderDetails
                        where d.good.Equals(goods[goodIndex])
                        select d;
            order.OrderDetails.Remove(query.First());
            return true;
        }
        public bool ChangeNumOfGoods(Order o, int goodIndex,int num)//修改订单明细中的货物数量
        {

            if (goodIndex > 4 || goodIndex < 0 || o == null||num<=0)
                throw new MyException("参数错误", 4);

            var query = from d in o.OrderDetails
                        where d.good.Equals(goods[goodIndex])
                        select d;
            if (query.Count() == 0)
                throw new MyException("物品不存在", 2);
            query.First().Goods_Num = num;
            return true;
        }
        //-------------------------------------------------------------------
        public Order SearchByNum(uint num)
        {
            if (orders == null)
                throw new MyException("List为空", 3);
            var query = from o in orders
                        where o.Order_Num == num
                        orderby o.SumPrice
                        select o;
            if (query.FirstOrDefault() == null)
                throw new MyException("订单号不存在", 1);
            return query.FirstOrDefault();
        }
        public List<Order> SearchByCost(double price)
        {
            if (orders == null)
                throw new MyException("List为空", 3);
            var query = from o in orders
                        where o.SumPrice == price
                        orderby o.SumPrice
                        select o;
            return query.ToList<Order>();
        }
        public List<Order> SearchByCostomer(string name)
        {
            if (orders == null)
                throw new MyException("List为空", 3);
            var query = from o in orders
                        where o.Customer.Name == name
                        orderby o.SumPrice
                        select o;
            return query.ToList<Order>();
        }
        public List<Order> SearchByGoodsName(string name)
        {
            if (orders == null)
                throw new MyException("List为空", 3);
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


        public void Export() {

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using(FileStream fileStream=new FileStream("Order.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fileStream, orders);
            }

        }
        public void Import() {
            
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                using (FileStream fileStream = new FileStream("Order.xml", FileMode.Open))
                {

                    List<Order> list = (List<Order>)xmlSerializer.Deserialize(fileStream);

                    orders = list;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }


        }
    }


}
