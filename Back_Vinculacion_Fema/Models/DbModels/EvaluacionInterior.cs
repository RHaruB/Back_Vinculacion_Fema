using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class EvaluacionInterior
    {
        public EvaluacionInterior()
        {
            FemaEvaluacions = new HashSet<FemaEvaluacion>();
        }

        public int CodEvalInterior { get; set; }
        public string? Descripcion { get; set; }
        public string? Estado { get; set; }

        public virtual ICollection<FemaEvaluacion> FemaEvaluacions { get; set; }
    }
}
