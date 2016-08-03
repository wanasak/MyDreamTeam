using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDreamTeam.Web.ViewModels
{
    public class PositionViewModel
    {
        public int PositionID { get; set; }
        public string Name { get; set; }
        public List<FootballerViewModel> Footballers { get; set; }
    }
}