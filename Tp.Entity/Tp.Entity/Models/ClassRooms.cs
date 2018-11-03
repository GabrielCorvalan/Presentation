using System;
using System.Collections.Generic;

namespace Tp.Entity.Tp.Entity.Models
{
    public partial class ClassRooms
    {
        public ClassRooms()
        {
            CareersSubjets = new HashSet<CareersSubjets>();
        }

        public Guid Id { get; set; }
        public string ClassRomCode { get; set; }
        public bool Deleted { get; set; }

        public ICollection<CareersSubjets> CareersSubjets { get; set; }
    }
}
