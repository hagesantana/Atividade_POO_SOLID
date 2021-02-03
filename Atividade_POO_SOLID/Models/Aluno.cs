using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Atividade_POO_SOLID.Models
{
    //HERANÇA
    public partial class Aluno : Pessoa
    {
        //ESTADO
        public string Curso { get; set; }
        public DateTime? DataMatricula { get; set; }
        //ESTADO
        //COMPORTAMENTO
        public Aluno() { }
        public Aluno(DateTime pDataMatricula, string pCurso)
        {
            this.DataMatricula = pDataMatricula;
            this.Curso = pCurso;
        }
        //COMPORTAMENTO
    }
}
