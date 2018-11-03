using System;
using System.Collections.Generic;

namespace Tp.Entity.Tp.Entity.Models
{
    public partial class Tests
    {
        public Guid Id { get; set; }
        public Guid? SubjectId { get; set; }
        public Guid? StudentId { get; set; }
        public DateTime TestDate { get; set; }
        public short Grade { get; set; }
        public Guid? TeacherId { get; set; }

        public Students Student { get; set; }
        public Subjects Subject { get; set; }
        public Teachers Teacher { get; set; }
    }
}
