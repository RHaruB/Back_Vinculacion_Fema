using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class FemaEvalEstructuradum
    {
        public int CodSecuencia { get; set; }
        public int? CodFema { get; set; }
        public int? Chk1 { get; set; }
        public int? Chk2 { get; set; }
        public int? Chk3 { get; set; }
        public int? Chk4 { get; set; }

        public virtual Fema? CodFemaNavigation { get; set; }
    }
}
