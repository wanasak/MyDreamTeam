using MyDreamTeam.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDreamTeam.Data.Configuration
{
    public class ClubConfiguration : EntityTypeConfiguration<Club>
    {
        public ClubConfiguration()
        {
            ToTable("Clubs");
            Property(c => c.Name).IsRequired().HasMaxLength(50);
            Property(c => c.OfficialName).IsRequired().HasMaxLength(100);
            Property(c => c.League).IsRequired().HasMaxLength(50);
            Property(c => c.Country).IsRequired().HasMaxLength(50);
            Property(c => c.City).IsRequired().HasMaxLength(50);
        }
    }
}
