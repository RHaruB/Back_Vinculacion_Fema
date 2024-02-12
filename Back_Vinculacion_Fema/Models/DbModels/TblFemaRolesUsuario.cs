using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class TblFemaRolesUsuario
    {
        public decimal IdRol { get; set; }
        public decimal IdUsuario { get; set; }
        public DateTime FechaValides { get; set; }
        public bool Estado { get; set; }

        public virtual TblFemaRole IdRolNavigation { get; set; } = null!;
        public virtual TblFemaUsuario IdUsuarioNavigation { get; set; } = null!;
    }
}
