using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDreamTeam.Web.ViewModels
{
    public class FootballerFormViewModel
    {
        public HttpPostedFileBase File { get; set; }

        // Prefix with "Form..." for using automapper
        public string FormFirstName { get; set; }
        public string FormLastName { get; set; }
        public decimal FormPrice { get; set; }
        public int FormPositionID { get; set; }
        public int ClubID { get; set; }
    }
}