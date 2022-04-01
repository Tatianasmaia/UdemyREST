using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstRestProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstRestProject.Model;

namespace FirstRestProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {

        private readonly ILogger<PersonController> _logger;
        private IPersonService _personService;

        public PersonController(ILogger<PersonController> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
        }

        //Find All
        [HttpGet]
        public IActionResult Get()
        {


            return Ok(_personService.FindAll());
        }
        
        //Find by id
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personService.FindById(id);
            if (person == null) return NotFound();

            return Ok(person);
        }

        //Find by id
        //O que está no parâmetro vai pegar no JSON que vier no corpo do request e converter num objeto Person
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            if (person == null) return BadRequest();

            return Ok(_personService.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            if (person == null) return BadRequest();

            return Ok(_personService.Update(person));
        }

        //Delete
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
           _personService.Delete(id);
            return NoContent();
        }


    }
}
