using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sport_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerController()
        {

        }
        [HttpGet]
        public IActionResult GetCustomer()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetCustomer([FromRoute] int id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult PostCustomer()
        {
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult PutCustomer([FromRoute]int id, [FromRoute] Object obj)
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer([FromRoute] int id)
        {
           return Ok();
        }
    }
}