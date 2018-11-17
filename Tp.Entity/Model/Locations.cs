using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class Locations
    {
        public Locations()
        {
            Cities = new HashSet<Cities>();
        }

        public int Id { get; set; }
        public string LocationName { get; set; }
        public int? ProvinceId { get; set; }

        public Provinces Province { get; set; }
        public ICollection<Cities> Cities { get; set; }
    }
}
