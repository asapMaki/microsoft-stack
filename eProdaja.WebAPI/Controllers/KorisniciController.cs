using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Model.Requests;
using eProdaja.WebAPI.Databases;
using eProdaja.WebAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eProdaja.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class KorisniciController : Controller
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }
        // GET: api/values
        [HttpGet]
        public ActionResult<List<Korisnici>> Get()
        {
            return Ok(_service.Get());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        //POST api/values
        [HttpPost]
        public ActionResult<Korisnici> Post(KorisniciInsertRequest request)
        {
            return Ok(_service.Insert(request));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
