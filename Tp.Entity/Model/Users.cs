using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class Users
    {
        public Users()
        {
            PagesForUsers = new HashSet<PagesForUsers>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RolId { get; set; }
        public bool? Deleted { get; set; }
        public int? TeacherId { get; set; }
        public int? StudentId { get; set; }

        public Rols Rol { get; set; }
        public Students Student { get; set; }
        public Teachers Teacher { get; set; }
        public ICollection<PagesForUsers> PagesForUsers { get; set; }
    }
}
