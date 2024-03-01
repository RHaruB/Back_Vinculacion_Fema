using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class TipoEdificacion
    {
        public TipoEdificacion()
        {
            FemaPuntuacions = new HashSet<FemaPuntuacion>();
        }

        public int CodTipoEdificacion { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }

        public virtual ICollection<FemaPuntuacion> FemaPuntuacions { get; set; }
    }
}
