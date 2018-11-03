using System;
using System.Collections.Generic;

namespace Tp.Entity.Tp.Entity.Models
{
    public partial class CareersStudents
    {
        public Guid Id { get; set; }
        public Guid? CareerId { get; set; }
        public Guid? StudentId { get; set; }

        public Careers Career { get; set; }
        public Students Student { get; set; }
    }
}
