using backend_projeto_departamento.Domain.Models.Enums;
using backend_projeto_departamento.Domain.Models;
using System.Text.Json.Serialization;
using System.ComponentModel;

namespace backend_projeto_departamento.Application.DTOs
{
    public class RegistroDeVendaDTO
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantia { get; set; }
        public StatusDaVenda Status { get; set; }
        [JsonIgnore]
        public Vendedor Vendedor { get; set; }
        public int VendedorId { get; set; }
    }
}
