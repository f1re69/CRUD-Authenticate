using CRUD_Authenticate.Models;
using CRUD_Authenticate.Context;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Authenticate.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        [HttpGet("{email}")]
        public ActionResult<Customer> GetCustomer(string email)
        {
            var customer = _context.Customers.Find(email);
            if (customer == null)
            {
                return NotFound();
            }
            return customer;
        }

        [HttpPost]
        public ActionResult<Customer> CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetCustomer), new { id = customer.Email }, customer);
        }

        [HttpPut("{email}")]
        public ActionResult<Customer> UpdateCustomer(string email, [FromBody] Customer customer)
        {
            var existingCustomer = _context.Customers.Find(email);
            if (existingCustomer == null)
            {
                return NotFound();
            }
            existingCustomer.FirstName = customer.FirstName;
            existingCustomer.LastName = customer.LastName;
            existingCustomer.PrivilegeID = customer.PrivilegeID;
            existingCustomer.Sex = customer.Sex;
            existingCustomer.Password = customer.Password;
            existingCustomer.ProfilePic = customer.ProfilePic;
            existingCustomer.PostalAddress = customer.PostalAddress;
            _context.SaveChanges();
            return Ok(existingCustomer);
        }

        [HttpDelete("{email}")]
        public ActionResult<Customer> DeleteCustomer(string email)
        {
            var customer = _context.Customers.Find(email);
            if(customer == null)
            {
                return NotFound();
            }
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return Ok();
        }
    }
}
