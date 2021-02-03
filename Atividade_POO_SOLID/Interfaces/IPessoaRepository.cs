using Atividade_POO_SOLID.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_POO_SOLID.Interfaces
{
    public interface IPessoaRepository//4. ISP - Princípio da Segregação de Interfaces
    {
        void Remover(int id);
        void Adicionar(Pessoa entity);
        void Alterar(Pessoa entity);
        IEnumerable<Pessoa> Listar();
    }
}
