using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PryUserChaconPC.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<PryUserChaconPC.Models.Geo> Geos { get; set; }

        public System.Data.Entity.DbSet<PryUserChaconPC.Models.Address> Addresses { get; set; }

        public System.Data.Entity.DbSet<PryUserChaconPC.Models.Company> Companies { get; set; }

        public System.Data.Entity.DbSet<PryUserChaconPC.Models.Root> Roots { get; set; }
    }
}