using backend_projeto_departamento.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace backend_projeto_departamento.Application.DTOs
{
    public class DepartamentoDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        [JsonIgnore]
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();
    }
}
