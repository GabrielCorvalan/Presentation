using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class PagesForRols
    {
        public int Id { get; set; }
        public int? PageId { get; set; }
        public int? RolId { get; set; }

        public Pages Page { get; set; }
        public Rols Rol { get; set; }
    }
}
