using System;
using System.Collections.Generic;

#nullable disable

namespace Atividade_POO_SOLID.Models
{
    //HERANÇA
    public partial class Funcionario : Pessoa
    {
        //ESTADO
        public DateTime? DataAdmissao { get; set; }
        public string Cargo { get; set; }
        //ESTADO
        //COMPORTAMENTO
        public Funcionario() { }
        public Funcionario(DateTime pDataAdmissao, string pCargo)
        {
            this.DataAdmissao = pDataAdmissao;
            this.Cargo = pCargo;
        }
        //COMPORTAMENTO
    }
}
