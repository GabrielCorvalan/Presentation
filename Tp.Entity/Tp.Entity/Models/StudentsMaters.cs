using System;
using System.Collections.Generic;

namespace Tp.Entity.Tp.Entity.Models
{
    public partial class StudentsMaters
    {
        public Guid Id { get; set; }
        public Guid? SubjetId { get; set; }
        public Guid? StudentId { get; set; }
        public bool Annotated { get; set; }
        public Guid? SubjectStateId { get; set; }
        public int? QuarterStart { get; set; }
        public int? YearStart { get; set; }

        public Students Student { get; set; }
        public SubjectsStates SubjectState { get; set; }
        public Subjects Subjet { get; set; }
    }
}
