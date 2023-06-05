using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_projeto_departamento.Domain.Models.Enums
{
    public enum StatusDaVenda : int
    {
        Pendente = 0,
        Processado = 1,
        Cancelado = 2
    }
}
