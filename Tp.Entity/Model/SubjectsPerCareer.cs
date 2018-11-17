using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class SubjectsPerCareer
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int CareerId { get; set; }
        public int ClassroomId { get; set; }
        public int TeacherId { get; set; }
        public int YearInCareer { get; set; }
        public int QuarterInCareer { get; set; }

        public Careers Career { get; set; }
        public Classrooms Classroom { get; set; }
        public Subjects Subject { get; set; }
        public Teachers Teacher { get; set; }
    }
}
