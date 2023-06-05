

using backend_projeto_departamento.Application.DTOs;

namespace backend_projeto_departamento.Application.Interface
{
    public interface IRegistroDeVendaService
    {
        Task<List<RegistroDeVendaDTO>> FindByDateAsync(DateTime? mindate, DateTime? maxDate);
    }
}
