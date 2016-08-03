using AutoMapper;
using MyDreamTeam.Model;
using MyDreamTeam.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDreamTeam.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            CreateMap<Position, PositionViewModel>();
            CreateMap<Footballer, FootballerViewModel>();
            CreateMap<Club, ClubViewModel>();
        }
    }
}