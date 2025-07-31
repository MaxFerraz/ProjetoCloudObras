using Application.DTOs;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController] // Added attribute to make it a valid API controller  
    [Route("api/[controller]")] // Added route for the controller  
    public class ProdutosController : ControllerBase // Changed base class to ControllerBase to provide Ok() method  
    {
        private readonly ProdutoService _service;

        public ProdutosController(ProdutoService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Post([FromBody] ProdutoDTO dto)
        {
            _service.CriarProduto(dto.Nome, dto.Preco);
            return Ok(); 
        }
    }
}
