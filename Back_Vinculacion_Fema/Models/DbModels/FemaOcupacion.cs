using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class FemaOcupacion
    {
        public int CodSecuencia { get; set; }
        public int CodFema { get; set; }
        public int? CodOcupacion { get; set; }
        public int? Unidades { get; set; }

        public virtual Fema CodFemaNavigation { get; set; } = null!;
        public virtual Ocupacion? CodOcupacionNavigation { get; set; }
    }
}
