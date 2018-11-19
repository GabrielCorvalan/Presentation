using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class Rols
    {
        public Rols()
        {
            PagesForRols = new HashSet<PagesForRols>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string RolName { get; set; }

        public ICollection<PagesForRols> PagesForRols { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
