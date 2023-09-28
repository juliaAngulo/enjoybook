using Proyecto1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Proyecto1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlquilarController : ControllerBase
    {
        private readonly LibrosContext _baseDatos;

        public AlquilarController(LibrosContext baseDatos)
        {
            _baseDatos = baseDatos;
        }
        [HttpGet]
        [Route("ListaAlquiler")]
        public async Task<IActionResult> ListaAlquiler()
        {
            var alquiler = await _baseDatos.Alquilars.ToListAsync();
            return Ok(alquiler);
        }
        [HttpPost]
        [Route("Agregar")]
        public async Task<IActionResult> Agregar([FromBody] Alquilar request)
        {
            await _baseDatos.Alquilars.AddAsync(request);
            await _baseDatos.SaveChangesAsync();
            return Ok(request);
        }
        [HttpDelete]
        [Route("Eliminar/{id:int}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            var eliminarAlquiler = await _baseDatos.Alquilars.FindAsync(id);

            if (eliminarAlquiler == null)
                return BadRequest("El alquiler no existe");
            _baseDatos.Alquilars.Remove(eliminarAlquiler);
            await _baseDatos.SaveChangesAsync();
            return BadRequest("El alquiler se ha cancelado");
        }
    }

}
