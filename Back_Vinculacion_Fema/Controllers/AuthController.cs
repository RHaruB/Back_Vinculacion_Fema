using Back_Vinculacion_Fema.Models.DbModels;
using Back_Vinculacion_Fema.Models.RequestModels;
using Back_Vinculacion_Fema.Models.Utilidades;
using Microsoft.AspNetCore.Mvc;

namespace Back_Vinculacion_Fema.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly vinculacionfemaContext _contexto;

        public AuthController(vinculacionfemaContext contexto)
        {
            _contexto = contexto;
        }

        [HttpPost("login")]
        public IActionResult Authenticate(UserLoginRequest credentials)
        {
            var encryptedPassword = credentials.Password; //Debe consumir el metodo de cifrado

            var usuario = _contexto.TblFemaUsuarios.FirstOrDefault(u => u.Estado == true && u.UserName == credentials.Nombre && u.Clave == encryptedPassword);

            if (usuario == null)
            {
                return Unauthorized();
            }

            return Ok(Token.GenerarToken(credentials.Nombre));
        }
    }
}
