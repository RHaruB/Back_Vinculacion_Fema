using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class TblFemaPersona
    {
        public TblFemaPersona()
        {
            TblFemaUsuarios = new HashSet<TblFemaUsuario>();
        }

        public decimal IdPersona { get; set; }
        public decimal IdTipo { get; set; }
        public string TipoIdentificacion { get; set; } = null!;
        public string Identificacion { get; set; } = null!;
        public string? Nombre1 { get; set; }
        public string? Nombre2 { get; set; }
        public string? Apellido1 { get; set; }
        public string? Apellido2 { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public string? Direccion { get; set; }
        public string? Sexo { get; set; }
        public string? Contacto { get; set; }
        public string? Correo { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<TblFemaUsuario> TblFemaUsuarios { get; set; }
    }
}
