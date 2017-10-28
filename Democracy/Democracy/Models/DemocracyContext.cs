using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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

        //desabilita borrrado en cascada
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<State> State { get; set; }

        public System.Data.Entity.DbSet<Democracy.Models.Group> Groups { get; set; }

        public System.Data.Entity.DbSet<Democracy.Models.Voting> Votings { get; set; }

        public System.Data.Entity.DbSet<Democracy.Models.User> Users { get; set; }
        public System.Data.Entity.DbSet<Democracy.Models.GroupMember> GroupMembers { get; set; }
    }
}