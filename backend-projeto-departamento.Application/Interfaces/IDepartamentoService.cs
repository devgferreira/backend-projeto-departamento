using backend_projeto_departamento.Application.DTOs;


namespace backend_projeto_departamento.Application.Interface
{
    public interface IDepartamentoService
    {
        Task<List<DepartamentoDTO>> FindAllAsync();
    }
}
