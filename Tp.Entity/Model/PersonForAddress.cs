using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class PersonForAddress
    {
        public int Id { get; set; }
        public int? TeacherId { get; set; }
        public int? StudentsId { get; set; }
        public int AddressId { get; set; }

        public Address Address { get; set; }
        public Students Students { get; set; }
        public Teachers Teacher { get; set; }
    }
}
