using System;
using System.Collections.Generic;

namespace EfDbFirstTest.Model
{
    public partial class PersonBrand
    {
        public Guid PersonId { get; set; }
        public Guid BrandId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Person Person { get; set; }
    }
}
