using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDreamTeam.Model
{
    public class Position
    {
        public Position()
        {
            this.DateCreated = DateTime.Now;
        }

        public int PositionID { get; set; }
        public string Name { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdate { get; set; }
        public virtual List<Footballer> Footballers { get; set; }

    }
}
