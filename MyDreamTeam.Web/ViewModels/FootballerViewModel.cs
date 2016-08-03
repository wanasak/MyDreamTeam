using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDreamTeam.Web.ViewModels
{
    public class FootballerViewModel
    {
        public int FootballerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Image { get; set; }

        public decimal Price { get; set; }
        public int PositionID { get; set; }
        public ClubViewModel Club { get; set; }
        
    }
}