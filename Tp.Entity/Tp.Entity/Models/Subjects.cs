using System;
using System.Collections.Generic;

namespace Tp.Entity.Tp.Entity.Models
{
    public partial class Subjects
    {
        public Subjects()
        {
            CareersSubjets = new HashSet<CareersSubjets>();
            CorrelativesSubjectsSubject = new HashSet<CorrelativesSubjects>();
            CorrelativesSubjectsSubjectCorrelative = new HashSet<CorrelativesSubjects>();
            StudentFinalTest = new HashSet<StudentFinalTest>();
            StudentsMaters = new HashSet<StudentsMaters>();
            Tests = new HashSet<Tests>();
        }

        public Guid Id { get; set; }
        public string SubjectName { get; set; }
        public bool Deleted { get; set; }

        public ICollection<CareersSubjets> CareersSubjets { get; set; }
        public ICollection<CorrelativesSubjects> CorrelativesSubjectsSubject { get; set; }
        public ICollection<CorrelativesSubjects> CorrelativesSubjectsSubjectCorrelative { get; set; }
        public ICollection<StudentFinalTest> StudentFinalTest { get; set; }
        public ICollection<StudentsMaters> StudentsMaters { get; set; }
        public ICollection<Tests> Tests { get; set; }
    }
}
