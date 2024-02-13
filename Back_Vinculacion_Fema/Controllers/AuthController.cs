using Back_Vinculacion_Fema.CRUD;
using Back_Vinculacion_Fema.Models.DbModels;
using Back_Vinculacion_Fema.Models.RequestModels;
using Back_Vinculacion_Fema.Models.Utilidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

            User usuarioLogic = new User(_contexto);
            var usuario = usuarioLogic.GetUsuarioLogin(credentials, encryptedPassword);

            if (usuario == null)
            {
                return Unauthorized();
            }

            return Ok(Token.GenerarToken(usuario.UserName));
        }   
    }
}
