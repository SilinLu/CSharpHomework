using System;
using System.Collections.Generic;
namespace Chapter5
{
    class Program
    {
        static OrderService service = new OrderService();

        static void PrintOrder()
        {
            if (service.orders != null)
            {
                foreach (Order o in service.orders)
                {
                    foreach (OrderDetails d in o.OrderDetails)
                    {
                        Console.WriteLine(d.ToString());
                    }
                    Console.WriteLine($"----------订单号：{o.Order_Num}---用户：{o.Customer.Name}-----------");
                }
            }

            
        }


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
                Console.WriteLine("按Enter继续 ，输入E并按Enter结束---");
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

        static void Change()
        {

            try
            {
                uint num; Order order; string index; int goodIndex = 0;

                
                while (true)
                {
                    Console.WriteLine("请您输入订单号:");
                    num = uint.Parse(Console.ReadLine());
                    order = service.SearchByNum(num);
                    Console.WriteLine("请选择您要进行的操作：\n（A：添加货物 D：删除某个订单明细 N：修改订单明细中的货物数量 E:退出修改订单）");
                    index = Console.ReadLine();
                    switch (index)
                    {
                        case "A":
                             
                            AddDetail(order);
                            break;
                        case "D":
                            
                            Console.WriteLine("请输入您需要删除的货物序号：0.苹果 1.香蕉 2.桃子 3.西瓜 4.橙子");
                            goodIndex = int.Parse(Console.ReadLine());
                            service.ChangeDeleteDetail(order, goodIndex);
                            break;
                        case "N":

                            Console.WriteLine("请输入您需要修改数量的货物序号：0.苹果 1.香蕉 2.桃子 3.西瓜 4.橙子");
                            goodIndex = int.Parse(Console.ReadLine());
                            Console.WriteLine("请您输入购买的数量:");
                            int quantity = int.Parse(Console.ReadLine());
                            service.ChangeNumOfGoods(order, goodIndex, quantity);
                            break;
                        case "E": return;
                        default: break;
                    }
                }
            }
            catch(MyExpection e)
            {
                Console.WriteLine($"修改订单失败，错误代码：{e.Code}");
            }


        }

        static void Search()
        {
            try
            {

                List<Order> list;
                Console.WriteLine("请选择您要进行的操作：\n（A：按订单号查询 B：按金额查询 C:按用户名查询 D：按商品名称查询）");
                string index = Console.ReadLine();
                switch (index)
                {
                    case "A":
                        Console.WriteLine("请输入订单号：");
                        uint num = uint.Parse(Console.ReadLine());
                        Order o= service.SearchByNum(num);
                        if (o == null)
                        {
                            Console.WriteLine("没有查询到符合条件的订单");
                            return;
                        }
                        Console.WriteLine($"结果如下：");
                        Console.WriteLine(o.ToString());
                        break;
                    case "B":
                        Console.WriteLine("请输入金额：");
                        double cost = double.Parse(Console.ReadLine());
                        list = service.SearchByCost(cost);
                        if (list.Count == 0)
                        {
                            Console.WriteLine("没有查询到符合条件的订单");
                            return;
                        }
                        Console.WriteLine($"结果如下：");
                        foreach(Order order in list)
                        {
                            Console.WriteLine(order.ToString());
                        }
                        break;
                    case "C":
                        Console.WriteLine("请输入用户名：");
                        string name = Console.ReadLine();
                        list = service.SearchByCostomer(name);
                        if (list.Count == 0)
                        {
                            Console.WriteLine("没有查询到符合条件的订单");
                            return;
                        }
                        Console.WriteLine($"结果如下：");
                        foreach (Order order in list)
                        {
                            Console.WriteLine(order.ToString());
                        }
                        break;
                    case "D":
                        Console.WriteLine("请输入商品名：");
                        string goodName = Console.ReadLine();
                        list = service.SearchByCostomer(goodName);
                        if (list.Count == 0)
                        {
                            Console.WriteLine("没有查询到符合条件的订单");
                            return;
                        }
                        Console.WriteLine($"结果如下：");
                        foreach (Order order in list)
                        {
                            Console.WriteLine(order.ToString());
                        }
                        break;
                        
                    default: break;
                }

                
            }
            catch(MyExpection e) {
                Console.WriteLine($"查找订单失败，错误代码：{e.Code}");
            }

        }
        static void Main(string[] args)
        {
            string index;
            service.Import();

            while (true)
            {
                PrintOrder();
                Console.WriteLine("请选择您要进行的操作：\n（A：添加订单 D：删除订单 C:修改订单 S：查询订单）");
                index= Console.ReadLine();
                switch (index)
                {
                    case "A":
                        Add();
                        service.Export();
                        break;
                    case "D":
                        Delete();
                        service.Export();
                        break;
                    case "C":
                        Change();
                        service.Export();
                        break;
                    case "S":
                        Search();
                        break;
                    default:break;
                }

            }
        }
    }
}
