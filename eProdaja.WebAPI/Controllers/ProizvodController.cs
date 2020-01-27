 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eProdaja.Model;
using eProdaja.WebAPI.Controllers.Services;

namespace eProdaja.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProizvodController : ControllerBase
    {
        private readonly IProizvodService _service;
        public ProizvodController(IProizvodService service)
        {
            _service = service;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IList<Proizvod>> Get()
        {
            var list = _service.Get();

            return Ok(list);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public ActionResult<Proizvod> Post([FromBody] Proizvod p)
        {
            return Ok(p);
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
