using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaVueBackend.Data;
using PizzaVueBackend.Dtos;
using PizzaVueBackend.Models;

namespace PizzaVueBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly PizzaBackendDbContext ctx;

        public UsersController(PizzaBackendDbContext ctx)
        {
            this.ctx = ctx;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] LoginDto value)
        {
            
            var Customer = ctx.Users.FirstOrDefault(e => e.UserName == value.username && e.Password == value.password);
            if (Customer!=null)
            {
                return Ok(value);
            }
            else
            {
                return Ok(false);
            }
            

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
