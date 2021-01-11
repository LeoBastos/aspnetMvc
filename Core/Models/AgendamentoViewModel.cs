using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Models
{
    public class AgendamentoViewModel
    {
        public AgendamentoViewModel(){}

        public AgendamentoViewModel(Cliente dadosCliente, Servico dadosServico, Agenda dadosAgenda)
        {
            DadosCliente = dadosCliente;
            DadosServico = dadosServico;
            DadosAgenda = dadosAgenda;
        }
        public Cliente DadosCliente { get; set; }
        public Servico DadosServico { get; set; }
        public Agenda DadosAgenda { get; set; }        
    }
}