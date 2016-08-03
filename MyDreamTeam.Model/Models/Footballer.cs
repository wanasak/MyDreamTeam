using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDreamTeam.Model
{
    public class Footballer
    {
        public int FootballerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdate { get; set; }
        public string Nationality { get; set; }

        public int PositionID { get; set; }
        public int ClubID { get; set; }
        public virtual Club Club { get; set; }
        public Position Position { get; set; }
    }
}
