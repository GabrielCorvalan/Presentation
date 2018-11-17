using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class Teachers
    {
        public Teachers()
        {
            PersonForAddress = new HashSet<PersonForAddress>();
            StudentFinalTest = new HashSet<StudentFinalTest>();
            SubjectsPerCareer = new HashSet<SubjectsPerCareer>();
            Tests = new HashSet<Tests>();
        }

        public int Id { get; set; }
        public string TeacherNames { get; set; }
        public long TeacherFile { get; set; }
        public string Surnames { get; set; }
        public long Dni { get; set; }
        public long Cuil { get; set; }
        public DateTime Birthdate { get; set; }
        public bool? Sex { get; set; }
        public string Email { get; set; }
        public bool? Deleted { get; set; }

        public ICollection<PersonForAddress> PersonForAddress { get; set; }
        public ICollection<StudentFinalTest> StudentFinalTest { get; set; }
        public ICollection<SubjectsPerCareer> SubjectsPerCareer { get; set; }
        public ICollection<Tests> Tests { get; set; }
    }
}
