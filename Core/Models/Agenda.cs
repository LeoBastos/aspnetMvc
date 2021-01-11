using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core.Models
{
    public class Agenda
    {
        public Agenda(){}

        public Agenda(int id, DateTime dataAgendamento, DateTime horaInicial, DateTime horaFinal, string tipo, string formaPagamento)
        {
            Id = id;
            DataAgendamento = dataAgendamento;
            HoraInicial = horaInicial;
            HoraFinal = horaFinal;
            Tipo = tipo;
            FormaPagamento = formaPagamento;
        }

        public int Id { get; set; }       
        public DateTime DataAgendamento { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        public string Tipo { get; set; }
        public string FormaPagamento { get; set; }       

    }
}