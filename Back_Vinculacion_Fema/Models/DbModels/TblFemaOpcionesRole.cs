using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class TblFemaOpcionesRole
    {
        public decimal IdRolOp { get; set; }
        public decimal IdRol { get; set; }
        public decimal IdOpciones { get; set; }
        public DateTime FechaValides { get; set; }
        public bool Estado { get; set; }

        public virtual TblFemaOpcione IdOpcionesNavigation { get; set; } = null!;
        public virtual TblFemaRole IdRolNavigation { get; set; } = null!;
    }
}
