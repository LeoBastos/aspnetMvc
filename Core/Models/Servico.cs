using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Models
{
    public class Servico
    {
        public Servico(){}

        public Servico(int id, string nomeServico)
        {
            Id = id;
            NomeServico = nomeServico;
        }

        public int Id { get; set; }
        public string NomeServico { get; set; }
    }
}