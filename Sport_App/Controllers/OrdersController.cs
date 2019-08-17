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
    public class OrdersController : ControllerBase
    {
        public OrdersController()
        {

        }
        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetOrders([FromRoute] int id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult PostOrders()
        {
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult PutOrders([FromRoute]int id, [FromRoute] Object obj)
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteOrders([FromRoute] int id)
        {
            return Ok();
        }
    }
}