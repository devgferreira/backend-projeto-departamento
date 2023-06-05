using backend_projeto_departamento.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_projeto_departamento.Domain.Interfaces
{
    public interface IVendedorRepository
    {
        Task<List<Vendedor>> FindAllAsync();
        Task<Vendedor> InsertAsync(Vendedor obj);
        Task<Vendedor> FindByIdAsync(int id);
        Task<Vendedor> RemoveAsync(Vendedor obj);
        Task<Vendedor> UpdateAsync(Vendedor obj);
    }
}
