using System;
using System.Collections.Generic;

namespace EfDbFirstTest.Model
{
    public partial class Person
    {
        public Person()
        {
            PersonBrand = new HashSet<PersonBrand>();
        }

        public Guid PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<PersonBrand> PersonBrand { get; set; }
    }
}
