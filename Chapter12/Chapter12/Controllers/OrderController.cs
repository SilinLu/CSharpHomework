using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Chapter12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {


        private readonly OrderContext _orderContext;
        public OrderController(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }


        // GET: api/<OrderController>
        [HttpGet]
        public ActionResult<List<Order>> GetOrders()
        {
            IQueryable<Order> query = from o in _orderContext.Orders select o;
            
            return query.ToList();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = 
                _orderContext.Orders
                .Where(p=>p.OrderId==id).FirstOrDefault();
            if (order == null)
            {
                return NotFound();
            }
            return order;
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult<Order> PostOrder(Order order)
        {
            try
            {
                _orderContext.Orders.Add(order);
                _orderContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return order;
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public ActionResult<Order> PutOrder(int id, Order order)
        {
            if (id != order.OrderId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                _orderContext.Entry(order).State = EntityState.Modified;
                _orderContext.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            try
            {
                var order = _orderContext.Orders.FirstOrDefault(o => o.OrderId == id);
                if (order != null)
                {
                    _orderContext.Remove(order);
                    _orderContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }
    }
}
