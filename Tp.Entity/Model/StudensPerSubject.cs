using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class StudensPerSubject
    {
        public int Id { get; set; }
        public int? SubjectId { get; set; }
        public int? StudentId { get; set; }
        public bool Annotated { get; set; }
        public int? QuarterStart { get; set; }
        public int? YearStart { get; set; }
        public int? SubjectStateId { get; set; }

        public Students Student { get; set; }
        public Subjects Subject { get; set; }
        public SubjectStates SubjectState { get; set; }
    }
}
