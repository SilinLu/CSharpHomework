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
        public void AddOrderDetailsTest1()
        {
            Order order = new Order();
            
            Assert.IsTrue(service.AddOrderDetails(order, 1, 2));
        }
        [TestMethod()]
        [ExpectedException(typeof(MyException), "Test Exception")]
        public void AddOrderDetailsTest2()
        {
            Order order = new Order();

            service.AddOrderDetails(order, -1, 2);


        }

        [TestMethod()]
        [ExpectedException(typeof(MyException), "Test Exception")]
        public void AddOrderDetailsTest3()
        {
            Order order = new Order();
            service.AddOrderDetails(order, 1, 6);

        }

        [TestMethod()]
        public void AddOrderTest1()
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
        public void DeleteOrderTest2()
        {
            


            Order order = new Order();
            order.Order_Num = 0;
            service.orders.Add(order);
            int count = service.orders.Count();
            service.DeleteOrder(0);
            Assert.AreEqual(count - 1, service.orders.Count());
        }

        [TestMethod()]
        public void ChangeDeleteDetailTest1()
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
            service.ChangeDeleteDetail(o, 5);
            
        }

        [TestMethod()]
        public void ChangeNumOfGoodsTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SearchByNumTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SearchByCostTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SearchByCostomerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SearchByGoodsNameTest()
        {
            Assert.Fail();
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

