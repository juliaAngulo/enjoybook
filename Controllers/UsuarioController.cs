using Proyecto1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace Proyecto1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly LibrosContext _baseDatos;

        public UsuarioController(LibrosContext baseDatos)
        {
            _baseDatos = baseDatos;
        }
        [HttpGet]
        [Route("ListaUsuarios")]
        public async Task<IActionResult> ListaUsuarios()
        {
            var usuario = await _baseDatos.Usuarios1.ToListAsync();
            return Ok(usuario);
        }
        [HttpPut]
        [Route("Actualizar/{id:int}")]

        public async Task<IActionResult> Actualizar(int id, Usuario item)
        {
            if (id != item.IdUsuario)
            {
                return BadRequest();
            }

            _baseDatos.Entry(item).State = EntityState.Modified;
            await _baseDatos.SaveChangesAsync();
            return Ok(item);
        }
        [HttpPost]
        [Route("Agregar")]
        public async Task<IActionResult> Agregar([FromBody] Usuario request)
        {
            await _baseDatos.Usuarios1.AddAsync(request);
            await _baseDatos.SaveChangesAsync();
            return Ok(request);
        }
    }
}

