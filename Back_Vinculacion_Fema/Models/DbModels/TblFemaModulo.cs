using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class TblFemaModulo
    {
        public TblFemaModulo()
        {
            TblFemaMenuUsuarios = new HashSet<TblFemaMenuUsuario>();
            TblFemaMenus = new HashSet<TblFemaMenu>();
        }

        public int IdModulo { get; set; }
        public string? Nombre { get; set; }
        public string? Homologacion { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<TblFemaMenuUsuario> TblFemaMenuUsuarios { get; set; }
        public virtual ICollection<TblFemaMenu> TblFemaMenus { get; set; }
    }
}
