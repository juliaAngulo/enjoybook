using Proyecto1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace Proyecto1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublicarController : ControllerBase
    {
        private readonly LibrosContext _baseDatos;

        public PublicarController(LibrosContext baseDatos)
        {
            _baseDatos = baseDatos;
        }
        [HttpGet]
        [Route("ListaLibro")]
        public async Task<IActionResult> ListaLibro()
        {
            var libro = await _baseDatos.Publicars.ToListAsync();
            return Ok(libro);
        }
        [HttpPut]
        [Route("Actualizar/{id:int}")]

        public async Task<IActionResult> Actualizar(int id, Publicar item)
        {
            if (id != item.IdPublicar)
            {
                return BadRequest();
            }

            _baseDatos.Entry(item).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();
            return Ok(item);
        }
        [HttpPost]
        [Route("Agregar")]
        public async Task<IActionResult> Agregar([FromBody] Publicar request)
        {
            await _baseDatos.Publicars.AddAsync(request);
            await _baseDatos.SaveChangesAsync();
            return Ok(request);
        }
        [HttpDelete]
        [Route("Eliminar/{id:int}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var eliminarLibro = await _baseDatos.Publicars.FindAsync(id);

            if (eliminarLibro == null)
                return BadRequest("El libro no existe");
            _baseDatos.Publicars.Remove(eliminarLibro);
            await _baseDatos.SaveChangesAsync();
            return Ok();
        }
    }
}



