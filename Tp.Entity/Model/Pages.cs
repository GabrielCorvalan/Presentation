using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class Pages
    {
        public Pages()
        {
            PagesForRols = new HashSet<PagesForRols>();
            PagesForUsers = new HashSet<PagesForUsers>();
        }

        public int Id { get; set; }
        public string PageUrl { get; set; }
        public string Description { get; set; }
        public string Tittle { get; set; }

        public ICollection<PagesForRols> PagesForRols { get; set; }
        public ICollection<PagesForUsers> PagesForUsers { get; set; }
    }
}
