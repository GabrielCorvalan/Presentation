using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class Tests
    {
        public int Id { get; set; }
        public int? SubjectId { get; set; }
        public int? StudentId { get; set; }
        public int? TeacherId { get; set; }
        public DateTime TestDate { get; set; }

        public Students Student { get; set; }
        public Subjects Subject { get; set; }
        public Teachers Teacher { get; set; }
    }
}
