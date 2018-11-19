using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class Students
    {
        public Students()
        {
            PersonForAddress = new HashSet<PersonForAddress>();
            StudensPerSubject = new HashSet<StudensPerSubject>();
            StudentFinalTest = new HashSet<StudentFinalTest>();
            StudentsPerCareer = new HashSet<StudentsPerCareer>();
            Tests = new HashSet<Tests>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Names { get; set; }
        public string Surnames { get; set; }
        public long StudentFile { get; set; }
        public long Dni { get; set; }
        public long Cuil { get; set; }
        public DateTime Birthdate { get; set; }
        public bool? Sex { get; set; }
        public string Email { get; set; }
        public bool? Deleted { get; set; }

        public ICollection<PersonForAddress> PersonForAddress { get; set; }
        public ICollection<StudensPerSubject> StudensPerSubject { get; set; }
        public ICollection<StudentFinalTest> StudentFinalTest { get; set; }
        public ICollection<StudentsPerCareer> StudentsPerCareer { get; set; }
        public ICollection<Tests> Tests { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
