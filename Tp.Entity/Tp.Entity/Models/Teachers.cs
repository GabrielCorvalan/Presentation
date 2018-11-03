using System;
using System.Collections.Generic;

namespace Tp.Entity.Tp.Entity.Models
{
    public partial class Teachers
    {
        public Teachers()
        {
            CareersSubjets = new HashSet<CareersSubjets>();
            StudentFinalTest = new HashSet<StudentFinalTest>();
            Tests = new HashSet<Tests>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public int Dni { get; set; }
        public int TeacherFile { get; set; }
        public int Cuil { get; set; }
        public bool Deleted { get; set; }

        public ICollection<CareersSubjets> CareersSubjets { get; set; }
        public ICollection<StudentFinalTest> StudentFinalTest { get; set; }
        public ICollection<Tests> Tests { get; set; }
    }
}
