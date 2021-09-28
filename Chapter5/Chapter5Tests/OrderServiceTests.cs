using Chapter5;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        public OrderService service = new OrderService();
        [TestMethod()]
        public void AddOrderDetailsTest1()//正常输入的用例
        {
            Order order = new Order();
            
            Assert.IsTrue(service.AddOrderDetails(order, 1, 2));
        }
        [TestMethod()]
        [ExpectedException(typeof(MyException), "Test Exception")]
        public void AddOrderDetailsTest2()
        {
            Order order = new Order();

            service.AddOrderDetails(order, -1, 2);//数量为负数


        }

        [TestMethod()]
        [ExpectedException(typeof(MyException), "Test Exception")]
        public void AddOrderDetailsTest3()
        {
            Order order = new Order();
            service.AddOrderDetails(order, 1, 6);//good index超出范围

        }

        [TestMethod()]
        public void AddOrderTest1()//正常输入的用例
        {
            Order order = new Order();
            Customer c = new Customer();

            
            Assert.IsTrue(service.AddOrder(order, c));
        }

        [TestMethod()]
        [ExpectedException(typeof(MyException), "Test Exception")]
        public void AddOrderTest2()
        {
            Order order = new Order();
            Customer c=null;

            service.AddOrder(order, c);
        }

        [TestMethod()]
        [ExpectedException(typeof(MyException), "Test Exception")]
        public void AddOrderTest3()
        {
            Order order =null;
            Customer c = new Customer();
            service.AddOrder(order, c);
        }
        [TestMethod()]
        [ExpectedException(typeof(MyException), "Test Exception")]
        public void DeleteOrderTest1()
        {
            int count = service.orders.Count();

            service.DeleteOrder(100);//不存在的订单号
        }

        [TestMethod()]
        public void DeleteOrderTest2()//正常输入的用例
        {

            Order order = new Order();
            order.Order_Num = 0;
            service.orders.Add(order);
            int count = service.orders.Count();
            service.DeleteOrder(0);
            Assert.AreEqual(count - 1, service.orders.Count());
        }

        [TestMethod()]
        public void ChangeDeleteDetailTest1()//正常输入的用例
        {
            Order o = new Order();
            o.Order_Num = 0;
            o.Customer = new Customer();
            o.Customer.Name = "cc";
            o.OrderDetails = new List<OrderDetails>();
            OrderDetails Details = new OrderDetails();
            Details.good = service.goods[1];
            Details.Goods_Num = 1;
            Details.Sum_Cost = Details.good.Unit_Price;

            o.OrderDetails.Add(Details);
            service.ChangeDeleteDetail(o, 1);
            Assert.AreEqual(0, o.OrderDetails.Count());
        }

        [TestMethod()]
        [ExpectedException(typeof(MyException), "Test Exception")]
        public void ChangeDeleteDetailTest2()
        {
            Order o = new Order();
            o.Order_Num = 0;
            o.Customer = new Customer();
            o.Customer.Name = "cc";
            o.OrderDetails = new List<OrderDetails>();
            OrderDetails Details = new OrderDetails();
            Details.good = service.goods[1];
            Details.Goods_Num = 1;
            Details.Sum_Cost = Details.good.Unit_Price;

            o.OrderDetails.Add(Details);
            service.ChangeDeleteDetail(o, 5);//good index超出范围

        }

        [TestMethod()]
        [ExpectedException(typeof(MyException), "Test Exception")]
        public void ChangeNumOfGoodsTest1()
        {
            Order o = new Order();

            service.ChangeNumOfGoods(o, 5, 1);//good index超出范围
        }

        [TestMethod()]
        [ExpectedException(typeof(MyException), "Test Exception")]
        public void ChangeNumOfGoodsTest2()
        {
            Order o = new Order();

            service.ChangeNumOfGoods(o, 2, -1);//货物数量为负数
        }

        [TestMethod()]
        public void ChangeNumOfGoodsTest3()//正常输入的用例
        {
            Order o = new Order();
            o.Order_Num = 0;
            o.Customer = new Customer();
            o.Customer.Name = "cc";
            o.OrderDetails = new List<OrderDetails>();
            OrderDetails Details = new OrderDetails();
            Details.good = service.goods[2];
            Details.Goods_Num = 4;
            Details.Sum_Cost = Details.good.Unit_Price;

            o.OrderDetails.Add(Details);
            service.ChangeNumOfGoods(o, 2, 1);
            Assert.AreEqual(o.OrderDetails[0].Goods_Num, 1);
        }

        [TestMethod()]
        public void SearchByNumTest1()//正常输入的用例
        {
            Order o = new Order();
            o.Order_Num = 1000;
            service.orders.Add(o);
            Assert.AreEqual(o, service.SearchByNum(1000));
        }

        [TestMethod()]
        [ExpectedException(typeof(MyException), "Test Exception")]
        public void SearchByNumTest2()//不存在的订单号
        {
            Order o = new Order();
            o.Order_Num = 1000;
            service.orders.Add(o);
            service.SearchByNum(10);

        }

        [TestMethod()]
        public void SearchByCostTest1()//正常输入的用例
        {
            Order o = new Order();
            o.SumPrice = 20;
            service.orders.Add(o);
            var list = service.SearchByCost(20);
            foreach(Order order in list)
            {
                Assert.AreEqual(o.SumPrice, order.SumPrice);
            }
        }

        [TestMethod()]
        public void SearchByCostTest2()//找不到订单
        {
            Order o = new Order();
            o.SumPrice = 20;
            service.orders.Add(o);
            var list = service.SearchByCost(200);
            Assert.AreEqual(0, list.Count());
        }

        [TestMethod()]
        public void SearchByCostomerTest1()//正常输入的用例
        {
            Order o = new Order();
            o.Customer = new Customer();
            o.Customer.Name = "cc";
            service.orders.Add(o);
            var list = service.SearchByCostomer("cc");
            foreach (Order order in list)
            {
                Assert.AreEqual(o.Customer.Name, order.Customer.Name);
            }
        }

        [TestMethod()]
        public void SearchByCostomerTest2()//找不到订单
        {
            Order o = new Order();
            o.Customer = new Customer();
            o.Customer.Name = "cc";
            service.orders.Add(o);
            var list = service.SearchByCostomer("a");
            Assert.AreEqual(0, list.Count());
        }

        [TestMethod()]
        public void SearchByGoodsNameTest()//正确的用例
        {
            Order o = new Order();

            o.Order_Num = 0;
            o.Customer = new Customer();
            o.Customer.Name = "cc";
            o.OrderDetails = new List<OrderDetails>();
            OrderDetails Details = new OrderDetails();
            Details.good = service.goods[2];
            Details.Goods_Num = 4;
            Details.Sum_Cost = Details.good.Unit_Price;

            o.OrderDetails.Add(Details);
            var list = service.SearchByGoodsName("peach");
            Assert.AreEqual(o, list.First());
        }
        [TestMethod()]
        public void SearchByGoodsNameTest2()//输入货物不匹配
        {
            Order o = new Order();

            o.Order_Num = 0;
            o.Customer = new Customer();
            o.Customer.Name = "cc";
            o.OrderDetails = new List<OrderDetails>();
            OrderDetails Details = new OrderDetails();
            Details.good = service.goods[2];
            Details.Goods_Num = 4;
            Details.Sum_Cost = Details.good.Unit_Price;

            o.OrderDetails.Add(Details);
            var list = service.SearchByGoodsName("apple");
            Assert.AreEqual(0, list.Count());
        }

        [TestMethod()]
        public void ExportTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ImportTest()
        {
            Assert.Fail();
        }
    }
}

