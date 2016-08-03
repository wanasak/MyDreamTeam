using AutoMapper;
using MyDreamTeam.Model;
using MyDreamTeam.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyDreamTeam.Web.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            CreateMap<FootballerFormViewModel, Footballer>()
                .ForMember(g => g.FirstName, map => map.MapFrom(vm => vm.FormFirstName))
                .ForMember(g => g.LastName, map => map.MapFrom(vm => vm.FormLastName))
                .ForMember(g => g.Price, map => map.MapFrom(vm => vm.FormPrice))
                .ForMember(g => g.Image, map => map.MapFrom(vm => vm.File.FileName))
                .ForMember(g => g.PositionID, map => map.MapFrom(vm => vm.FormPositionID));
        }
    }
}