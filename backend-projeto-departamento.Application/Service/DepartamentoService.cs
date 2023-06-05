using AutoMapper;
using backend_projeto_departamento.Application.DTOs;
using backend_projeto_departamento.Application.Interface;
using backend_projeto_departamento.Domain.Interfaces;

namespace backend_projeto_departamento.Application.Service
{
    public class DepartamentoService : IDepartamentoService
    {
        private readonly IDepartamentoRepository _departamentoRepository;
        private readonly IMapper _mapper;
        public DepartamentoService(IDepartamentoRepository departamentoRepository, IMapper mapper)
        {
            _departamentoRepository = departamentoRepository;
            _mapper = mapper;
        }

        public async Task<List<DepartamentoDTO>> FindAllAsync()
        {
            var departamenmtos = await _departamentoRepository.FindAllAsync();
            return _mapper.Map<List<DepartamentoDTO>>(departamenmtos);
        }
    }
}
