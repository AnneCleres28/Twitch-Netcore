using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApi.Model;

namespace WepApi.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class GeralController : ControllerBase
    {
        [HttpGet]
        [Route("helloworld")]
        public ActionResult GetHelloWorld()
        {
            return Ok("Hello World");
        }

        [HttpGet]
        [Route("meunome/{nome}")]
        public ActionResult GetMeuNome(string nome)
        {
            return Ok("Meu nome é " + nome);
        }

        [HttpGet]
        [Route("usuario/{nome}/{sobrenome}/{idade}/{endereco}")]
        public ActionResult GetUsuario(string nome, string sobrenome, int idade, string endereco)
        {
            return Ok($@"Nome {nome} Sobrenome {sobrenome} Idade {idade} Endereço {endereco}");
        }

        [HttpPost]
        [Route("usuarioobjeto/{usuario}")]
        public ActionResult GetUsuario([FromBody]Usuario usuario)
        {
            return Ok($@"Nome {usuario.Nome} Sobrenome {usuario.Sobrenome} Idade {usuario.Idade} Endereço {usuario.Endereco}");
        }
    }
}
