using backend_projeto_departamento.Application.Interface;
using backend_projeto_departamento.Application.Mappings;
using backend_projeto_departamento.Application.Service;
using backend_projeto_departamento.Domain.Account;
using backend_projeto_departamento.Domain.Interfaces;
using backend_projeto_departamento.Infra.Data.Context;
using backend_projeto_departamento.Infra.Data.EntitiesConfiguration;
using backend_projeto_departamento.Infra.Data.Identity;
using backend_projeto_departamento.Infra.Data.Repositories;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace backend_projeto_departamento.Infra.IoC
{
    public static class DependencyInjectionAPI
    {
        public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
            ) ?? throw new InvalidOperationException("Erro")));

            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            services.AddScoped<IDepartamentoRepository, DepartamentoRepository>();
            services.AddScoped<IRegistroDeVendaRepository, RegistroDeVendaRepository>();
            services.AddScoped<IVendedorRepository, VendedorRepository>();
            services.AddScoped<IDepartamentoService, DepartamentoService>();
            services.AddScoped<IRegistroDeVendaService, RegistroDeVendaService>();
            services.AddScoped<IVendedorService, VendedorService>(); 
            services.AddScoped<IAuthenticate, AuthenticateService>(); 
            services.AddScoped<ISeedUserRoleInitial, SeedUserRolesInitial>(); 
            services.AddScoped<SeedingService>();


            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            var myhandlers = configuration.GetSection("backend-projeto-departamento.Application");
            return services;
        }
    }
}