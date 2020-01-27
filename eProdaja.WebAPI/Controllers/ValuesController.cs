using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eProdaja.Model;

namespace eProdaja.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class ProizvodController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Proizvod>> Get()
        {
			var list = new List<Proizvod>()
			{
				new Proizvod() {
					ProizvodID = 1,
					Naziv = "Laptop"
				},
				new Proizvod() {
					ProizvodID = 2,
					Naziv = "Monitor"
				}
			};
            return list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
