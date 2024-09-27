using Backend_Jo.src.models;
using Backend_Jo.src.repositories;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Jo.src.controllers
{

    [Route("api/[Controller]")]
    [ApiController]
    public class FormController:ControllerBase
    {
        public readonly FormRepository  _formRepository;
        public FormController(FormRepository formRepository)
        {

            _formRepository=formRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Form>>> GetAll()
        {
            var resultado = await _formRepository.GetAlls();
            if (resultado == null || !resultado.Any())
            {
                return NotFound();
            }
            return Ok(resultado);
        }
        
    }
}