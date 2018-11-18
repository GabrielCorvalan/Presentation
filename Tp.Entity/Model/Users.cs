using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class Users
    {
        public Users()
        {
            PagesForRols = new HashSet<PagesForRols>();
            PagesForUsers = new HashSet<PagesForUsers>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Names { get; set; }
        public string Surnames { get; set; }
        public int? RolId { get; set; }
        public bool Deleted { get; set; }

        public Rols Rol { get; set; }
        public ICollection<PagesForRols> PagesForRols { get; set; }
        public ICollection<PagesForUsers> PagesForUsers { get; set; }
    }
}
