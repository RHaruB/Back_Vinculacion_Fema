using Back_Vinculacion_Fema.Models.DbModels;
using Back_Vinculacion_Fema.Models.RequestModels;
using Microsoft.EntityFrameworkCore;

namespace Back_Vinculacion_Fema.CRUD
{
    public class User
    {
        private readonly vinculacionfemaContext _context;

        public User(vinculacionfemaContext context)
        {
            _context = context;
        }
        public async Task<bool> ObtenerUsuario(string userName)
        {
            return await _context.TblFemaUsuarios.AnyAsync(u => u.UserName == userName);
        }

        public async Task<TblFemaUsuario> CrearUsuario(RegisterUserRequest request, decimal idPersona)
        {
            try
            {
                var user = new TblFemaUsuario
                {
                    IdPersona = idPersona,
                    UserName = request.UserName,
                    Correo = request.Correo,
                    Clave = request.Clave,
                    ClaveTmp = request.Clave,
                    FechaCreacion = request.FechaCreacion,
                    FechaModificacion = request.FechaModificacion,
                    Modulo = "Estudiante",
                    Estado = true
                };

                _context.TblFemaUsuarios.Add(user);
                await _context.SaveChangesAsync();

                return user;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el usuario", ex);
            }
        }
    }
}
