using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Pedido
    {
        public Guid Id { get; private set; }
        public List<PedidoItem> Itens { get; private set; } = new();

        public Pedido()
        {
            Id = Guid.NewGuid();
        }

        public void AdicionarItem(PedidoItem item)
        {
            Itens.Add(item);
        }

        public decimal Total => Itens.Sum(i => i.Subtotal);
    }
}
