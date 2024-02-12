using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class TblFemaMenuUsuario
    {
        public int IdMu { get; set; }
        public decimal IdUsuario { get; set; }
        public int? IdModulo { get; set; }
        public decimal IdRol { get; set; }
        public bool Estado { get; set; }

        public virtual TblFemaModulo? IdModuloNavigation { get; set; }
        public virtual TblFemaRole IdRolNavigation { get; set; } = null!;
    }
}
