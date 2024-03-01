using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class FemaSuelo
    {
        public int CodSecuencia { get; set; }
        public int? CodFema { get; set; }
        public int? CodTipoSuelo { get; set; }
        public string? AsumirTipo { get; set; }
        public string? RiesgoGeologico { get; set; }
        public string? Adyacencia { get; set; }
        public string? Irregularidades { get; set; }
        public string? PeligroCaidaExt { get; set; }

        public virtual Fema? CodFemaNavigation { get; set; }
        public virtual TipoSuelo? CodTipoSueloNavigation { get; set; }
    }
}
