using backend_projeto_departamento.Application.DTOs;
using backend_projeto_departamento.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace backend_projeto_departamento.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {

        private readonly IDepartamentoService _departamentoService;
        public DepartamentoController(IDepartamentoService departamentoService)
        {
            _departamentoService = departamentoService;
        }

        [HttpGet(Name = "GetDepartamentos")]
        public async Task<ActionResult<List<DepartamentoDTO>>> Get()
        {
            var departamentos = await _departamentoService.FindAllAsync();
            if(departamentos == null)
            {
                return NotFound("Departamentos not found");
            }
            return Ok(departamentos);
        }
    }
}
