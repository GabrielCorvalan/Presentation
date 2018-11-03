using System;
using System.Collections.Generic;

namespace Tp.Entity.Tp.Entity.Models
{
    public partial class Students
    {
        public Students()
        {
            CareersStudents = new HashSet<CareersStudents>();
            StudentFinalTest = new HashSet<StudentFinalTest>();
            StudentsMaters = new HashSet<StudentsMaters>();
            Tests = new HashSet<Tests>();
        }

        public Guid Id { get; set; }
        public int StudentFile { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Dni { get; set; }
        public DateTime BirthDate { get; set; }
        public int Cuil { get; set; }
        public string Address { get; set; }
        public bool Deleted { get; set; }

        public ICollection<CareersStudents> CareersStudents { get; set; }
        public ICollection<StudentFinalTest> StudentFinalTest { get; set; }
        public ICollection<StudentsMaters> StudentsMaters { get; set; }
        public ICollection<Tests> Tests { get; set; }
    }
}
