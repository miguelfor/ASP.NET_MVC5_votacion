using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Democracy.Models
{
    public class DemocracyContext : DbContext
    {
        public DemocracyContext()
            : base("defaultConnection")
        {
        }

        public DbSet<State> State { get; set; }
    }
}