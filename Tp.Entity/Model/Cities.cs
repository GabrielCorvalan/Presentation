using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class Cities
    {
        public Cities()
        {
            Address = new HashSet<Address>();
        }

        public int Id { get; set; }
        public string LocationName { get; set; }
        public int? ProvinceId { get; set; }

        public Locations Province { get; set; }
        public ICollection<Address> Address { get; set; }
    }
}
