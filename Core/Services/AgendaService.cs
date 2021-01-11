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
        #region Listar Todos Clientes
        public SelectList ListarCliente()
        {
            var listarClientes = new AgendaRepo().ListarClientes();

            return new SelectList(listarClientes, "Nome", "Nome");
        }
        #endregion

        #region Listar Todos Serviços
        public SelectList ListarServico()
        {
            var listarServicos = new AgendaRepo().ListarServicos();

            return new SelectList(listarServicos, "NomeServico", "NomeServico");
        }
        #endregion

        #region Enum Dos Formas de Agendamento
        public IEnumerable<SelectListItem> ListarFormas()
        {
            var lista = new List<SelectListItem>()
            {
                new SelectListItem(){ Value = "1", Text = "Convênio" },
                new SelectListItem(){ Value = "2", Text = "Dinheiro" },
                new SelectListItem(){ Value = "3", Text = "Cartão de Débito" },
                new SelectListItem(){ Value = "4", Text = "Cartão de Credito" },                
            };

            return lista;
        }
        #endregion

        public IEnumerable<SelectListItem> ListarTipos()
        {
            var lista = new List<SelectListItem>()
            {
                new SelectListItem(){ Value = "1", Text = "Particular" },
                new SelectListItem(){ Value = "2", Text = "Plano de Saúde" },                
            };

            return lista;
        }
    }
}