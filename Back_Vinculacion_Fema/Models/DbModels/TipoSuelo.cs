using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class TipoSuelo
    {
        public TipoSuelo()
        {
            FemaSuelos = new HashSet<FemaSuelo>();
        }

        public int CodTipoSuelo { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }

        public virtual ICollection<FemaSuelo> FemaSuelos { get; set; }
    }
}
