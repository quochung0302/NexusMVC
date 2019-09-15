using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Nexus.Models
{
    public class NexusContext : DbContext
    {
        public NexusContext() : base()
        {

        }
        public DbSet<Advantage> Advantages { get; set; }
        

    }
}