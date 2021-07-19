using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB.API.Data;
using WEB.API.Model;

namespace WEB.API.Controllers
{

    [Produces("application/json")]
    [Route("api")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public UsuariosController(DatabaseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Lista usuários.
        /// </summary>
        [HttpGet]
        [EnableCors("UsuariosCORSPolicy")]
        public async Task<ActionResult<IEnumerable<Usuario>>> GetUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }


        /// <summary>
        /// Buscar usuário.
        /// </summary>
        [HttpGet("{id}")]
        [EnableCors("UsuariosCORSPolicy")]
        public async Task<ActionResult<Usuario>> GetUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return usuario;
        }

        /// <summary>
        /// Alterar usuário.
        /// </summary>
        [HttpPut("{id}")]
        [EnableCors("UsuariosCORSPolicy")]
        public async Task<IActionResult> PutUsuario(int id, Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return BadRequest();
            }

            _context.Entry(usuario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        /// <summary>
        /// Incluir usuário.
        /// </summary>
        [HttpPost]
        [EnableCors("UsuariosCORSPolicy")]
        public async Task<ActionResult<Usuario>> PostUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUsuario", new { id = usuario.Id }, usuario);
        }
            

        /// <summary>
        /// Excluir usuário.
        /// </summary>
        [HttpDelete("{id}")]
        [EnableCors("UsuariosCORSPolicy")]

        public async Task<IActionResult> DeleteUsuario(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);
        }
    }
}
