using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_projeto_departamento.Domain.Models
{
    public class Departamento : Entity
    {
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento()
        {
        }
        public Departamento(string nome)
        {
            Nome = nome;
        }

        public Departamento(int id, string name)
        {
            Id = id;
            Nome = name;
        }

    }
}
