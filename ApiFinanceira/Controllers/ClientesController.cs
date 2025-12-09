using ApiFinanceira.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinanceira.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private readonly ClientesService _clienteService;

    public ClientesController(ClientesService clienteService)
    {
        _clienteService = clienteService;
    }

    [HttpGet("listar-usuarios")]
    public async Task<IActionResult> ListarClientes()
    {
        var listar = await _clienteService.GetClientesAsync();
        
        return Ok(listar);
    }

    [HttpGet("listar-cliente-id")]
    public async Task<IActionResult> ListarClientesId(int id)
    {
        var listar = await _clienteService.GetClientesByIdAsync(id);
        
        return Ok(listar);
    }
    
    public class CriarClienteRequest
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
    }

    [HttpPost("criar-cliente")]
    public async Task<IActionResult> CriarClientes([FromBody] CriarClienteRequest request)
    {
        if (request == null) return BadRequest();
        
        var novoCliente = await _clienteService.PostClientesAsync(request.Nome, request.Documento, request.Email);
        
        return Ok(novoCliente);
    }

    [HttpPut("atualizar-cliente")]
    public async Task<IActionResult> AtualizarCliente([FromBody] CriarClienteRequest request)
    {
        if (request == null) return BadRequest();
        
        var atualizar = await _clienteService.PutClientesAsync(request.Id, request.Nome, request.Documento, request.Email);
        
        return Ok(atualizar);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletarCliente(int id)
    {
        try
        {
            var sucesso = await _clienteService.DeleteClientesAsync(id);

            if (!sucesso)
            {
                return NotFound(new { message = "Cliente não encontrado." });
            }
            
            return NoContent(); 
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = ex.Message });
        }
    }
}