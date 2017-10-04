using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApi.Entidades
{
    public class Funcionario
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Funcao { get; set; }
        public string Turno { get; set; }
        public int HorasTrabalhadas { get; set; }
        public double ValorDaHora { get; set; }

    }
}