using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class TblFemaRole
    {
        public TblFemaRole()
        {
            TblFemaMenuUsuarios = new HashSet<TblFemaMenuUsuario>();
            TblFemaOpcionesRoles = new HashSet<TblFemaOpcionesRole>();
            TblFemaRolesUsuarios = new HashSet<TblFemaRolesUsuario>();
        }

        public decimal IdRol { get; set; }
        public string? Rol { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<TblFemaMenuUsuario> TblFemaMenuUsuarios { get; set; }
        public virtual ICollection<TblFemaOpcionesRole> TblFemaOpcionesRoles { get; set; }
        public virtual ICollection<TblFemaRolesUsuario> TblFemaRolesUsuarios { get; set; }
    }
}
