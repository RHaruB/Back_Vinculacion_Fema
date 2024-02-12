using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class FemaEdificio
    {
        public int CodSecuencia { get; set; }
        public int? CodFema { get; set; }
        public int? NroPisosSup { get; set; }
        public int? NroPisosInf { get; set; }
        public int? AnioConstruccion { get; set; }
        public decimal? AreaTotalPiso { get; set; }
        public int? AnioCodigo { get; set; }
        public int? Ampliacion { get; set; }
        public int? AmplAnioConstruccion { get; set; }

        public virtual Fema? CodFemaNavigation { get; set; }
    }
}
