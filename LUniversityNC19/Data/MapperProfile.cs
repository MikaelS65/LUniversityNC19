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
            CreateMap<Student, StudentAddViewModel>().ReverseMap();
            CreateMap<Student, StudentDTO>();

            CreateMap<Student, StudentDetailsViewModel>()
                .ForMember(
                        dest => dest.Attending,     //opt => opt.Ignore()
                        from => from.MapFrom(s => s.Enrollments.Count))
                .ForMember(
                       dest => dest.Courses,
                       from => from.MapFrom(s => s.Enrollments.Select(e => e.Course).ToList()));

            //CreateMap<StudentAddViewModel, Student>()
            //    .ForMember(
            //           dest => dest.Enrollments, opt => opt.Ignore())
            //    .ForPath(
            //            dest => dest.Address,
            //            from => from.MapFrom(model => new Address
            //            {
            //                City = model.AddressCity,
            //                Street = model.AddressStreet,
            //                ZipCode = model.AddressZipCode
            //            }));
        }
    }
}
