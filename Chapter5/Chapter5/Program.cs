using System;

namespace Chapter5
{
    class Program
    {
        
        static void Add()
        {

        }
        static void Main(string[] args)
        {
            string index;
            OrderService service = new OrderService();
            
            while (true)
            {
                Console.WriteLine("请选择您要进行的操作：\n（A：添加订单 D：删除订单 C:修改订单 S：查询订单）");
                index= Console.ReadLine();
                switch (index)
                {
                    case "A":
                        string end = "";
                        Order order = new Order();
                        while (end != "E")
                        {
                            Console.WriteLine("请您选择货物:");
                            for (int i = 0; i < service.goods.Count; i++)
                            {
                                Console.WriteLine($"{i}:{service.goods[i].ToString()}");
                            }
                            int num = int.Parse(Console.ReadLine());
                            Console.WriteLine("请您输入购买的数量:");
                            int quantity = int.Parse(Console.ReadLine());
                            service.AddOrderDetails(order, quantity, num);
                            Console.WriteLine("按回车继续 ，按E+回车结束---");
                            end = Console.ReadLine();
                        }
                        Console.WriteLine("请输入您的用户名:");
                        Customer c = new Customer();

                        c.Name = Console.ReadLine();
                        service.AddOrder(order, c);

                        break;
                    case "D":
                        Console.WriteLine("请您输入订单号:");

                        break;
                    case "C": break;
                    case "S": break;
                    default:break;
                }

            }
        }
    }
}
