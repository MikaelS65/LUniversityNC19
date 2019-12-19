using AutoMapper;
using LUniversityNC19.Models;
using LUniversityNC19.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LUniversityNC19.Data
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Student, StudentListViewModel>();
        }
    }
}
