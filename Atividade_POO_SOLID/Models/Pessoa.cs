using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Atividade_POO_SOLID.Models
{
    //ABSTRAÇÃO
    public abstract class Pessoa
    {
        //ESTADO
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        //ESTADO
        //COMPORTAMENTO
        public Pessoa() { }
        public Pessoa(int pId, string pNome, string pEmail)
        {
            this.Id = pId;
            this.Nome = pNome;
            this.Email = pEmail;
        }
        public string IdNomeEmail()
        {
            return Id.ToString() + "|" + Nome + "|" + Email;
        }
        //COMPORTAMENTO
    }
}
