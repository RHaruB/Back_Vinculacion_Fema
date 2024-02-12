using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class Fema
    {
        public Fema()
        {
            FemaEdificios = new HashSet<FemaEdificio>();
            FemaEvalEstructurada = new HashSet<FemaEvalEstructuradum>();
            FemaEvalNoEstructurada = new HashSet<FemaEvalNoEstructuradum>();
            FemaEvaluacions = new HashSet<FemaEvaluacion>();
            FemaOcupacions = new HashSet<FemaOcupacion>();
            FemaOtrosPeligros = new HashSet<FemaOtrosPeligro>();
            FemaPuntuacions = new HashSet<FemaPuntuacion>();
            FemaSuelos = new HashSet<FemaSuelo>();
        }

        public int CodFema { get; set; }
        public string? Direccion { get; set; }
        public string? CodigoPostal { get; set; }
        public string? OtrosIdentificadores { get; set; }
        public string? NomEdificacion { get; set; }
        public string? UsoEdificacion { get; set; }
        public string? Latitud { get; set; }
        public string? Longitud { get; set; }
        public string? NomEncuestador { get; set; }
        public DateTime? FechaEncuesta { get; set; }
        public TimeSpan? HoraEncuesta { get; set; }
        public string? RutaImagenEdif { get; set; }
        public string? RutaImagenCroquis { get; set; }
        public string? Comentarios { get; set; }
        public string? RequiereNivel2 { get; set; }
        public int? CodUsuarioIng { get; set; }
        public DateTime? FecIngreso { get; set; }
        public int? CodUsuarioAct { get; set; }
        public DateTime? FecActualiza { get; set; }

        public virtual ICollection<FemaEdificio> FemaEdificios { get; set; }
        public virtual ICollection<FemaEvalEstructuradum> FemaEvalEstructurada { get; set; }
        public virtual ICollection<FemaEvalNoEstructuradum> FemaEvalNoEstructurada { get; set; }
        public virtual ICollection<FemaEvaluacion> FemaEvaluacions { get; set; }
        public virtual ICollection<FemaOcupacion> FemaOcupacions { get; set; }
        public virtual ICollection<FemaOtrosPeligro> FemaOtrosPeligros { get; set; }
        public virtual ICollection<FemaPuntuacion> FemaPuntuacions { get; set; }
        public virtual ICollection<FemaSuelo> FemaSuelos { get; set; }
    }
}
