using AutoMapper;
using backend_projeto_departamento.Application.DTOs;
using backend_projeto_departamento.Application.Interface;
using backend_projeto_departamento.Domain.Interfaces;

namespace backend_projeto_departamento.Application.Service
{
    public class RegistroDeVendaService : IRegistroDeVendaService
    {
        private readonly IRegistroDeVendaRepository _registroDeVendaRepository;
        private readonly IMapper _mapper;
        public RegistroDeVendaService(IRegistroDeVendaRepository registroDeVendaRepository, IMapper mapper)
        {
            _registroDeVendaRepository = registroDeVendaRepository;
            _mapper = mapper;
        }
        public async Task<List<RegistroDeVendaDTO>> FindByDateAsync(DateTime? mindate, DateTime? maxDate)
        {
            var registroDeVenda = await _registroDeVendaRepository.FindByDateAsync(mindate, maxDate);
            return _mapper.Map<List<RegistroDeVendaDTO>>(registroDeVenda);
        }
    }
}
