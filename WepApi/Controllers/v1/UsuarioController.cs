using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApi.Model;

namespace WepApi.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private static List<Usuario> _usuariosDB;

        public UsuarioController()
        {
            if(_usuariosDB == null)
            _usuariosDB = new List<Usuario>();
        }

        [HttpGet]
        public ActionResult GetUsuarios()
        {
            return Ok(_usuariosDB);
        }

        [HttpPost]
        public ActionResult PostUsuario([FromBody] Usuario usuario)
        {
            _usuariosDB.Add(usuario);
            return Ok();
        }

        [HttpPut]
        public ActionResult PutUsuario([FromBody] Usuario usuario)
        {
           var usuarioLocalizado = _usuariosDB.Find(a => a.Nome == usuario.Nome);

            if(usuarioLocalizado != null)
            {
                usuarioLocalizado.Nome = usuario.Nome;
                usuarioLocalizado.Sobrenome = usuario.Sobrenome;
                usuarioLocalizado.Idade = usuario.Idade;
                usuarioLocalizado.Endereco = usuario.Endereco;
            } else
            {
                return NotFound();
            }

            return Ok();
        }

        [HttpDelete]
        public ActionResult DeleteUsuario ([FromBody] string nome)
        {
            var usuarioLocalizado = _usuariosDB.Find(a => a.Nome.Equals(nome));

            if(usuarioLocalizado != null)
            {
                _usuariosDB.Remove(usuarioLocalizado);
            }
            else
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
