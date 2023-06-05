using backend_projeto_departamento.Application.DTOs;

namespace backend_projeto_departamento.Application.Interface
{
    public interface IVendedorService
    {
        Task<List<VendedorDTO>> FindAllAsync();
        Task InsertAsync(VendedorDTO obj);
        Task<VendedorDTO> FindByIdAsync(int id);
        Task RemoveAsync(int id);
        Task UpdateAsync(VendedorDTO obj);
    }
}
