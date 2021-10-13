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
    public class CustomerController : ControllerBase
    {

        private readonly OrderContext _orderContext;
        public CustomerController(OrderContext orderContext)
        {
            _orderContext = orderContext;
        }


        // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult<List<Customer>> GetCustomers()
        {
            IQueryable<Customer> query = from c in _orderContext.Customers select c;

            return query.ToList();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomer(int id)
        {
            var customer =
                _orderContext.Customers
                .Where(p => p.CustomerId == id).FirstOrDefault();
            if (customer == null)
            {
                return NotFound();
            }
            return customer;
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult<Customer> PostCustomer(Customer customer)
        {
            try
            {
                _orderContext.Customers.Add(customer);
                _orderContext.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return customer;
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult<Customer> PutCustomer(int id, Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                _orderContext.Entry(customer).State = EntityState.Modified;
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

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            try
            {
                var customer = _orderContext.Customers.FirstOrDefault(c => c.CustomerId == id);
                if (customer != null)
                {
                    _orderContext.Remove(customer);
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
