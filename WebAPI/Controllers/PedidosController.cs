using Application.DTOs;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController] // Add this attribute to make the controller work with ASP.NET Core conventions
    [Route("api/[controller]")] // Define the route for the controller
    public class PedidosController : ControllerBase // Inherit from ControllerBase to access Ok() and other helper methods
    {
        private readonly PedidoService _service;

        public PedidosController(PedidoService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PedidoDTO dto)
        {
            var itens = dto.Itens.Select(i => (i.ProdutoId, i.Quantidade)).ToList();
            _service.CriarPedido(itens);
            return Ok(); 
        }
    }
}
