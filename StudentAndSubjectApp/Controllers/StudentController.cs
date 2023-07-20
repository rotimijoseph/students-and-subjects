using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentAndSubjectApp.Models;

namespace StudentAndSubjectApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
        {
                new Student { Id = 1, FirstName = "Bern", Surname = "Oleszczak", Title = "Mr",
                Email = "boleszczak0@test.com"},
                new Student { Id = 2, FirstName = "Daria", Surname = "Innocenti", Title = "Ms",
                Email = "dinnocenti1@test.com"},
                new Student { Id = 3, FirstName = "Thorstein", Surname = "Cicchetto", Title = "Honorable",
                Email = "tcicchetto2@test.com"},
                new Student { Id = 4, FirstName = "Georgianna", Surname = "Brafield", Title = "Honorable",
                Email = "gbrafield3@test.com"},
                new Student { Id = 5, FirstName = "Bryanty", Surname = "Breche", Title = "Dr",
                Email = "bbreche4@test.com"},
                new Student { Id = 6, FirstName = "Murvyn", Surname = "Birchall", Title = "Rev",
                Email = "mbirchall5@test.com"},
                new Student { Id = 7, FirstName = "Sherline", Surname = "McNysche", Title = "Honorable",
                Email = "smcnysche6@test.com"},
                new Student { Id = 8, FirstName = "Dukie", Surname = "Neely", Title = "Honorable",
                Email = "dneely7@test.com"},
                new Student { Id = 9, FirstName = "Mil", Surname = "Udie", Title = "Honorable",
                Email = "mudie8@test.com"},
                new Student { Id = 10, FirstName = "Tiffany", Surname = "Philpot", Title = "Dr",
                Email = "tphilpot9@test.com"},
                new Student { Id = 11, FirstName = "Elga", Surname = "Braim", Title = "Rev",
                Email = "ebraima@test.com"},
                new Student { Id = 12, FirstName = "Zara", Surname = "Benettelli", Title = "Mr",
                Email = "zbenettellib@test.com"},
                new Student { Id = 13, FirstName = "Emogene", Surname = "Romera", Title = "Ms",
                Email = "eromerac@test.com"},
                new Student { Id = 14, FirstName = "Bail", Surname = "Reuble", Title = "Ms",
                Email = "breubled@test.com"},
                new Student { Id = 15, FirstName = "Borden", Surname = "Igoe", Title = "Rev",
                Email = "bigoee@test.com"},
                new Student { Id = 16, FirstName = "Essy", Surname = "Nation", Title = "Dr",
                Email = "enationf@test.com"},
                new Student { Id = 17, FirstName = "Arch", Surname = "Kitchen", Title = "Honorable",
                Email = "akitcheng@test.com"},
                new Student { Id = 18, FirstName = "Elle", Surname = "Beagrie", Title = "Dr",
                Email = "ebeagrieh@test.com"},
                new Student { Id = 19, FirstName = "Brietta", Surname = "Pietzker", Title = "Rev",
                Email = "bpietzkeri@test.com"},
                new Student { Id = 20, FirstName = "Dar", Surname = "Mallan", Title = "Honorable",
                Email = "dmallanj@test.com"}
        };
            return View(students);
        }
    }
}

