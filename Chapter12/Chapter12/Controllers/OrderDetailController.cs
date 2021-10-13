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
    public class OrderDetailController : ControllerBase
    {

        private readonly OrderContext _orderContext;
        public OrderDetailController(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }


        // GET: api/<OrderDetailController>
        [HttpGet]
        public ActionResult<List<OrderDetail>> GetOrderDetails()
        {
            IQueryable<OrderDetail> query = from o in _orderContext.OrderDetails select o;

            return query.ToList();
        }

        // GET api/<OrderDetailController>/5
        [HttpGet("{id}")]
        public ActionResult<OrderDetail> GetOrderDetail(int id)
        {
            var orderdetail =
                _orderContext.OrderDetails
                .Where(p => p.OrderDetailId == id).FirstOrDefault();
            if (orderdetail == null)
            {
                return NotFound();
            }
            return orderdetail;
        }

        // POST api/<OrderDetailController>
        [HttpPost]
        public ActionResult<OrderDetail> PostOrderDetail(OrderDetail orderdetail)
        {
            try
            {
                _orderContext.OrderDetails.Add(orderdetail);
                _orderContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return orderdetail;
        }

        // PUT api/<OrderDetailController>/5
        [HttpPut("{id}")]
        public ActionResult<OrderDetail> PutOrderDetail(int id, OrderDetail orderdetail)
        {
            if (id != orderdetail.OrderDetailId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                _orderContext.Entry(orderdetail).State = EntityState.Modified;
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

        // DELETE api/<OrderDetailController>/5
        [HttpDelete("{id}")]
        public ActionResult DeleteOrderDetail(int id)
        {
            try
            {
                var orderdetail = _orderContext.OrderDetails.FirstOrDefault(o => o.OrderDetailId == id);
                if (orderdetail != null)
                {
                    _orderContext.Remove(orderdetail);
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
