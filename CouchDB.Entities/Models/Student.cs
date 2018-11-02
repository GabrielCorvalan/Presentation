using System;
using System.Collections.Generic;
using System.Text;

namespace CouchDB.Entities.Models
{
    public class Student : Base
    {
        public string Name { get; set; }
        public int Years { get; set; }
        public string Career { get; set; }
        public string City { get; set; }
        public string LastName { get; set; }

    }
}
