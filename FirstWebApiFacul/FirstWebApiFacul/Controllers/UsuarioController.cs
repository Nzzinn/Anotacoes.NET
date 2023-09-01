using Microsoft.AspNetCore.Mvc;
using FirstWebApiFacul.Models;

namespace FirstWebApiFacul.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        List<Usuario> usuarios = new List<Usuario>();

        [HttpGet("{id}")]
        public IActionResult GetUsuarios(int id)
        {
            Usuario usuario = usuarios.FirstOrDefault(x => x.Id == id);

            if(usuario != null)
            {
                return Ok(usuario);
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult AddUsuarios([FromBody] Usuario usuario)
        {
            usuarios.Add(usuario);
            return CreatedAtAction(nameof(GetUsuarios), new { id = usuario.Id }, usuario);
        }
    }
}
