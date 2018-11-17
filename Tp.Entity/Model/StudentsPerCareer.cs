using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class StudentsPerCareer
    {
        public int Id { get; set; }
        public int CareerId { get; set; }
        public int StudentId { get; set; }

        public Careers Career { get; set; }
        public Students Student { get; set; }
    }
}
