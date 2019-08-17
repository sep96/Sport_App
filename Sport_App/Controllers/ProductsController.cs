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
    public class ProductsController : ControllerBase
    {
        public ProductsController()
        {

        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetProducts([FromRoute] int id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult PostProducts()
        {
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult PutProducts([FromRoute]int id, [FromRoute] Object obj)
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProducts([FromRoute] int id)
        {
            return Ok();
        }
    }
}