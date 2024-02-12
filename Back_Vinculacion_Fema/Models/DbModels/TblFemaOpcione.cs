using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class TblFemaOpcione
    {
        public TblFemaOpcione()
        {
            TblFemaOpcionesRoles = new HashSet<TblFemaOpcionesRole>();
        }

        public decimal IdOpciones { get; set; }
        public string? Opcion { get; set; }
        public string? Homologacion { get; set; }
        public bool Estado { get; set; }

        public virtual ICollection<TblFemaOpcionesRole> TblFemaOpcionesRoles { get; set; }
    }
}
