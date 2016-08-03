using MyDreamTeam.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDreamTeam.Data.Configuration
{
    public class FootballerConfiguration : EntityTypeConfiguration<Footballer>
    {
        public FootballerConfiguration()
        {
            ToTable("Footballers");
            Property(f => f.FirstName).IsRequired().HasMaxLength(50);
            Property(f => f.LastName).IsRequired().HasMaxLength(50);
            Property(f => f.Price).IsRequired().HasPrecision(12, 2);
            Property(f => f.PositionID).IsRequired();
        }
    }
}
