using Atividade_POO_SOLID.Interfaces;
using Atividade_POO_SOLID.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_POO_SOLID.Repositories
{
    public class PessoaRepository : IPessoaRepository//INTERFACE
    {
        //IMPLEMENTAÇÃO
        private AtividadeContext _context = new AtividadeContext();
        public void Adicionar(Pessoa entity)
        {
            _context.Pessoas.Add(entity);
            _context.SaveChanges();
        }

        public void Alterar(Pessoa entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public IEnumerable<Pessoa> Listar()
        {
            return _context.Pessoas.ToList();
        }

        public void Remover(int id)
        {
            var entity = _context.Pessoas.Find(id);
            _context.Remove(entity);
            _context.SaveChanges();
        }
    }
}
