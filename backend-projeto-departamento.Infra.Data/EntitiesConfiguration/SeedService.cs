using backend_projeto_departamento.Domain.Models.Enums;
using backend_projeto_departamento.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend_projeto_departamento.Infra.Data.Context;

namespace backend_projeto_departamento.Infra.Data.EntitiesConfiguration
{
    public class SeedingService
    {
        private ApplicationDbContext _context;

        public SeedingService()
        {
        }

        public SeedingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() || _context.Vendedor.Any() || _context.RegistroDeVenda.Any())
            {
                return; // DB já foi populado
            }

            Departamento d1 = new Departamento("Amazon");
            Departamento d2 = new Departamento("Reaper");
            Departamento d3 = new Departamento("Facetruck");

            Vendedor v1 = new Vendedor("Gabriel Ferras", "ferras@gmail.com", new DateTime(2004, 01, 24), 100, d1);
            Vendedor v2 = new Vendedor("Lucas Fofuxo", "fofuxo@gmail.com", new DateTime(2003, 12, 25), 300, d2);
            Vendedor v3 = new Vendedor("João James", "james@gmail.com", new DateTime(2000, 07, 07), 50, d3);


            RegistroDeVenda rv1 = new RegistroDeVenda(new DateTime(2018, 05, 01), 5000, StatusDaVenda.Processado, v1);
            RegistroDeVenda rv2 = new RegistroDeVenda(new DateTime(2020, 03, 07), 12000.00, StatusDaVenda.Pendente, v2);
            RegistroDeVenda rv3 = new RegistroDeVenda(new DateTime(2018, 05, 10), 5000.00, StatusDaVenda.Processado, v3);
            RegistroDeVenda rv4 = new RegistroDeVenda(new DateTime(2019, 05, 10), 5000.00, StatusDaVenda.Pendente, v2);
            RegistroDeVenda rv5 = new RegistroDeVenda(new DateTime(2020, 05, 12), 5000.00, StatusDaVenda.Cancelado, v3);
            RegistroDeVenda rv6 = new RegistroDeVenda(new DateTime(2020, 05, 01), 5000.00, StatusDaVenda.Cancelado, v1);
            RegistroDeVenda rv7 = new RegistroDeVenda(new DateTime(2019, 05, 10), 5000.00, StatusDaVenda.Pendente, v2);
            RegistroDeVenda rv8 = new RegistroDeVenda(new DateTime(2018, 05, 20), 5000.00, StatusDaVenda.Cancelado, v3);
            RegistroDeVenda rv9 = new RegistroDeVenda(new DateTime(2019, 05, 30), 5000.00, StatusDaVenda.Processado, v2);
            RegistroDeVenda rv10 = new RegistroDeVenda(new DateTime(2018, 05, 12), 5000.00, StatusDaVenda.Cancelado, v3);

            _context.Departamento.AddRange(d1, d2, d3);
            _context.Vendedor.AddRange(v1, v2, v3);
            _context.RegistroDeVenda.AddRange(rv1, rv2, rv3, rv4, rv5, rv6, rv7, rv8, rv9, rv10);

            _context.SaveChanges();


        }
    }
}
