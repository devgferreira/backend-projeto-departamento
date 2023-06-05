using AutoMapper;
using backend_projeto_departamento.Application.DTOs;
using backend_projeto_departamento.Application.Interface;
using backend_projeto_departamento.Domain.Interfaces;
using backend_projeto_departamento.Domain.Models;

namespace backend_projeto_departamento.Application.Service
{
    public class VendedorService : IVendedorService
    {
        private readonly IVendedorRepository _vendedorRepository;
        private readonly IMapper _mapper;
        public VendedorService(IVendedorRepository vendedorRepository, IMapper mapper)
        {
            _vendedorRepository = vendedorRepository;
            _mapper = mapper;
        }

        public async Task<List<VendedorDTO>> FindAllAsync()
        {
            var vendedores = await _vendedorRepository.FindAllAsync();
            return _mapper.Map<List<VendedorDTO>>(vendedores);
        }

        public async Task InsertAsync(VendedorDTO obj)
        {
            var vendedor =  _mapper.Map<Vendedor>(obj);
            await _vendedorRepository.InsertAsync(vendedor);
            obj.Id = vendedor.Id;
        }

        public async Task<VendedorDTO> FindByIdAsync(int id)
        {
            var vendedor = await _vendedorRepository.FindByIdAsync(id);
            return _mapper.Map<VendedorDTO>(vendedor);
        }
        public async Task RemoveAsync(int id)
        {
            var vendedor = _vendedorRepository.FindByIdAsync(id).Result;
            await _vendedorRepository.RemoveAsync(vendedor);
        }
        public async Task UpdateAsync(VendedorDTO obj)
        {
            var vendedor = _mapper.Map<Vendedor>(obj);
            await _vendedorRepository.UpdateAsync(vendedor);
        }
    }
}

