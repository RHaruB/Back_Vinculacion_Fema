using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class FemaPuntuacion
    {
        public int CodSecuencia { get; set; }
        public int? CodFema { get; set; }
        public int? CodTipoEdificacion { get; set; }
        public int? CodTipoPuntuacion { get; set; }
        public decimal? Valor { get; set; }

        public virtual Fema? CodFemaNavigation { get; set; }
        public virtual TipoEdificacion? CodTipoEdificacionNavigation { get; set; }
        public virtual TipoPuntuacion? CodTipoPuntuacionNavigation { get; set; }
    }
}
