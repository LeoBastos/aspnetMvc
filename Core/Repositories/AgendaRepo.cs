using Core.Context;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Repositories
{
    public class AgendaRepo
    {
        private ProjetoAgendaContext db = new ProjetoAgendaContext();

        public IEnumerable<Cliente> ListarClientes()
        {
            return db.Clientes.ToList();
        }
        public IEnumerable<Servico> ListarServicos()
        {
            return db.Serviços.ToList();
        }
       
    }
}