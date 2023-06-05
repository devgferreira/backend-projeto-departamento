using AutoMapper;
using backend_projeto_departamento.Application.DTOs;
using backend_projeto_departamento.Domain.Models;

namespace backend_projeto_departamento.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Vendedor, VendedorDTO>().ReverseMap();
            CreateMap<Departamento, DepartamentoDTO>().ReverseMap();
            CreateMap<RegistroDeVenda, RegistroDeVendaDTO>().ReverseMap();

        }
    }
}
