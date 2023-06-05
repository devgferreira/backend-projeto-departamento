using backend_projeto_departamento.Domain.Interfaces;
using backend_projeto_departamento.Domain.Models;
using backend_projeto_departamento.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_projeto_departamento.Infra.Data.Repositories
{
    public class RegistroDeVendaRepository : IRegistroDeVendaRepository
    {
        private readonly ApplicationDbContext _context;
        public RegistroDeVendaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<RegistroDeVenda>> FindByDateAsync(DateTime? mindate, DateTime? maxDate)
        {
            var result = from obj in _context.RegistroDeVenda select obj;
            if (mindate.HasValue)
            {
                result = result.Where(x => x.Data >= mindate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }

            return await result.Include(X => X.Vendedor).Include(x => x.Vendedor.Departamento).OrderByDescending(x => x.Data).ToListAsync();
        }
    }
}
