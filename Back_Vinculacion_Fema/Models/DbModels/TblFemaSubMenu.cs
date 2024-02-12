using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class TblFemaSubMenu
    {
        public TblFemaSubMenu()
        {
            TblFemaItems = new HashSet<TblFemaItem>();
        }

        public int SubMenuId { get; set; }
        public int? IdMenu { get; set; }
        public string? Descripcion { get; set; }
        public string? Icono { get; set; }

        public virtual TblFemaMenu? IdMenuNavigation { get; set; }
        public virtual ICollection<TblFemaItem> TblFemaItems { get; set; }
    }
}
