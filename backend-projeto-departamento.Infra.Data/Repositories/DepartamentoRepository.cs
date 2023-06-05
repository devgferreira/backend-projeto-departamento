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
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private readonly ApplicationDbContext _context;
        public DepartamentoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Departamento>> FindAllAsync()
        {
            var departamentos = await _context.Departamento.OrderBy(d => d.Nome).ToListAsync();
            return departamentos;
        }
    }
}
