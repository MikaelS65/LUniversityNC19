using LUniversityNC19.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LUniversityNC19.Core.ViewModels
{
    public class StudentDetailsViewModel
    {
        public int Id { get; set; }
        public string Avatar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string AddressStreet { get; set; }
        public string AddressCity { get; set; }
        public string AddressZipCode { get; set; }


        public int Attending { get; set; }
        public ICollection<Course> Courses { get; set; }


    }
}
