using System;
using System.Collections.Generic;

namespace Back_Vinculacion_Fema.Models.DbModels
{
    public partial class TblFemaItem
    {
        public int IdItem { get; set; }
        public int? SubMenuId { get; set; }
        public string? Icono { get; set; }
        public string? TagItem { get; set; }
        public bool? Estado { get; set; }

        public virtual TblFemaSubMenu? SubMenu { get; set; }
    }
}
