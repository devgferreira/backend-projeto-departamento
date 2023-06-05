using backend_projeto_departamento.Domain.Interfaces;
using backend_projeto_departamento.Domain.Models;
using backend_projeto_departamento.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace backend_projeto_departamento.Infra.Data.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ApplicationDbContext _context;
        public VendedorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Vendedor>> FindAllAsync()
        {
            var vendedores = await _context.Vendedor.ToListAsync();
            return vendedores;
        }

        public async Task<Vendedor> FindByIdAsync(int id)
        {
            var vendedor = await _context.Vendedor.FindAsync(id);
            return vendedor;
        }

        public async Task<Vendedor> InsertAsync(Vendedor obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
            return obj;
        }

        public async Task<Vendedor> RemoveAsync(Vendedor obj)
        {
            _context.Remove(obj);
            await _context.SaveChangesAsync();
            return obj;
        }

        public async Task<Vendedor> UpdateAsync(Vendedor obj)
        {
            _context.Update(obj);
            await _context.SaveChangesAsync();
            return obj;
       }
    }
}
