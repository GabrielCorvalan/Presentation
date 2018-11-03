using System;
using System.Collections.Generic;

namespace Tp.Entity.Tp.Entity.Models
{
    public partial class StudentFinalTest
    {
        public Guid Id { get; set; }
        public Guid? SubjectId { get; set; }
        public Guid? StudentId { get; set; }
        public bool Annotated { get; set; }
        public DateTime FinalTestDate { get; set; }
        public Guid? TeacherId { get; set; }
        public short Grade { get; set; }

        public Students Student { get; set; }
        public Subjects Subject { get; set; }
        public Teachers Teacher { get; set; }
    }
}
