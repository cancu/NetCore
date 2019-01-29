using AutoMapper;
using LifeIn2.Domain.Entities;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeIn2.RazorUI.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryVM>()
                .ForMember(vm => vm.CategoryId, map => map.MapFrom(m => m.CategoryId))
                .ForMember(vm => vm.CategoryName, map => map.MapFrom(m => m.CategoryName))
                .ForMember(vm => vm.Description, map => map.MapFrom(m => m.Description))
                .ForMember(vm => vm.Picture, map => map.Ignore());
            CreateMap<CategoryVM, Category>()
                 .ForMember(m => m.CategoryId, map => map.MapFrom(vm => vm.CategoryId))
                 .ForMember(m => m.CategoryName, map => map.MapFrom(vm => vm.CategoryName))
                 .ForMember(m => m.Description, map => map.MapFrom(vm => vm.Description))
                 .ForMember(m => m.Picture, map => map.Ignore());

            //CreateMap<Category, CategoryVM>().ReverseMap();



        }
    }
}
