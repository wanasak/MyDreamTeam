using MyDreamTeam.Data.Infrastructure;
using MyDreamTeam.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDreamTeam.Data.Repositories
{
    public class FootballerRepository : RepositoryBase<Footballer>, IFootballerRepository
    {
        public FootballerRepository(IDbFactory dbFactory) : base(dbFactory)
        { }

        public override void Update(Footballer entity)
        {
            entity.DateUpdate = DateTime.Now;
            base.Update(entity);
        }

        //public Footballer GetFootballerByName(string name)
        //{
        //    var footballer = this.DbContext.Footballers
        //        .Where(f => f.LastName.ToLower() == name.ToLower()).FirstOrDefault();
        //    return footballer;
        //}
    }

    public interface IFootballerRepository : IRepository<Footballer>
    {
        //Footballer GetFootballerByName(string name);
    }
}
