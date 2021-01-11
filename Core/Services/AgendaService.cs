using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Core.Services
{
    public class AgendaService
    {
        public SelectList ListarCliente()
        {
            var listarClientes = new ClienteRepo().ListarClientes();

            return new SelectList(listarClientes, "Nome", "Nome");
        }
    }
}