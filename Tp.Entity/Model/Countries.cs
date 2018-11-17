using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class Countries
    {
        public Countries()
        {
            Provinces = new HashSet<Provinces>();
        }

        public int Id { get; set; }
        public string CountryName { get; set; }

        public ICollection<Provinces> Provinces { get; set; }
    }
}
