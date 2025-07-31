using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class PedidoService
    {
        private readonly IPedidoRepository _pedidoRepo;
        private readonly IProdutoRepository _produtoRepo;


        public PedidoService(IPedidoRepository pedidoRepo, IProdutoRepository produtoRepo)
        {
            _pedidoRepo = pedidoRepo;
            _produtoRepo = produtoRepo;
        }

        public void CriarPedido(List<(Guid produtoId, int quantidade)> itens)
        {
            var pedido = new Pedido();
            foreach (var (produtoId, quantidade) in itens)
            {
                var produto = _produtoRepo.ObterPorId(produtoId);
                var item = new PedidoItem(produto.Id, quantidade, produto.Preco);
                pedido.AdicionarItem(item);
            }
            _pedidoRepo.Adicionar(pedido);
        }
    }
}
