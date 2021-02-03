using Atividade_POO_SOLID.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_POO_SOLID.Interfaces
{
    public interface IPessoaServices
    {
        void Remover(int id);
        void Adicionar(Pessoa entity);
        void Alterar(Pessoa entity);
        IEnumerable<Pessoa> Listar();
    }
}
