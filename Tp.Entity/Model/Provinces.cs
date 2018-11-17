using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class Provinces
    {
        public Provinces()
        {
            Locations = new HashSet<Locations>();
        }

        public int Id { get; set; }
        public string ProvinceName { get; set; }
        public int? CountryId { get; set; }

        public Countries Country { get; set; }
        public ICollection<Locations> Locations { get; set; }
    }
}
