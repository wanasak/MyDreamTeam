using MyDreamTeam.Data.Infrastructure;
using MyDreamTeam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDreamTeam.Data.Repositories
{
    public class PositionRepository : RepositoryBase<Position>, IPositionRepository
    {
        public PositionRepository(IDbFactory dbFactory) : base(dbFactory)
        { }

        public Position GetPositionByName(string name)
        {
            var position = this.DbContext.Positions.Where(p => p.Name.ToLower() == name.ToLower()).FirstOrDefault();
            return position;
        }
    }

    public interface IPositionRepository : IRepository<Position>
    {
        Position GetPositionByName(string name);
    }
}
