using System;
using System.Collections.Generic;

namespace Tp.Entity.Model
{
    public partial class Subjects
    {
        public Subjects()
        {
            CorrelativesSubjectsSubject = new HashSet<CorrelativesSubjects>();
            CorrelativesSubjectsSubjectCorrelative = new HashSet<CorrelativesSubjects>();
            StudensPerSubject = new HashSet<StudensPerSubject>();
            StudentFinalTest = new HashSet<StudentFinalTest>();
            SubjectsPerCareer = new HashSet<SubjectsPerCareer>();
            Tests = new HashSet<Tests>();
        }

        public int Id { get; set; }
        public string SubjectName { get; set; }
        public bool? Deleted { get; set; }

        public ICollection<CorrelativesSubjects> CorrelativesSubjectsSubject { get; set; }
        public ICollection<CorrelativesSubjects> CorrelativesSubjectsSubjectCorrelative { get; set; }
        public ICollection<StudensPerSubject> StudensPerSubject { get; set; }
        public ICollection<StudentFinalTest> StudentFinalTest { get; set; }
        public ICollection<SubjectsPerCareer> SubjectsPerCareer { get; set; }
        public ICollection<Tests> Tests { get; set; }
    }
}
