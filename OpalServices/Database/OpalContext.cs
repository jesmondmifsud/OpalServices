using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OpalServices.Entities;

namespace OpalServices.Database
{
    public class OpalContext : DbContext
    {
        public OpalContext()
        : base("Opal")
        {
        }

        public DbSet<User> Users { get; set; }

    }
}