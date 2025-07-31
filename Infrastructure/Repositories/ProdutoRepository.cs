using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly List<Produto> _produtos = new();
        public void Adicionar(Produto produto) => _produtos.Add(produto);
        public Produto ObterPorId(Guid id) => _produtos.FirstOrDefault(p => p.Id == id);
    }
}
