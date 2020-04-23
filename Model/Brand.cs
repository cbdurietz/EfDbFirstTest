using System;
using System.Collections.Generic;

namespace EfDbFirstTest.Model
{
    public partial class Brand
    {
        public Brand()
        {
            PersonBrand = new HashSet<PersonBrand>();
        }

        public Guid BrandId { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<PersonBrand> PersonBrand { get; set; }
    }
}
