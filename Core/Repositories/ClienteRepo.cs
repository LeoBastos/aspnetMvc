using Core.Context;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Core.Repositories
{
    public class ClienteRepo 
    {
        private ProjetoAgendaContext db = new ProjetoAgendaContext();

        public IEnumerable<Cliente> ListarClientes()
        {
            return db.Clientes.ToList();
        }
    }
}