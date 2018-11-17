using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class Classrooms
    {
        public Classrooms()
        {
            SubjectsPerCareer = new HashSet<SubjectsPerCareer>();
        }

        public int Id { get; set; }
        public string ClassromCode { get; set; }
        public bool? Deleted { get; set; }

        public ICollection<SubjectsPerCareer> SubjectsPerCareer { get; set; }
    }
}
