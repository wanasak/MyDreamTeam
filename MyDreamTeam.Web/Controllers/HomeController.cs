using AutoMapper;
using MyDreamTeam.Model;
using MyDreamTeam.Service;
using MyDreamTeam.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyDreamTeam.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFootballerService footballerService;
        private readonly IPositionService positionService;
        private readonly IClubService clubService;

        public HomeController(
            IFootballerService footballerService,
            IPositionService positionService,
            IClubService clubService)
        {
            this.footballerService = footballerService;
            this.positionService = positionService;
            this.clubService = clubService;
        }

        // GET: Home
        public ActionResult Index(string position = null)
        {
            IEnumerable<PositionViewModel> footballerViewModel;
            IEnumerable<Position> positions;
            IEnumerable<Club> clubs;

            positions = positionService.GetPositions(position).ToList();
            clubs = clubService.GetClubs();

            footballerViewModel = Mapper.Map<IEnumerable<Position>, IEnumerable<PositionViewModel>>(positions);
            ViewBag.ClubID = new SelectList(clubs, "ClubID", "Name", null);
            return View(footballerViewModel);
        }

        public ActionResult Filter(string position, string footballerName)
        {
            IEnumerable<FootballerViewModel> footballerViewModel;
            IEnumerable<Footballer> footballers;

            footballers = footballerService.GetPositionFootballers(position, footballerName);
            footballerViewModel = Mapper.Map<IEnumerable<Footballer>, IEnumerable<FootballerViewModel>>(footballers);

            return View(footballerViewModel);
        }

        [HttpPost]
        public ActionResult Create(FootballerFormViewModel model)
        {
            if (model != null && model.File != null)
            {
                var footballer = Mapper.Map<FootballerFormViewModel, Footballer>(model);
                footballerService.CreateFootballer(footballer);

                string footballerPicture = System.IO.Path.Combine(model.File.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/Images/"), footballerPicture);
                model.File.SaveAs(path);

                footballerService.Save();
            }

            var position = positionService.GetPosition(model.FormPositionID);
            return RedirectToAction("Index", new { position = position.Name });
        }

        public ActionResult Detail(int footballerID)
        {

            return View();
        }
    }
}