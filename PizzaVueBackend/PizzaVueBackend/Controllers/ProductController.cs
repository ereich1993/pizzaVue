using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaVueBackend.Data;

namespace PizzaVueBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly PizzaBackendDbContext ctx;

        public ProductController(PizzaBackendDbContext ctx)
        {
            this.ctx = ctx;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] dynamic value)
        {
            var Customer = ctx.Users.FirstOrDefault();
            if (Customer != null)
            {
                return Ok(value);
            }
            else
            {
                return Ok(false);
            }

        }


        [HttpGet("GetDailyRevenue")]
        public async Task<IActionResult> GetDailyRevenue ()
        {
            var revenue = 500;
            return Ok(revenue);
        }
    }
}