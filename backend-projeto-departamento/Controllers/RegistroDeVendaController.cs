using backend_projeto_departamento.Application.DTOs;
using backend_projeto_departamento.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace backend_projeto_departamento.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroDeVendaController : ControllerBase
    {

        private readonly IRegistroDeVendaService _registroDeVendaService;
        public RegistroDeVendaController(IRegistroDeVendaService registroDeVendaService)
        {
            _registroDeVendaService = registroDeVendaService;
        }

        [HttpGet]
        public async Task<ActionResult<List<RegistroDeVendaDTO>>> Get(DateTime? minDate, DateTime? maxDate)
        {
            var registros = await _registroDeVendaService.FindByDateAsync(minDate, maxDate);
            if(registros == null)
            {
                return NotFound("RegistroDeVendas not found");
            }
            return Ok(registros);
        }
    }
}
