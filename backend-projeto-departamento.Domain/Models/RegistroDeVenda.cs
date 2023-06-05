using backend_projeto_departamento.Domain.Models.Enums;

namespace backend_projeto_departamento.Domain.Models
{
    public class RegistroDeVenda : Entity
    {
        public DateTime Data { get; set; }
        public double Quantia { get; set; }
        public StatusDaVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }
        public int VendedorId { get; set; }

        public RegistroDeVenda()
        {
        }

        public RegistroDeVenda(DateTime data, double quantia, StatusDaVenda status, Vendedor vendedor)
        {
            Data = data;
            Quantia = quantia;
            Status = status;
            Vendedor = vendedor;
        }
        public RegistroDeVenda(int id,DateTime data, double quantia, StatusDaVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantia = quantia;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
