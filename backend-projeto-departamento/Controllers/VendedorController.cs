using backend_projeto_departamento.Application.DTOs;
using backend_projeto_departamento.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace backend_projeto_departamento.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {

        private readonly IVendedorService _vendedorService;
        public VendedorController(IVendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        [HttpGet]
        public async Task<ActionResult<List<VendedorDTO>>> Get()
        {
            var vendedores = await _vendedorService.FindAllAsync();
            if(vendedores == null)
            {
                return NotFound("Vendedores not found");
            }
            return Ok(vendedores);
        }

        [HttpGet("{id:int}", Name = "GetVendedor")]
        public async Task<ActionResult<VendedorDTO>> Get(int id)
        {
            var vendedor = await _vendedorService.FindByIdAsync(id);
            if (vendedor == null)
            {
                return NotFound("Vendedores not found");
            }
            return Ok(vendedor);
        }
        [HttpPost(Name = "Adicionar Vendedor")]
        public async Task<ActionResult> Post([FromBody] VendedorDTO vendedorDTO)
        {
            if (_vendedorService == null)
                return BadRequest("Invalid Data");

            await _vendedorService.InsertAsync(vendedorDTO);

            return new CreatedAtRouteResult("GetVendedor", new { id = vendedorDTO.Id },
                vendedorDTO);
        }

        [HttpPut(Name = "Atualizar Vendedor")]
        public async Task<ActionResult> Put(int id, [FromBody] VendedorDTO vendedorDTO)
        {
            if (id != vendedorDTO.Id)
                return BadRequest();

            if (vendedorDTO == null)
                return BadRequest();

            await _vendedorService.UpdateAsync(vendedorDTO);

            return Ok(vendedorDTO);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<VendedorDTO>> Delete(int id)
        {
            var category = await _vendedorService.FindByIdAsync(id);
            if (category == null)
            {
                return NotFound("Vendedor not found");
            }

            await _vendedorService.RemoveAsync(id);

            return Ok(category);

        }
    }
}
