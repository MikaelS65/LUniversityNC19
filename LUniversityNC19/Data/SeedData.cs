using Bogus;
using LUniversityNC19.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LUniversityNC19.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider services)
        {
            var option = services.GetRequiredService<DbContextOptions<LUniversityNC19Context>>();
            using(var context = new LUniversityNC19Context(option))
            {
                //if (context.Students.Any())
                //{
                //    context.Students.RemoveRange(context.Students);
                //    context.Courses.RemoveRange(context.Courses);
                //    context.Enrollments.RemoveRange(context.Enrollments);
                //}

                var fake = new Faker("sv");

                var students = new List<Student>();

                for (int i = 0; i < 200; i++)
                {
                    var fname = fake.Name.FirstName();
                    var lname = fake.Name.LastName();

                    var student = new Student
                    {
                        FirstName = fname,
                        LastName = lname,
                        Email = fake.Internet.Email($"{fname} {lname}"),
                        Avatar = fake.Internet.Avatar(),
                        Address = new Address
                        {
                            City = fake.Address.City(),
                            Street = fake.Address.StreetAddress(),
                            ZipCode = fake.Address.ZipCode()
                        }
                    };
                    students.Add(student);
                }

                context.AddRange(students);
                context.SaveChanges();
            }
        }
    }
}
