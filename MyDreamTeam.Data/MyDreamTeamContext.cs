using MyDreamTeam.Data.Configuration;
using MyDreamTeam.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDreamTeam.Data
{
    public class MyDreamTeamContext : DbContext
    {
        public MyDreamTeamContext() : base("MyDreamTeamContext") { }

        public DbSet<Footballer> Footballers { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Club> Clubs { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FootballerConfiguration());
            modelBuilder.Configurations.Add(new PositionConfiguration());
            modelBuilder.Configurations.Add(new ClubConfiguration());
        }
    }
}
