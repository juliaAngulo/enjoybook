using Proyecto1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Proyecto1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprarController : ControllerBase
    {
        private readonly LibrosContext _baseDatos;

        public ComprarController(LibrosContext baseDatos)
        {
            _baseDatos = baseDatos;
        }
        [HttpGet]
        [Route("ListaCompras")]
        public async Task<IActionResult> ListaCompras()
        {
            var comprar = await _baseDatos.Comprars.ToListAsync();
            return Ok(comprar);
        }
        [HttpPost]
        [Route("Agregar")]
        public async Task<IActionResult> Agregar([FromBody] Comprar request)
        {
            await _baseDatos.Comprars.AddAsync(request);
            await _baseDatos.SaveChangesAsync();
            return Ok(request);
        }
        [HttpDelete]
        [Route("Eliminar/{id:int}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var eliminarCompra = await _baseDatos.Comprars.FindAsync(id);

            if (eliminarCompra == null)
                return BadRequest("La compra no existe");
            _baseDatos.Comprars.Remove(eliminarCompra);
            await _baseDatos.SaveChangesAsync();
            return BadRequest("La compra se ha cancelado");
        }
    }
}
