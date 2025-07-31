using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using Domain.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class ProdutoService
    {
        private readonly IProdutoRepository _produtoRepo;
        public ProdutoService(IProdutoRepository produtoRepo)
        {
            _produtoRepo = produtoRepo;
        }

        public void CriarProduto(string nome, decimal preco)
        {
            var produto = new Produto(nome, preco);
            _produtoRepo.Adicionar(produto);
        }
    }
}
