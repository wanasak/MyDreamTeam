using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDreamTeam.Data.Infrastructure
{
    public class DbFactory : Disposable ,IDbFactory
    {
        MyDreamTeamContext dbContext;

        public MyDreamTeamContext Init()
        {
            return dbContext ?? (dbContext = new MyDreamTeamContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
