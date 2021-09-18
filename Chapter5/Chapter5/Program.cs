using System;

namespace Chapter5
{
    class Program
    {
        static OrderService service = new OrderService();

        static void AddDetail(Order order)
        {
            Console.WriteLine("请您选择货物:");
            for (int i = 0; i < service.goods.Count; i++)
            {
                Console.WriteLine($"{i}:{service.goods[i].ToString()}");
            }
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("请您输入购买的数量:");
            int quantity = int.Parse(Console.ReadLine());
            try
            {
                
                service.AddOrderDetails(order, quantity, num);
            }
            catch (MyExpection e)
            {
                Console.WriteLine($"添加商品失败，错误代码：{e.Code}");
            }
        }
        static void Add()
        {
            string end = "";
            Order order = new Order();
            while (end != "E")
            {
                AddDetail(order);
                Console.WriteLine("按回车继续 ，按E+回车结束---");
                end = Console.ReadLine();
            }
            Console.WriteLine("请输入您的用户名:");
            Customer c = new Customer();
            c.Name = Console.ReadLine();
            service.AddOrder(order, c);
            Console.WriteLine($"下订单成功，订单号为{order.Order_Num}");
        }

        static void Delete()
        {
            Console.WriteLine("请您输入订单号:");
            uint num = uint.Parse(Console.ReadLine());
            try {
                service.DeleteOrder(num);
            }
            catch(MyExpection e)
            {
                Console.WriteLine($"删除订单失败，错误代码：{e.Code}");
            }

            
        }
        static void Main(string[] args)
        {
            string index;

            
            while (true)
            {
                Console.WriteLine("请选择您要进行的操作：\n（A：添加订单 D：删除订单 C:修改订单 S：查询订单）");
                index= Console.ReadLine();
                switch (index)
                {
                    case "A":
                        Add();
                        break;
                    case "D":
                        Delete();
                        break;
                    case "C": break;
                    case "S": break;
                    default:break;
                }

            }
        }
    }
}
