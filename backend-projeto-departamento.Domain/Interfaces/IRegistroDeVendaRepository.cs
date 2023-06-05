using backend_projeto_departamento.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_projeto_departamento.Domain.Interfaces
{
    public interface IRegistroDeVendaRepository
    {
        Task<List<RegistroDeVenda>> FindByDateAsync(DateTime? mindate, DateTime? maxDate);
    }
}
