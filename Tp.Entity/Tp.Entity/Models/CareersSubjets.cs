using System;
using System.Collections.Generic;

namespace Tp.Entity.Tp.Entity.Models
{
    public partial class CareersSubjets
    {
        public Guid Id { get; set; }
        public Guid? CareerId { get; set; }
        public Guid? SubjectId { get; set; }
        public Guid? ClassroomId { get; set; }
        public int YearInCareer { get; set; }
        public int QuarterInCareer { get; set; }
        public Guid? TeacherId { get; set; }

        public Careers Career { get; set; }
        public ClassRooms Classroom { get; set; }
        public Subjects Subject { get; set; }
        public Teachers Teacher { get; set; }
    }
}
