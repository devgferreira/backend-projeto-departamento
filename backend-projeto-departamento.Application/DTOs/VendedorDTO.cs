using backend_projeto_departamento.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace backend_projeto_departamento.Application.DTOs
{
    public class VendedorDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The Nome is Required")]
        [DisplayName("Nome")]
        public string Nome { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public DateTime DataDeNascimento { get; set; }
        [Required]
        public double SalarioBase { get; set; }

        [Required]
        [DisplayName("Departamentos")]
        public int DepartamentoId { get; set; }
        [JsonIgnore]
        public ICollection<RegistroDeVenda> RegistroDeVendas { get; set; } = new List<RegistroDeVenda>();
    }
}
