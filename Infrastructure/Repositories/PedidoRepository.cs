using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly List<Pedido> _pedidos = new();

        public void Adicionar(Pedido pedido) => _pedidos.Add(pedido);
        public Pedido ObterPorId(Guid id) => _pedidos.FirstOrDefault(p => p.Id == id);
    }
}
