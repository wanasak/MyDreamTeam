using MyDreamTeam.Data.Infrastructure;
using MyDreamTeam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDreamTeam.Data.Repositories
{
    public interface IClubRepository : IRepository<Club>
    {

    }
    public class ClubRepository : RepositoryBase<Club>, IClubRepository
    {
        public ClubRepository(IDbFactory dbFactory) : base(dbFactory)
        {
           
        }
    }
}
