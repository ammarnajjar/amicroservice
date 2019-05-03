using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using amicroservice.Models;
using amicroservice.Services;
using Microsoft.EntityFrameworkCore;

namespace amicroservice.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {

        private readonly PizzaContext _pizzaContext;

        public PizzaController(PizzaContext context)
        {
            _pizzaContext = context;
            if (_pizzaContext != null)
            {
                if (_pizzaContext.PizzaOrders.Count() == 0)
                {
                    _pizzaContext.PizzaOrders.Add(Pizza.Default());
                    _pizzaContext.SaveChanges();
                }
            }
        }

        // GET api/pizza
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pizza>>> Get()
        {
            return await _pizzaContext.PizzaOrders.ToListAsync();
        }

        // GET api/pizza/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pizza>> GetPizza(int id)
        {
            var pizzaOrder = await _pizzaContext.PizzaOrders.FindAsync(id);
            if (pizzaOrder == null)
            {
                return NotFound();
            }
            return pizzaOrder;
        }

        // POST api/pizza
        [HttpPost]
        public async Task<ActionResult<Pizza>> PostPizzaOrder(Pizza pizza)
        {
            _pizzaContext.PizzaOrders.Add(pizza);
            await _pizzaContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPizza), new { Id = pizza.Id }, pizza);
        }

        // PUT api/pizza/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPizzaOrder(int id, Pizza pizza)
        {
            if (id != pizza.Id)
            {
                return BadRequest();
            }
            _pizzaContext.Entry(pizza).State = EntityState.Modified;
            await _pizzaContext.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/pizza/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePizzaOrder(int id)
        {
            var pizza = await _pizzaContext.PizzaOrders.FindAsync(id);
            if (pizza == null)
            {
                return NotFound();
            }
            _pizzaContext.PizzaOrders.Remove(pizza);
            await _pizzaContext.SaveChangesAsync();

            return NoContent();
        }
    }
}
