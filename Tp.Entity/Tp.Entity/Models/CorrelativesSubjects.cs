using System;
using System.Collections.Generic;

namespace Tp.Entity.Tp.Entity.Models
{
    public partial class CorrelativesSubjects
    {
        public Guid Id { get; set; }
        public Guid? SubjectId { get; set; }
        public Guid? SubjectCorrelativeId { get; set; }

        public Subjects Subject { get; set; }
        public Subjects SubjectCorrelative { get; set; }
    }
}
