using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class TblFemaUsuario
    {
        public TblFemaUsuario()
        {
            TblFemaRolesUsuarios = new HashSet<TblFemaRolesUsuario>();
        }

        public decimal IdUsuario { get; set; }
        public decimal IdPersona { get; set; }
        public string? UserName { get; set; }
        public string? Correo { get; set; }
        public string? Clave { get; set; }
        public string? ClaveTmp { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string? Modulo { get; set; }
        public bool? Estado { get; set; }

        public virtual TblFemaPersona IdPersonaNavigation { get; set; } = null!;
        public virtual ICollection<TblFemaRolesUsuario> TblFemaRolesUsuarios { get; set; }
    }
}
