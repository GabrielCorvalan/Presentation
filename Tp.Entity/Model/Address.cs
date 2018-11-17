using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class Address
    {
        public Address()
        {
            PersonForAddress = new HashSet<PersonForAddress>();
        }

        public int Id { get; set; }
        public int CityId { get; set; }
        public int ZipCode { get; set; }
        public string Streets { get; set; }

        public Cities City { get; set; }
        public ICollection<PersonForAddress> PersonForAddress { get; set; }
    }
}
