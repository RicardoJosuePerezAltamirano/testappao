using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlwaysOn.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DBcontextAO dBcontext;

        public ProductsController(DBcontextAO dBcontext)
        {
            this.dBcontext = dBcontext;
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<IEnumerable<Productos>> Get()
        {
            return await dBcontext.Productos.ToListAsync();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] Productos value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Productos value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(Productos id)
        {
        }
    }
}
