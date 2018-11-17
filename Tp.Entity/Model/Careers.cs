using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class Careers
    {
        public Careers()
        {
            StudentsPerCareer = new HashSet<StudentsPerCareer>();
            SubjectsPerCareer = new HashSet<SubjectsPerCareer>();
        }

        public int Id { get; set; }
        public string CareerName { get; set; }
        public bool? Deleted { get; set; }

        public ICollection<StudentsPerCareer> StudentsPerCareer { get; set; }
        public ICollection<SubjectsPerCareer> SubjectsPerCareer { get; set; }
    }
}
