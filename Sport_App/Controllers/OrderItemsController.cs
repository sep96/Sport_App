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
    public class OrderItemsController : ControllerBase
    {
        public OrderItemsController()
        {

        }
        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct([FromRoute] int id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult PostProduct()
        {
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult PutProduct([FromRoute]int id, [FromRoute] Object obj)
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct([FromRoute] int id)
        {
            return Ok();
        }
    }
}