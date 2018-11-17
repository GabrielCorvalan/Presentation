using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class CorrelativesSubjects
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int SubjectCorrelativeId { get; set; }

        public Subjects Subject { get; set; }
        public Subjects SubjectCorrelative { get; set; }
    }
}
