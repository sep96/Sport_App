using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sport_App.Models;

namespace Sport_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesPersonController : ControllerBase
    {
        private readonly H_Plus_SportsContext _context;
        public SalesPersonController(H_Plus_SportsContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetSales()
        {
            return new ObjectResult(_context.Salesperson);
        }
        [HttpGet("{id}", Name = "GetSales")]
        public async Task<IActionResult> GetSales([FromRoute] int id)
        {
            var sales = await _context.Salesperson.SingleOrDefaultAsync(m=>m.SalespersonId.Equals(id));
            return Ok(sales);
        }
        [HttpPost]
        public async Task<IActionResult> PostSales([FromRoute]Salesperson sales)
        {
            _context.Salesperson.Add(sales);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetSales",new { id = sales.SalespersonId },sales);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSales([FromRoute]int id, [FromRoute] Salesperson sales)
        {
            _context.Entry(sales).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(sales);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSales([FromRoute] int id)
        {
            var sale = await _context.Salesperson.SingleOrDefaultAsync(m=>m.SalespersonId.Equals(id));
            _context.Salesperson.Remove(sale);
            await _context.SaveChangesAsync();
            return Ok(sale );
        }
    }
}