using System;
using System.Collections.Generic;

namespace Tp.Entity.Tp.Entity.Models
{
    public partial class Careers
    {
        public Careers()
        {
            CareersStudents = new HashSet<CareersStudents>();
            CareersSubjets = new HashSet<CareersSubjets>();
        }

        public Guid Id { get; set; }
        public string CareerName { get; set; }
        public bool Deleted { get; set; }

        public ICollection<CareersStudents> CareersStudents { get; set; }
        public ICollection<CareersSubjets> CareersSubjets { get; set; }
    }
}
