using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class FemaEvaluacion
    {
        public int CodSecuencia { get; set; }
        public int? CodFema { get; set; }
        public int? CodEvalExterior { get; set; }
        public int? CodEvalInterior { get; set; }
        public string? DisenioRevisado { get; set; }
        public string? Fuente { get; set; }
        public string? PeligrosGeologicos { get; set; }
        public string? PersonaContacto { get; set; }

        public virtual EvaluacionExterior? CodEvalExteriorNavigation { get; set; }
        public virtual EvaluacionInterior? CodEvalInteriorNavigation { get; set; }
        public virtual Fema? CodFemaNavigation { get; set; }
    }
}
