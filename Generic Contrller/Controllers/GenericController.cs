using Generic_Contrller.IService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Generic_Contrller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : Controller where T:class
    {
        private readonly IGenericService<T> _genericService;
        public GenericController(IGenericService<T> genericService)
        {
            _genericService = genericService;
        }
        // GET: api/<GenericController>
        [HttpGet]
        public List<T> Get()
        {
            return _genericService.GetAll();
        }

        // GET api/<GenericController>/5
        [HttpGet("{id}")]
        public T Get(int id)
        {
            return _genericService.GetById(id);
        }

        // POST api/<GenericController>
        [HttpPost]
        public List<T> Post([FromBody] T value)
        {
          return  _genericService.Insert(value);
        }

        // PUT api/<GenericController>/5


        // DELETE api/<GenericController>/5
        [HttpDelete("{id}")]
        public List<T> Delete(int id)
        {
            return _genericService.Delete(id);
        }
    }
}
