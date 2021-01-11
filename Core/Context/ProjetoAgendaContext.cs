using Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Core.Context
{
    public class ProjetoAgendaContext : DbContext
    {
        public ProjetoAgendaContext()
            : base("ProjetoAgendaContext")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Servico> Serviços { get; set; }
        
    }
}