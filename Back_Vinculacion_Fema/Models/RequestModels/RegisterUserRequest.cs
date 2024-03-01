namespace Back_Vinculacion_Fema.Models.RequestModels
{
    public class RegisterUserRequest
    {
        #region Persona
        public decimal IdTipo { get; set; }
        public string TipoIdentificacion { get; set; } = null!;
        public string Identificacion { get; set; } = null!;
        public string? Nombre1 { get; set; }
        public string? Nombre2 { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public string? Direccion { get; set; }
        public string? Correo { get; set; }
        public string? Contacto { get; set; }
        public string? Sexo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
           
        public bool? Estado { get; set; }
        #endregion

        #region Usuario
        public string? UserName { get; set; }
        public string? Clave { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        #endregion
    }
}
